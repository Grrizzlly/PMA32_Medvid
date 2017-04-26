using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examserver
{
    public partial class login : System.Web.UI.Page
    {
        String user = "user1";
        List<Loginclass> Logins = new List<Loginclass>();
        String password = "123456";
        LoginContext dbase;
      
        protected void Page_Load(object sender, EventArgs e)
        {
           dbase = new LoginContext();
           
            //Logins[1].login = "user2";
            //Logins[1].pass = "111111";
            //Logins[2].login = "user3";
            //Logins[2].pass = "222222";
           // dbase.Logins.Load();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //foreach (Loginclass u in Logins)
            //{


            //    if (TextBox1.Text == u.login && TextBox2.Text == u.pass )
            //    {

            //            Response.Redirect("site/index.html");
            //    }
            //        else
            //        {

            //            Label1.Text = "Помилка авторизації!";

            //        }

            //    }
if (TextBox1.Text ==user )
               {
    if (TextBox2.Text ==password)
	{
		 
	

                        Response.Redirect("site/index.html");
                }
    else
                    {

                        Label1.Text = "Помилка авторизації!";

                    }
} 
            else
                    {

                        Label1.Text = "Помилка авторизації!";

                    }
    

                
               
            }
        
    }
}