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

        String password = "123456";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == user)
            {

                if (TextBox2.Text == password)
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