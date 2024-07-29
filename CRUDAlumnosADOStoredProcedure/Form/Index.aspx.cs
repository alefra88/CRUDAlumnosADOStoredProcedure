using CRUDAlumnosADOStoredProcedure.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUDAlumnosADOStoredProcedure.DaL;
namespace CRUDAlumnosADOStoredProcedure.Form
{
    public partial class Index : System.Web.UI.Page
    {
        DAlumnos _dAlumnos = new DAlumnos();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Alumnos> lst = _dAlumnos.Consultar();
            dgv.DataSource = lst;
            dgv.DataBind();
        }
    }
}