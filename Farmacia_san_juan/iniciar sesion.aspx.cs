using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmacia_san_juan
{
    public partial class iniciar_sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            try
            {
                if (Mail.Text!="")
                {
                    if (Regex.IsMatch(Mail.Text, expresion))
                    {
                        if (Password.Text!="")
                        {
                            string correo = Mail.Text;
                            string contrasena = Password.Text;
                            BD bd = new BD();
                        string id=bd.inicia_sesion(correo, contrasena);
                            if (id.Length>0)
                            {
                                Session["id"] = id;
                                Response.Redirect("Usuario.aspx");
                            }
                            else
                            {
                             string admin_length =  bd.inicia_sesion_admin(correo,contrasena);
                                if (admin_length.Length>0)
                                {
                                    Session["id"] = admin_length;
                                    Response.Redirect("Administrador.aspx");
                                }
                                else
                                {
                                    MensajeRrot("Correo y/o contraseña invalida ");
                                }

                            }
                        }
                        else
                        {
                            MensajeRrot("Coloca una contraseña");
                        }
                    }
                    else
                    {
                        MensajeRrot("Correo no esta bien escrito");
                    }
                }
                else
                {
                    MensajeRrot("Ingresa un correo");
                }
            }
            catch (Exception)
            {

                MensajeRrot("Ocurrio un error al iniciar sesion");
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Error.Visible = false;
        }

        public void MensajeRrot(string mensaje)
        {
            Error.Visible = true;
            MesaggeEr.Text = mensaje;
        }
    }
}