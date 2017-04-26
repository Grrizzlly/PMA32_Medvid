using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webtryv4
{
    public partial class WebForm1 : System.Web.UI.Page
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

                    Response.Redirect("site/Myinfo.html");

                }
                else
                {

                    Label1.Text = "Ошибка авторизации!";

                }

            }

            else
            {

                Label1.Text = "Ошибка авторизации!";

            }
        }
    }
}