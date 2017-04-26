using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Web;
namespace server
{
    class Program
    {
        static StreamReader reader = new StreamReader("sheuld.html");
        static void Main(string[] args)
        {
            

            string Html = reader.ReadToEnd();
            reader = new StreamReader("style.css");

            string css = reader.ReadToEnd();

            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] cssMes = new byte[1024];
            
            Byte[] message = encoding.GetBytes("HTTP/1.1 200 OK\nContent-type: text/html\nContent-Length:" + Html.Length.ToString() + "\n\n" + Html);

            

            try
            {
               IPAddress localAddress = IPAddress.Parse("127.0.0.1");
                TcpListener listener = new TcpListener(localAddress, 2200);

                listener.Start(1);

                while (true)
                {
                    Console.WriteLine("Waiting for client {0}", listener.LocalEndpoint);
                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream io = client.GetStream();
                    
                    
                    client.Client.Receive(cssMes);
                    string s;
                    s=   encoding.GetString(cssMes);
                    //Console.WriteLine(s);
                    s=cut(s);
                    //Console.WriteLine(s);

                    string st;
                    



                    try
                    {
                        string type = getType(s);
                        string header = "HTTP/1.1 200 OK\nContent-type: " + null + "\nContent-Length:";
                        if (type == "image/png")
                        {
                            byte[] image = File.ReadAllBytes(s);
                            byte[] prefix = encoding.GetBytes(header + image.Length + "\n\n");
                            message = new byte[prefix.Length + image.Length];
                            Array.Copy(prefix, message, prefix.Length);
                            Array.Copy(image, 0, message, prefix.Length, image.Length);
                        }
                        else
                        {
                            reader = new StreamReader(s);
                            s = reader.ReadToEnd();
                            Console.WriteLine(getType(s));

                            message = encoding.GetBytes(header + s.Length.ToString() + "\n\n" + s);
                        }
                    }
                    catch(Exception)
                    {

                    }
                       // client.Close();
                    

                   // Console.WriteLine("Client conected {0}", client.Client.RemoteEndPoint);

                    
                    io.Write(message, 0, message.Length);
                    

                   // Console.WriteLine("Conection closed");
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.Message);
            }
        }

        static string returnPage(string s)
        {
            string[] sp = s.Split(' ');

            for(int i=0;i<sp.Length;i++)
            {
                if(sp[i].Contains("http://127.0.0.1:2200/"))
                {
                    s = "";
                    sp[i] = sp[i].Remove(0, 22);
                    sp = sp[i].Split('.');
                    return sp[0];



                    
                    
                }
            }

            return null;
        }

        static string cut(string s)
        {
            s = s.Remove(0, 5);
            string[] sp = s.Split(' ');
            return sp[0];
        }

        static string getType(string s)
        {
            string[] sp = s.Split('.');
            switch(sp[1]){ 
              
                case "html":
                return "text/html";
                break;
                case "css":
                    return "text/stylesheet";
                    break;
                case "png":
                    return "image/png";
                    break;
                default:
                    return null;

            }
        }

       
        }
    }

