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
    public partial class Principal : System.Web.UI.Page
    {
        public static string cadBD = "Server=localhost;Database=farmacia;Uid=root;Pwd=Leonardo99";
        static MySqlConnection conectarBD = new MySqlConnection(cadBD);
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaPublicacion();
            ConsultaProducto();

        }

        protected void ConsultaPublicacion()
        {
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from destacado", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                Ofertas_comunicacion.DataSource = Imagenes_p;
                Ofertas_comunicacion.DataBind();


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
                MySqlCommand prodc = new MySqlCommand("select * from products", conectarBD);
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
                //string strID = ((HiddenField)e.Item.FindControl("clave")).Value;
                //Session["ID"] = strID;
                Response.Redirect("iniciar sesion.aspx");

               

            }
          

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string busca = txt_buscar.Text;
            try
            {
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from products where name LIKE '"+busca+"%'", conectarBD);
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
    }
}