using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
namespace Farmacia_san_juan
{
    public partial class crear_cuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            try
            {
                BD bd = new BD();
                if (Nombre.Text!="")
                {
                    if (Correo.Text!="")
                    {
                        if (Regex.IsMatch(Correo.Text, expresion))
                        {
                            if (pwd.Text!="" && pwd.Text.Length>=7)
                            {
                                if (pwd2.Text.Equals(pwd.Text))
                                {
                                    if (Genero.SelectedIndex>-1)
                                    {
                                        if (Nacimiento.Text!="dd/mm/aaaa" && Nacimiento.Text!="")
                                        {
                                            string nombre = Nombre.Text;
                                            string correo = Correo.Text;
                                            string password = pwd.Text;
                                            string genero = Genero.SelectedItem.Text;
                                            string fecha = Nacimiento.Text;
                                           int registros = bd.registrarUsuario(nombre, correo, password,genero,fecha);

                                            if (registros>0)
                                            {
                                                Response.Redirect("iniciar sesion.aspx");
                                                Response.Write("<script language='javascript' type='text/javascript'>alert('Se a registrado Corrctamente , inicia sesion para verificar!');</script>");
                                                
                                            }
                                            else
                                            {
                                                MensajeError("No se puedo registrar");
                                            }
                                        }
                                        else
                                        {
                                             MensajeError("Ingresa una fecha de nacimiento valida");
                                        }
                                    }
                                    else
                                    {
                                        MensajeError("selecciona un genero ");
                                    }
                                }
                                else
                                {
                                    MensajeError("no son iguales las contraseñas ");
                                }
                            }
                            else
                            {
                                MensajeError("ingresa una contraseña mayor a 7 digitos");
                            }
                        }
                        else
                        {
                            MensajeError("Coloca un correo valido ");
                        }
                    }
                    else
                    {
                        MensajeError("Coloca un Ccorreo ");
                    }
                }
                else
                {
                    MensajeError("Coloca un nombre ");
                }

            }
            catch (Exception)
            {
                MensajeError("Ocurrio un error al registrar, intentalo mas tarde ");
                
            }
        }


        public void MensajeError(string mensaje)
        {
            Error.Visible = true;
            MesaggeEr.Text = mensaje;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Error.Visible = false;
        }
    }
}