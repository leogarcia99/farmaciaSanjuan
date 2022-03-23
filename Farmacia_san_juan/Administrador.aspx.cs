using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace Farmacia_san_juan
{

    public partial class Administrador : System.Web.UI.Page
    {
        public static string cadBD = "Server=localhost;Database=farmacia;Uid=root;Pwd=Leonardo99";
        static MySqlConnection conectarBD = new MySqlConnection(cadBD);

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaImagen();
            ConsultaPublicacion();
            carga_mipedido();
            carga_usuarios();
            carga_administradores();
            try
            {
                Session["id"].ToString();
                Id_usr.Text= Session["id"].ToString();
                cargarDatos_admin();
            }
            catch (Exception)
            {

                Response.Redirect("iniciar sesion.aspx");
            }

           

        }

        protected void Calve_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category.Text.Equals("Diabetes"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Articulo de medicion");
                subcategoria.Items.Add("Dermatolofia");
                subcategoria.Items.Add("Gripa y tos");
                subcategoria.Items.Add("Suplemetos alimenticios");
                subcategoria.Items.Add("Material de curacion");
                subcategoria.Items.Add("Especializados");
                subcategoria.Items.Add("Vitaminas y Minerales");
            }

            if (Category.Text.Equals("Farmacia"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Cuidado de los pies");
                subcategoria.Items.Add("Cuidado de los ojos");
                subcategoria.Items.Add("Dolor y fiebre");
                subcategoria.Items.Add("Estomacal");
                subcategoria.Items.Add("Ginecologia");
                subcategoria.Items.Add("Pruebas de enbarazo");
                subcategoria.Items.Add("Sueros");
                subcategoria.Items.Add("Gripa y tos");
                subcategoria.Items.Add("Curacion");
                subcategoria.Items.Add("Vitaminas y minerales");
                subcategoria.Items.Add("Suplemetos");

            }
            if (Category.Text.Equals("Bebe"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Formulas");
                subcategoria.Items.Add("Leche");
                subcategoria.Items.Add("Alimentacion Bebe");
                subcategoria.Items.Add("Pañales y toallas");
                subcategoria.Items.Add("Cuidado del bebe");
                subcategoria.Items.Add("Embarazo y latancia");
                subcategoria.Items.Add("Medicamentos bebes");

            }

            if (Category.Text.Equals("Belleza y Derma"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Accesorios");
                subcategoria.Items.Add("Derma");
                subcategoria.Items.Add("Fragancia");
                subcategoria.Items.Add("Maquillaje");
                subcategoria.Items.Add("Mascarillas");
                subcategoria.Items.Add("Outlet de belleza");
                subcategoria.Items.Add("Rutinas");
            }

            if (Category.Text.Equals("Cuidado Hombre"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Afeitado");
                subcategoria.Items.Add("Capilar");
                subcategoria.Items.Add("Corporal");
                subcategoria.Items.Add("Cuidado Facial");
                subcategoria.Items.Add("Fragancia");

            }

            if (Category.Text.Equals("Higiene personal"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Articulos para el hogar");
                subcategoria.Items.Add("Cuidado bocal");
                subcategoria.Items.Add("incontigencia");
                subcategoria.Items.Add("Afeitado");
                subcategoria.Items.Add("Desodorantes");
                subcategoria.Items.Add("Articulos de viaje");
                subcategoria.Items.Add("Cuidado del cabello");
                subcategoria.Items.Add("Cuidado de la piel");
                subcategoria.Items.Add("Proteccion femenina");
                subcategoria.Items.Add("Jabones");
            }

            if (Category.Text.Equals("Salud sexual"))
            {
                subcategoria.Items.Clear();
                subcategoria.Items.Add("Suplementos");
                subcategoria.Items.Add("Perservativos");
                subcategoria.Items.Add("Lubricantes");
                subcategoria.Items.Add("Accesorios sexuales");
            }
        }

        protected void Category_Disposed(object sender, EventArgs e)
        {
        }

        protected void Category_Init(object sender, EventArgs e)
        {

        }

        protected void Category_Load(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        { 
            try
            {
                int claveP = Convert.ToInt32(Clave.Text);
                conectarBD.Open();
                MySqlCommand sesion_usuario =
                new MySqlCommand("select * from products where claveP=@ClaveP", conectarBD);
                sesion_usuario.Parameters.AddWithValue("@claveP", claveP);
                MySqlDataReader datosleidos = sesion_usuario.ExecuteReader();

                if (datosleidos.Read())
                {
                    Name.Text = datosleidos["name"].ToString();
                    Category.Text = datosleidos["categoria"].ToString();
                    subcategoria.Text = datosleidos["subcategoria"].ToString();
                    Descripcion.Text = datosleidos["descripcion"].ToString();
                    Presio.Text = datosleidos["presio"].ToString();
                    ConsultaImagen();
                    Error.Visible = false;
                   
                    Notificacion_P("se econtro el producto!");


                }
                else
                {
                   
                    error("No se encontro el Producto");
                    Notification.Visible = false;
                    ConsultaImagen();
                }

            }
            catch (Exception)
            {

                error("Ocurrio un error al buscar el producto");
                Notification.Visible = false;
                ConsultaImagen();
            }
        }

        protected void Buscar_PreRender(object sender, EventArgs e)
        {
            
        }

        protected void Buscar_Unload(object sender, EventArgs e)
        {
           
        }

        protected void Category_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void Image_DataBinding(object sender, EventArgs e)
        {

            Image1.Visible = true;
            int tamanio1 = Image2.PostedFile.ContentLength;
            byte[] original1 = new byte[tamanio1];
            Image2.PostedFile.InputStream.Read(original1, 0, tamanio1);
            Bitmap originalBinario = new Bitmap(Image2.PostedFile.InputStream);
            string imagenUrl641 = "data:image/jpg;base64," + Convert.ToBase64String(original1);
            Image1.ImageUrl = imagenUrl641;
        }

        protected void Image_Disposed(object sender, EventArgs e)
        {
            

        }

        protected void Preview_Click(object sender, EventArgs e)
        {
            Image1.Visible = true;
            int tamanio1 = Image2.PostedFile.ContentLength;
            byte[] original1 = new byte[tamanio1];
            Image2.PostedFile.InputStream.Read(original1, 0, tamanio1);
            Bitmap originalBinario = new Bitmap(Image2.PostedFile.InputStream);
            string imagenUrl641 = "data:image/jpg;base64," + Convert.ToBase64String(original1);
            Image1.ImageUrl = imagenUrl641;


        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanio = Image2.PostedFile.ContentLength;
                byte[] original = new byte[tamanio];
                Image2.PostedFile.InputStream.Read(original, 0, tamanio);
                Bitmap originalBinario = new Bitmap(Image2.PostedFile.InputStream);
                string nombre = Name.Text;

                string categoria = Category.Text;
                string sub_categoria = subcategoria.Text;
                String descripcion = Descripcion.Text;
                int precio = Convert.ToInt32(Presio.Text);

                System.Drawing.Image imgthumbali;
                int tamanio_th = 200;
                imgthumbali = redinmencionarimagen(originalBinario, tamanio_th);
                byte[] Bimagen_th = new byte[tamanio_th];
                ImageConverter convertidor = new ImageConverter();
                Bimagen_th = (byte[])convertidor.ConvertTo(imgthumbali, typeof(byte[]));

                BD bd = new BD();
                int registros = bd.resgistraP(nombre, Bimagen_th, categoria, sub_categoria, descripcion, precio);
                if (registros > 0)
                {
                    Error.Visible = false;
                    Notificacion_P("Se ha registrado Correctamente");
                    Name.Text = "";
                    Descripcion.Text = "";
                    Presio.Text = "";
                    ConsultaImagen();
                    ConsultaImagen();
                }
                else
                {
                    Notification.Visible = false;
                    error("Ocurrio un error al Registrar");

                    Name.Text = "";
                    Descripcion.Text = "";
                    Presio.Text = "";
                }
            }
            catch (Exception)
            {

                Notification.Visible = false;
                error("Ocurrio un error al Registrar");
            }

           
                 
            }

        protected void datosCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public System.Drawing.Image redinmencionarimagen(System.Drawing.Image imagenoriginal, int alto)
        {
            var radio =(double)alto / imagenoriginal.Height;
            var nuevoArchivo = (int)(imagenoriginal.Width * radio);
            var nuevoAlto = (int)(imagenoriginal.Height * radio);
            var nueva_imagen = new Bitmap(nuevoArchivo, nuevoAlto);
            var g = Graphics.FromImage(nueva_imagen);
            g.DrawImage(imagenoriginal, 0, 0, nuevoArchivo, nuevoAlto);
            return nueva_imagen;
        }

        protected void ConsultaImagen()
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

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                BD bd = new BD();
                int clave = Convert.ToInt32(Clave.Text);
                int eliminados = bd.eliminar_producto(clave);

                if (eliminados > 0)
                {
                    Error.Visible = false;
                    Notificacion_P("Se elimino el producto");
                    Buscar.Text = "";
                    ConsultaImagen();
                    ConsultaImagen();
                }
            }
            catch (Exception )
            {
                Notification.Visible = false;
                error("ocurrio un error al eliminar el producto");

            }

        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanio = Image2.PostedFile.ContentLength;
                byte[] original = new byte[tamanio];
                Image2.PostedFile.InputStream.Read(original, 0, tamanio);
                Bitmap originalBinario = new Bitmap(Image2.PostedFile.InputStream);
                int claveP = Convert.ToInt32( Clave.Text);
                string nombre = Name.Text;

                string categoria = Category.Text;
                string sub_categoria = subcategoria.Text;
                String descripcion = Descripcion.Text;
                int precio = Convert.ToInt32(Presio.Text);
                System.Drawing.Image imgthumbali;
                int tamanio_th = 200;
                imgthumbali = redinmencionarimagen(originalBinario, tamanio_th);

                byte[] Bimagen_th = new byte[tamanio_th];
                ImageConverter convertidor = new ImageConverter();
                Bimagen_th = (byte[])convertidor.ConvertTo(imgthumbali, typeof(byte[]));
                BD bd = new BD();

                int Actualizados = bd.Actualiza_productos(claveP, nombre, Bimagen_th, categoria, sub_categoria, descripcion, precio);
                if (Actualizados>0)
                {
                    Error.Visible = false;
                    Notificacion_P("El producto se actualizo!");
                    Clave.Text = "";
                    Name.Text = "";
                    Descripcion.Text = "";
                    Presio.Text = "";
                    ConsultaImagen();
                    ConsultaImagen();
                }
            }
            catch (Exception)
            {
                Notification.Visible = false;
                error("Ocurrio un error al Actualizar");
                Clave.Text = "";
                Name.Text = "";
                Descripcion.Text = "";
                Presio.Text = "";
                ConsultaImagen();
            }
        }

        public void Notificacion_P(string mensaje)
        {
          
            Notification.Visible = true;
           
            Mesagge.Text = mensaje;

            
            

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Notification.Visible = false;
            Error.Visible = false;

            Img_Succes.Visible = false;
            Img_error.Visible = false;
        }
        public void error(string mensaje)
        {
            Error.Visible = true;
            MesaggeEr.Text = mensaje;
        }

        protected void Publicar_Click(object sender, EventArgs e)
        {
            try { 
            //convierte imagen a binario 
                int tamanio = Publicacion_img.PostedFile.ContentLength;
                byte[] original = new byte[tamanio];
                Publicacion_img.PostedFile.InputStream.Read(original, 0, tamanio);
                Bitmap originalBinario = new Bitmap(Publicacion_img.PostedFile.InputStream);
            //reduce el tamaño
                System.Drawing.Image imgthumbali;
                int tamanio_th = 600;
                imgthumbali = redinmencionarimagen(originalBinario, tamanio_th);
            //se utiliza para guardar
                byte[] Bimagen_th = new byte[tamanio_th];
                ImageConverter convertidor = new ImageConverter();
                Bimagen_th = (byte[])convertidor.ConvertTo(imgthumbali, typeof(byte[]));

                BD bd = new BD();
           int publicados_en_BD  =   bd.Publicar_BD(Bimagen_th);
                if (publicados_en_BD > 0)
                {
                    Img_error.Visible = false;
                    Img_Succes.Visible = true;
                    LB_succes.Text = "Se a publicado la imagen";
                    ConsultaPublicacion();

                }
                else
                {
                    Img_Succes.Visible = false;
                    Img_error.Visible = true;
                    LB_error.Text = "No se pudo publicar ";
                    ConsultaPublicacion();
                }


            }
            catch (Exception)
            {
                Img_Succes.Visible = false;
                Img_error.Visible = true;
                LB_error.Text = "Ocurrio un error al publicar";
            }
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
                Repite_publicacion.DataSource = Imagenes_p;
                Repite_publicacion.DataBind();

                carga_mipedido();
            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();

        }

        protected void del_publicacion_Click(object sender, EventArgs e)
        { 
            try
            {
                BD bd = new BD();
                int idet = Convert.ToInt32(identificador_del.Text);
                int se_elimino =bd.delete_publicacion(idet);
                if (se_elimino>0)
                {
                    Img_error.Visible = false;
                    Img_Succes.Visible = true;
                    LB_succes.Text = "Se a eliminado Correctamente";
                    ConsultaPublicacion();
                }
                else
                {
                    Img_Succes.Visible = false;
                    Img_error.Visible = true;
                    LB_error.Text = "No se puedo eliminar ,verifica el identificador ";
                    ConsultaPublicacion();
                }

            }
            catch (Exception)
            {

                Img_Succes.Visible = false;
                Img_error.Visible = true;
                LB_error.Text = "Ocurrio un error al eliminar intenta mas tarde ";

            }
        }


        public void carga_mipedido()
        {
            try
            {
                int IdU = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from pedidos", conectarBD);
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

        public void carga_usuarios()
        {
            try
            {
                int IdU = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from usuarios", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);


                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                Repeater_usuarios.DataSource = Imagenes_p;
                Repeater_usuarios.DataBind();
            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void carga_administradores()
        {
            try
            {
                int IdU = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from administrador", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);


                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repite_administrador.DataSource = Imagenes_p;
                repite_administrador.DataBind();
            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
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
                    MySqlCommand cancela_pedido = new MySqlCommand("update pedidos set estado='Entregado' where Nopedido=@clave_pedido1", conectarBD);
                    cancela_pedido.Parameters.AddWithValue("@clave_pedido1", clave_pedido1);

                    try
                    {
                        actualizados = cancela_pedido.ExecuteNonQuery();
                        if (actualizados > 0)
                        {
                            carga_mipedido();
                            carga_mipedido();

                            Response.Write(@"<script language='javascript'> alert('se entrego el pedido'); </script>");
                        }
                        else
                        {
                            Response.Write(@"<script language='javascript'> alert('no se puedo entregar el pedido'); </script>");
                        }
                    }
                    catch (Exception)
                    {

                        Response.Write(@"<script language='javascript'> alert('hubo un error al entregar el pedido por favor intenta mas tarde'); </script>");
                    }

                }

            }
            conectarBD.Close();
        }

        public void Buscar_pdo_Click(object sender, EventArgs e)
        {
            try
            {
                int clavepedido = Convert.ToInt32(txt_buscar_pedido.Text);
                int IdU = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from pedidos where Nopedido="+clavepedido+" ", conectarBD);
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


        public void Buscar_usd_Click(object sender, EventArgs e)
        {
            try
            {
                int IdU = Convert.ToInt32(Session["id"].ToString());
                int busca = Convert.ToInt32(busca_usuario.Text);
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from usuarios where Idusuario="+busca+"", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);


                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                Repeater_usuarios.DataSource = Imagenes_p;
                Repeater_usuarios.DataBind();
            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();

        }

        public void btn_administrador_Click(object sender, EventArgs e)
        {
            try
            {
                int IdU = Convert.ToInt32(Session["id"].ToString());
                int busca = Convert.ToInt32(txt_administrador.Text);
                conectarBD.Open();
                MySqlCommand prodc = new MySqlCommand("select * from administrador where idAdmin=" + busca + "", conectarBD);
                MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);


                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                DataTable Imagenes_p = new DataTable();
                Imagenes_p.Load(prodc.ExecuteReader());
                repite_administrador.DataSource = Imagenes_p;
                repite_administrador.DataBind();
            }
            catch (Exception)
            {

                Response.Write(@"<script language='javascript'> console.log('error'); </script>");
            }
            conectarBD.Close();
        }

        public void Registra_admin_Click(object sender, EventArgs e)
        {
            if (Nombre_admin.Text.Length>0)
            {
                if (correo_admin.Text.Length>0)
                {
                    if (pwd_admin.Text.Length>0)
                    {
                        BD bd = new BD();
                        string nombre = Nombre_admin.Text;
                        string correo = correo_admin.Text;
                        string pwd = pwd_admin.Text;
                        int se_registro = bd.registra_admin(nombre, correo, pwd);

                        if (se_registro>0)
                        {
                            carga_administradores();
                            carga_administradores();
                            mensaje_admin(1, "se registro");
                        }
                        else
                        {
                            mensaje_admin(2, "no se puedo registrar");
                        }
                    }
                    else
                    {
                        mensaje_admin(2, "ingresa una contraseña");
                    }
                }
                else
                {
                    mensaje_admin(2, "ingresa un correo");
                }
            }
            else
            {
                mensaje_admin(2, "ingresa un nombre");
            }

        }

        public void mensaje_admin(int n, string mensaje)
        {
            switch (n)
            {
                case 1:
                    p_err.Visible = false;
                    p_succes.Visible = true;
                    Mensaje_succes.Text = mensaje;
                    break;

                case 2:
                    p_succes.Visible = false;
                    p_err.Visible = true;
                    Mensaje_err.Text = mensaje;
                    break;

                case 3:
                    p_AC_err.Visible = false;
                    p_AC_succes.Visible = true;
                    mg_succes.Text = mensaje;
                    break;

                case 4:
                    p_AC_succes.Visible = false;
                    p_AC_err.Visible = true;
                    mg_err.Text = mensaje;
                    break;
            }
        }


        public void Cerrar_sesion_Click(object sender, EventArgs e)
        {
            Session.Remove("id");
            Response.Redirect("Principal.aspx");
        }


        protected void cargarDatos_admin()
        {
            try
            {
                int clave = Convert.ToInt32(Session["id"].ToString());
                conectarBD.Open();
                MySqlCommand sesion_usuario =
                new MySqlCommand("select * from administrador where idAdmin=@Clave", conectarBD);
                sesion_usuario.Parameters.AddWithValue("@clave", clave);
                MySqlDataReader datosleidos = sesion_usuario.ExecuteReader();

                if (datosleidos.Read())
                {
                    name_usr.Text = datosleidos["nombre"].ToString();
                    correo_txt.Text = datosleidos["correo"].ToString();
                }

            }
            catch (Exception)
            {

                Response.Redirect("iniciar sesion.aspx");
            }

            conectarBD.Close();
        }

        public void Actualiza_admin_Click( object sender, EventArgs e)
        {
            BD bd = new BD();
            int id_ad = Convert.ToInt32(Session["id"].ToString());
            string correo = txt_correo.Text;
            string pass = txt_pwd.Text;
            if (txt_correo.Text.Length>0 && txt_pwd.Text.Length<=0)
            {
               
            int actualiza=bd.Actualiza_adminCorreo(1, id_ad, correo, pass);
                if (actualiza>0)
                {
                    cargarDatos_admin();
                    cargarDatos_admin();
                    mensaje_admin(3, "se actualizo el correo");
                }
                else
                {
                    mensaje_admin(4, "no se actualizo el correo");
                }
            }
          
            if (txt_correo.Text.Length <= 0 && txt_pwd.Text.Length > 0)
            {
                int actualiza = bd.Actualiza_adminCorreo(2, id_ad, correo, pass);
                if (actualiza > 0)
                {
                    cargarDatos_admin();
                    cargarDatos_admin();
                    mensaje_admin(3, "se actualizo la contraseña");
                }
                else
                {
                    mensaje_admin(4, "no se actualizo la contraseña");
                }
            }

            if (txt_correo.Text.Length > 0 && txt_pwd.Text.Length > 0)
            {
                int actualiza = bd.Actualiza_adminCorreo(3, id_ad, correo, pass);
                if (actualiza > 0)
                {
                    cargarDatos_admin();
                    cargarDatos_admin();
                    mensaje_admin(3, "se actualizo los datos");
                }
                else
                {
                    mensaje_admin(4, "no se actualizo los datos");
                }
            }

            if (txt_correo.Text.Length <= 0 && txt_pwd.Text.Length <= 0)
            {
                mensaje_admin(4, "ingresa un correo y/o contraseña");
            }
        }

        
    }

   
}