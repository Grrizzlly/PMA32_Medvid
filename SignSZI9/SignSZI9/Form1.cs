using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace SignSZI9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RSA rsa = new RSA();
       
        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger p = BigInteger.Parse(textBox1.Text);
            BigInteger q = BigInteger.Parse(textBox2.Text);
            try
            {
                if ((!PrimeCheck(p)) || (!PrimeCheck(q)))
                    throw new Exception("p and q must be prime");
                rsa.SetPQ(p, q);
                label3.Text = "n = " + rsa.N.ToString();
                label4.Text = "e = " + rsa.E.ToString();
                label5.Text = "d = " + rsa.D.ToString();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public bool PrimeCheck(BigInteger m)
        {
            int k = 0;
            for (int i = 1; i <= m; i++)
            {
                if (m % i == 0) k++;
            }
            if (k == 2 && m != 2)
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox5.Text = " ";
            richTextBox5.Text = rsa.Sign(richTextBox4.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = " ";
            richTextBox3.Text = rsa.UnSign(richTextBox5.Text);
            label6.Text = rsa.Check(richTextBox4.Text, richTextBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class BIGExtendedEuclidGCD
    {
        public BigInteger I
        {
            get;
            private set;
        }
        public BigInteger U
        {
            get;
            private set;
        }
        public BigInteger V
        {
            get;
            private set;
        }

        public BigInteger ExtendedGCD(BigInteger first, BigInteger second)
        {
            if (first == 0)
                throw new Exception("First argument is 0");
            if (second == 0)
                throw new Exception("Second argument is 0");
            first = BigInteger.Abs(first);
            second = BigInteger.Abs(second);

            BigInteger r0, r1, u0, u1, v0, v1, i;
            r0 = first;
            r1 = second;
            u0 = v1 = 1;
            v0 = u1 = 0;
            i = 1;
            BigInteger u_next = 0, v_next = 0;
            BigInteger q = 0;
            while ((r0 % r1) != 0)
            {
                q = r0 / r1;
                u_next = u0 - q * u1;
                v_next = v0 - q * v1;
                BigInteger value = r0 % r1;

                r0 = r1; r1 = value;
                u0 = u1; u1 = u_next;
                v0 = v1; v1 = v_next;
                ++i;
            }
            I = i;
            if (r1 == first)
                U = 1;
            else
                U = u_next;
            if (r1 == second && r1 != first)
            {
                U = 1;
                V = -1;
            }
            else
                V = v_next;
            return r1;
        }
    }
    class RSA
    {
        BigInteger n;
        BigInteger e;
        BigInteger d;

        public BigInteger N
        {
            get
            {
                return n;
            }
        }

        public BigInteger E { get { return e; } }

        public BigInteger D { set { d = value; } get { return d; } }

        public RSA()
        {
            n = e = d = 0;
        }


        public void SetPQ(BigInteger p, BigInteger q)
        {


            n = p * q;

            BigInteger fi = (p - 1) * (q - 1);
            Random rand = new Random();
            BIGExtendedEuclidGCD NSD = new BIGExtendedEuclidGCD();
            do
            {
                e = rand.Next(1, (int)fi);
            }
            while (NSD.ExtendedGCD(e, fi) != 1);

            BIGExtendedEuclidGCD egcd = new BIGExtendedEuclidGCD();
            egcd.ExtendedGCD(e, fi);

            d = egcd.U < 0 ? egcd.U + fi : egcd.U;


        }

        

        private string ConvertToString(BigInteger[] arr, char separator = ' ')
        {
            StringBuilder s = new StringBuilder(string.Empty);
            s.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                s.Append(arr[i].ToString());
                s.Append(separator);
            }
            return s.ToString();
        }

        private string ConvertTochar(BigInteger[] arr)
        {
            StringBuilder s = new StringBuilder(string.Empty);

            for (int i = 0; i < arr.Length; i++)
            {
                s.Append(Convert.ToChar(Convert.ToInt32(arr[i].ToString())));
            }
            return s.ToString();
        }
        
       
        public string Sign(string str)
        {
            string s = str;
            BigInteger[] arr = new BigInteger[s.Length];
            
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = BigInteger.ModPow((int)s[i], d, n);
               
            }
            return ConvertToString(arr, ' ');
        } 
        
        public string UnSign(string str)
        {
            char[] separator = { ' ', '\n' };
            string[] mas = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            BigInteger[] unsarr = new BigInteger[mas.Length];
            BigInteger arr2 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                arr2 = BigInteger.Parse(mas[i]);
                unsarr[i] = BigInteger.ModPow(arr2, e, n);
            }
            return ConvertTochar(unsarr);
        }
        public string Check(string str1, string str2)
        {
            if (str1 == str2) return "Correct";
            else return "Incorrect";
        }
    
    }
}
