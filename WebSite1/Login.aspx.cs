using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            // Valido nombre de usuario y contraseña
            if (txtUsuario.Text.ToLower() == "admin" && txtContraseña.Text.ToLower() == "admin")
            {
                Page.Response.Write("Ingreso OK"    );
            }
            else
            {
                Page.Response.Write("Usuario y/o Contraseña incorrectos");
            }
        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            //Redirecciono a otra página que debería existir y para mostrar el mensaje tener dicho elemento
            Response.Redirect("~/Default.aspx?msj=Es usted un usuario muy descuidado, haga memoria");
        }
    }
}