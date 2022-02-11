using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINKTOENTITY
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }
        private void BindGridData()
        {
            // Create the object of the Context defined in the constructor of the context class.
            vishalEntities1 db = new vishalEntities1();
            var result = from emp in db.EmployeeDetails
                         select new
                         {
                             Id = emp.EmpId,
                             Name = emp.EmpName,
                             Location = emp.Location,
                             Gender = emp.Gender
                         };
            GridView.DataSource = result.ToList();
            GridView.DataBind();
        }
    }
}