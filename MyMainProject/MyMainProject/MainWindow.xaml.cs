using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Npgsql;
using Mono;
using MyMainProject;

namespace MyMainProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=412212249; Database=ForUnemployed"))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM unemployed", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
           

                while (dr.Read())
                {

                    textBox.Text += dr[0] + "\n";

                }
                dr.Close();
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            BLogica test = new BLogica();
            Information Inform = new Information("Bohdan", "Medvid",1997);
            unemployed q = test.Addump(Inform, "loyar",  "High",  "good",  "director", "Homework","","04567");
            textBox.Text = q.profesion;
        }
    }
}
