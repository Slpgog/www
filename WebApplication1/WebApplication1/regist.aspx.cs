using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsPortal.DAL;
using NewsPortal.DAL.Entites;

namespace WebApplication1
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var context = new NewsPortalContext())
            {
                var users = context.Users.ToList();
                if (TextBox2.Text == TextBox3.Text)
                {
                    if (users.FirstOrDefault(x => x.Login == TextBox1.Text) == null)
                    {
                        context.Users.Add(new User()
                        {
                            Login = TextBox1.Text,
                            Password = TextBox2.Text,
                            Email = TextBox4.Text
                        });

                        context.SaveChanges();
                        Response.Redirect(ResolveUrl("login.aspx"));

                    }
                }
            }


            
        }
    }
}