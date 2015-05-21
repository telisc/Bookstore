using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore.notepad
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RunSQL()
        {
            SqlDataSource1.SelectCommand = TextBox1.Text;
            DateTime dtBegin = DateTime.Now;
            SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            SqlDataSource1.DataBind();
            GridView1.DataBind();
            DateTime dtEnd = DateTime.Now;
            System.TimeSpan diff1 = dtEnd.Subtract(dtBegin);
            Label1.Text = String.Format("Success rows returned {0} duration {1}", GridView1.Rows.Count, diff1.ToString("c"));

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                RunSQL();
                
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message ;
                
            }
        }
    }
}