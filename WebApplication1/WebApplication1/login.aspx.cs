using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using NewsPortal.DAL;
using NewsPortal.DAL.Entites;


namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect(ResolveUrl("regist.aspx"));
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (var context = new NewsPortalContext())
            {
                var users = context.Users.ToList();
                if (users.FirstOrDefault(x => x.Login == TextBox1.Text && x.Password == TextBox2.Text) != null)
                {
                    Response.Redirect(ResolveUrl("index.aspx"));
                }
            }
        }
    }
}