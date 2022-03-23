using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Farmacia_san_juan
{
    public partial class Usuario : System.Web.UI.Page
    {

        public static string cadBD = "Server=localhost;Database=farmacia;Uid=root;Pwd=Leonardo99";
        static MySqlConnection conectarBD = new MySqlConnection(cadBD);

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaPublicacion();
            Carca_mi_lista();
            carga_mipedido();
            
            try
            {
                Session["id"].ToString();
                Id_usr.Text = "ID: "+ Session["id"].ToString();

            }
            catch (Exception)
            {
                Response.Redirect("iniciar sesion.aspx");
            }
           
        }

        public void Load_Click(object sender, EventArgs e){
        }


        public void Cargar_perfil_Click(object sender, EventArgs e)
        {
            cargarDatos_usuario();
            panel_perfil.Visible = true;
        }
        protected void cargarDatos_usuario()
        {
            try
            {
                int clave = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand sesion_usuario =
                new MySqlCommand("select * from usuarios where idUsuario=@Clave", conectarBD);
                sesion_usuario.Parameters.AddWithValue("@clave", clave);
                MySqlDataReader datosleidos = sesion_usuario.ExecuteReader();

                if (datosleidos.Read())
                {
                    name_usr.Text = datosleidos["name"].ToString();
                    Id_usr.Text = "ID: "+datosleidos["idUsuario"].ToString();
                   
                    txt_correo.Text = datosleidos["mail"].ToString();

                    password_del_usuario = datosleidos["password"].ToString();
                    lb_genero.Text = datosleidos["genero"].ToString();
                    txt_fechaN.Text = datosleidos["fechaNacimiento"].ToString();

                    txt_telefono.Text = datosleidos["phone"].ToString();
                    txt_direccion.Text = datosleidos["direccion"].ToString(); ;
                    
                }

                

            }
            catch (Exception)
            {

                Response.Redirect("iniciar sesion.aspx");
            }

            conectarBD.Close();
        }

        protected void ConsultaPublicacion()
        {
            try
            {
                //publicaciones
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from destacado", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                Ofertas_comunicacion.DataSource = Imagenes_p;
                Ofertas_comunicacion.DataBind();

                //productos
                MySqlCommand prodc1 = new MySqlCommand("select * from products", conectarBD);
                MySqlDataAdapter datosc1 = new MySqlDataAdapter(prodc1);
                DataSet dccliente1 = new DataSet();
                datosc1.Fill(dccliente1);
                DataTable Imagenes_p1 = new DataTable();
                Imagenes_p1.Load(prodc1.ExecuteReader());
                repetidor.DataSource = Imagenes_p1;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();

        }

        protected void ConsultaProducto()
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc1 = new MySqlCommand("select * from products", conectarBD);
                MySqlDataAdapter datosc1 = new MySqlDataAdapter(prodc1);
                DataSet dccliente1 = new DataSet();
                datosc1.Fill(dccliente1);
                DataTable Imagenes_p1 = new DataTable();
                Imagenes_p1.Load(prodc1.ExecuteReader());
                repetidor.DataSource = Imagenes_p1;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();

        }

        //para ver productos de farmacia
        public void Categoria_Farmacia_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();

        }

        public void subcategoria_Ojos_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Cuidado de los ojos'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_pies_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Cuidado de los pies'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_fiebre_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Dolor y fiebre'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_estomacal_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Estomacal'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_gineocologia_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Gineocologia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_embarazo_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Pruebas de enbarazo'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_sueros_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Sueros'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_gripa_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Gripa y tos'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_curacion_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Curacion'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_vitamina_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Vitaminas y minerales'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_suplementos_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Farmacia' and subcategoria='Suplementos'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        //para ver productos de diabtes
        public void Categoria_Diabetes_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_medicion_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Articulo de medicion'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_dermatologia_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Demartolofia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }


        public void subcategoria_tos_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Gripa y tos'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Suplementos_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Suplementos alimenticios'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Curacion_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Material de curacion'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_especializados_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Especializados'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_minerales_Click(object sender, EventArgs e)
        {

            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Diabetes' and subcategoria='Vitaminas y Minerales'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        //para ver productos de bebe
        public void Categoria_Bebe_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_formulas_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Formulas'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_leches_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Leche'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Alimentacion_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Alimentacion bebe'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_panales_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Pañales y toallas'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_cuidado_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Cuidado del bebe'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_latancia_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Embarazo y latancia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Infantiles_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Bebe' and subcategoria='Medicamentos bebes'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }



        //para ver productos de belleza y derma
        public void Categoria_Belleza_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_accesorios_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Accesorios'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Derma_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Derma'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Fragancia_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Fragancia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Maquillaje_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Maquillaje'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Mascarilla_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Mascarillas'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_outlet_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Outlet de belleza'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Rutinas_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Belleza y Derma' and subcategoria='Rutinas'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        //para ver productos de cuidado hombre
        public void Categoria_hombre_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Cuidado Hombre'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_afeitado_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Cuidado Hombre' and subcategoria='Afeitado'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_capilar_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Cuidado Hombre' and subcategoria='Capilar'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_corporal_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Cuidado Hombre' and subcategoria='Corporal'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_facial_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Cuidado Hombre' and subcategoria='Cuidado facial'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_fraganciaH_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Cuidado Hombre' and subcategoria='Fragancia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        //para ver productos de higiene personal
        public void Categoria_higiene_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_articulos_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Articulos para el hogar'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_bucal_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Cuidado bocal'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_icontigencia_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='icontigencia'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_afeitadoH_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Afeitado'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_desodorantesH_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Desodorantes'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_viaje_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Articulos de viaje'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_cabello_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Cuidado del cabello'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_piel_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Cuidado de la piel'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_femenina_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Proteccion femenina'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_jabones_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Higiene personal' and subcategoria='Jabones'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }


        //para ver productos de bienestar sexual
        public void Categoria_sexual_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Salud sexual'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_SuplementosS_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Salud sexual' and subcategoria='Suplementos'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Perservativos_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Salud sexual' and subcategoria='Perservativos'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_Lubricante_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Salud sexual' and subcategoria='Lubricantes'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void subcategoria_AcSexual_Click(object sender, EventArgs e)
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where categoria='Salud sexual' and subcategoria='Accesorios sexuales'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        //obtiene la clave 
        public void Agrega_carrito_Click(object sender, EventArgs e)
        {


        }

        protected void repetidor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "obtenerP")
            {
                string idp = ((HiddenField)e.Item.FindControl("clave")).Value;
                int strID = Convert.ToInt32(idp);
                try
                {
                    int clave = Convert.ToInt32(Session["id"].ToString());

                    conectarBD.Open();
                    MySqlCommand producto =
                    new MySqlCommand("select * from products where claveP=@strID", conectarBD);
                    producto.Parameters.AddWithValue("@strID", strID);
                    MySqlDataReader datosleidos = producto.ExecuteReader();

                    if (datosleidos.Read())
                    {

                        string nombre_producto = datosleidos["name"].ToString();
                        string p_p = datosleidos["presio"].ToString();
                        int Precio_delP = Convert.ToInt32(p_p);

                        BD bd = new BD();
                      int se_enlisto=  bd.mi_listaP(clave,strID,nombre_producto,Precio_delP);
                        if (se_enlisto>0)
                        {
                            Carca_mi_lista();
                            Carca_mi_lista();
                            Response.Write(@"<script language='javascript'> alert('se agrego a tu lista'); </script>");
                           
                        }
                        else
                        {
                            Response.Write(@"<script language='javascript'> alert('No se pudo Agregar a tu lista '); </script>");
                        }

                    }
                    else
                    {
                        Response.Write(@"<script language='javascript'> alert('ocurrio un error al consultar el producto'); </script>");
                    }



                }
                catch (Exception)
                {

                    Response.Write(@"<script language='javascript'> alert('ocurrio un error al agregar a la lista'); </script>");
                }

                conectarBD.Close();
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {   
            try
            {
                string busca = txt_buscar.Text;
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where name LIKE '" + busca + "%'", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repetidor.DataSource = Imagenes_p;
                repetidor.DataBind();


            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        protected void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        public string password_del_usuario;
        
        public void Actualiza_usd_Click(object sender, EventArgs e)
        {

            string mail = txt_correo.Text;
            string fecha = txt_fechaN.Text;
            string telefono = txt_telefono.Text;
            string direccion = txt_direccion.Text;
            int ID_U = Convert.ToInt32(Session["id"].ToString());
            BD bd = new BD();


                string pass_search=bd.comprueba_password(txt_pwd.Text);
                if (pass_search.Length>0)
                {
                string pwe_new = new_pwd.Text;
                if (pwe_new.Length>0)
                    {
                    int actualizado = 0;
                    actualizado =bd.Actualiza_usuarios_pwd(ID_U,mail,pwe_new,fecha,telefono,direccion);
                        if (actualizado>0)
                        {
                            Response.Write(@"<script language='javascript'> alert('se actualizaron los datos'); </script>");
                        }
                        else
                        {
                            Response.Write(@"<script language='javascript'> alert('no se puedo actualizar los datos" + ID_U + "'); </script>");
                        }
                    }
                    else
                    {
                    int actualizado = 0;
                      actualizado= bd.Actualiza_usuarios(ID_U, mail, fecha, telefono, direccion);
                        if (actualizado > 0)
                        {
                            Response.Write(@"<script language='javascript'> alert('se actualizaron los datos'); </script>");
                        }
                        else
                        {
                            Response.Write(@"<script language='javascript'> alert('no se puedo actualizar los datos "+ID_U+"'); </script>");
                        }
                    }
                    
                }
                else
                {
                    Response.Write(@"<script language='javascript'> alert('contraseña incorrecta no se guardaron los cambios "+ txt_pwd.Text +"/"+ pass_search + "'); </script>");
                }
            

        }

        public void Cerrar_sesion_Click(object sender, EventArgs a)
        {
            Session.Remove("id");
            Response.Redirect("Principal.aspx");

        }


        public void Carca_mi_lista()
        {
            try
            {
                int IdU = Convert.ToInt32( Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from mi_listaP where IdUsuario="+IdU+" ", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);


                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repite_lista.DataSource = Imagenes_p;
                repite_lista.DataBind();
                //carga pedidos
                

                //muestra una lista junta 
                MySqlDataReader reader = prodc.ExecuteReader();
                List<int> resultado = new List<int>();

                List<string> resultado1 = new List<string>();
                while (reader.Read())
                {
                    resultado1.Add(reader["nombreP"].ToString());
                    resultado.Add(Convert.ToInt32(reader["precio"].ToString()));
                }

                int lista_de_productos = 0;
                foreach (int item in resultado)
                {
                    lista_de_productos = lista_de_productos + item;
                }

                MI_Lista_junta.Text = Convert.ToString(lista_de_productos);

                string lista_de_productos1 = "";
                foreach (string item in resultado1)
                {
                    lista_de_productos1 = lista_de_productos1 + item+" ";
                }

                pp.Text = lista_de_productos1;

               

            }
            catch (Exception)
            {
              
                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();

        }


        protected void repite_lista_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName== "eliminaP")
            {
                try
                {
                    string NumList = ((HiddenField)e.Item.FindControl("claveList")).Value;
                    int claveL = Convert.ToInt32(NumList);
                    int eliminados = 0;
                    conectarBD.Open();
                    MySqlCommand elimina_pl = new MySqlCommand("delete from mi_listaP where NoL=@claveL", conectarBD);
                    elimina_pl.Parameters.AddWithValue("@claveL", claveL);
                    eliminados = elimina_pl.ExecuteNonQuery();

                    if (eliminados > 0)
                    {
                        int IdU = Convert.ToInt32(Session["id"].ToString());
                        MySqlCommand prodc = new MySqlCommand("select * from mi_listaP where IdUsuario=" + IdU + " ", conectarBD);
                        MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                        DataSet dccliente = new DataSet();
                        datosc.Fill(dccliente);
                        DataTable Imagenes_p = new DataTable();
                        Imagenes_p.Load(prodc.ExecuteReader());
                        repite_lista.DataSource = Imagenes_p;
                        repite_lista.DataBind();
                        //muestra una lista junta 
                        MySqlDataReader reader = prodc.ExecuteReader();
                        List<int> resultado = new List<int>();

                        List<string> resultado1 = new List<string>();
                        while (reader.Read())
                        {
                            resultado1.Add(reader["nombreP"].ToString());
                            resultado.Add(Convert.ToInt32(reader["precio"].ToString()));
                        }

                        int lista_de_productos = 0;
                        foreach (int item in resultado)
                        {
                            lista_de_productos = lista_de_productos + item;
                        }

                        MI_Lista_junta.Text = Convert.ToString(lista_de_productos);

                        string lista_de_productos1 = "";
                        foreach (string item in resultado1)
                        {
                            lista_de_productos1 = lista_de_productos1 + item;
                        }

                        pp.Text = lista_de_productos1;
                        Carca_mi_lista();
                        Carca_mi_lista();
                        Response.Write(@"<script language='javascript'> alert('se elimino de la lista'); </script>");

                    }
                    else
                    {
                        Response.Write(@"<script language='javascript'> alert('no se puedo eliminar de la lista'); </script>");
                    }
                }
                catch (Exception)
                {

                    Response.Write(@"<script language='javascript'> alert('ocurrio un error al eliminar'); </script>");
                }

                conectarBD.Close();

            }
        }

        public void Realiza_pedido_Click(object sender , EventArgs e)
        {
            try { 
           
                int IdU = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from mi_listaP where IdUsuario=" + IdU + " ", conectarBD);
                MySqlDataReader reader = prodc.ExecuteReader();
                if (reader.Read())
                   {
                    //producto
                    List<string> resultado1 = new List<string>();
                    while (reader.Read())
                    {
                        resultado1.Add(reader["nombreP"].ToString());
                    }

                    string lista_de_productos1 = "";
                    foreach (string item in resultado1)
                    {
                        lista_de_productos1 = lista_de_productos1 + item;
                    }


                    int precioT = Convert.ToInt32(MI_Lista_junta.Text);

                    string fecha = System.DateTime.Now.ToShortDateString();
                    
                    BD bd = new BD();
                    int re_realizo= bd.registra_pedido(IdU, pp.Text, precioT,fecha);

                    if (re_realizo>0)
                    {
                        carga_mipedido();
                        carga_mipedido();
                        Response.Write(@"<script language='javascript'> alert('Se realizo tu pedido'); </script>");
                    }
                    else
                    {
                        Response.Write(@"<script language='javascript'> alert('no se puedo realizar tu pedido'); </script>");
                    }
               
                }


            }
            catch (Exception)
            {
                Response.Write(@"<script language='javascript'> alert('ocurrio un error al hacer el pedido'); </script>");
            }

            conectarBD.Close();
        }

        public void repite_misPedidos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName == "cancelaPD")
            {
                string estado_p = ((HiddenField)e.Item.FindControl("estado")).Value;

                if (estado_p.Equals("Cancelado") || estado_p.Equals("Entregado"))
                {
                    Response.Write(@"<script language='javascript'> alert('el producto ya habia sido " + estado_p + "'); </script>");
                }
                else
                {

                    string pedido = ((HiddenField)e.Item.FindControl("clave_pedidos")).Value;
                    int clave_pedido1 = Convert.ToInt32(pedido);
                    int actualizados = 0;
                    conectarBD.Open();
                    MySqlCommand cancela_pedido = new MySqlCommand("update pedidos set estado='Cancelado' where Nopedido=@clave_pedido1", conectarBD);
                    cancela_pedido.Parameters.AddWithValue("@clave_pedido1", clave_pedido1);

                    try
                    {
                        actualizados = cancela_pedido.ExecuteNonQuery();
                        if (actualizados > 0)
                        {
                            carga_mipedido();
                            carga_mipedido();

                            Response.Write(@"<script language='javascript'> alert('se cancelo el pedido'); </script>");
                        }
                        else
                        {
                            Response.Write(@"<script language='javascript'> alert('no se puedo cancelar el pedido'); </script>");
                        }
                    }
                    catch (Exception)
                    {

                        Response.Write(@"<script language='javascript'> alert('hubo un error al cancelar el pedido por favor intenta mas tarde'); </script>");
                    }

                }
              
            }
            conectarBD.Close();
        }

        public void carga_mipedido()
        {
            try
            {
                int IdU = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from pedidos where idUsuario=" + IdU + " ", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);

                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repite_misPedidos.DataSource = Imagenes_p;
                repite_misPedidos.DataBind();

               

            }
            catch (Exception)
            {
              
                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }
    }
}