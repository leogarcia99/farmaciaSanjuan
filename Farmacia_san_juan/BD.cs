using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace Farmacia_san_juan
{
    public class BD
    {
        public static string cadBD = "Server=localhost;Database=farmacia;Uid=root;Pwd=Leonardo99";
        static MySqlConnection conectarBD = new MySqlConnection(cadBD);

        public int resgistraP(String name, byte[] img, String category, String sub_category, String description, int presio)
        {
            
            int cliente = 0;
            conectarBD.Open();
            MySqlCommand datosC = new MySqlCommand("insert into products values(0, @name,  @img, @category, @sub_category, @description, @presio)", conectarBD);
            datosC.Parameters.AddWithValue("@name", name);
            datosC.Parameters.AddWithValue("@img", img);
            datosC.Parameters.AddWithValue("@category", category);
            datosC.Parameters.AddWithValue("@sub_category", sub_category);
            datosC.Parameters.AddWithValue("@description", description);
            datosC.Parameters.AddWithValue("@presio", presio);

            try
            {
                cliente = datosC.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            conectarBD.Close();
            return cliente;

        }

        public void consultaProductos(GridView datoscliente)
        {
            conectarBD.Open();
            MySqlCommand prodc = new MySqlCommand("select * from products", conectarBD);
            MySqlDataAdapter datosc = new MySqlDataAdapter(prodc);
            DataSet dccliente = new DataSet();
            datosc.Fill(dccliente);
            datoscliente.DataSource = dccliente.Tables[0];
            datoscliente.DataBind();
            conectarBD.Close();
        }


        public int eliminar_producto(int claveP)
        {
            int datoselimindos=0;
            conectarBD.Open();
            MySqlCommand eliminar = new MySqlCommand("delete from products where claveP=@claveP", conectarBD);
            eliminar.Parameters.AddWithValue("@claveP", claveP);
            try
            {
                datoselimindos = eliminar.ExecuteNonQuery();

            }
            catch (Exception)
            {
    
            }
            conectarBD.Close();
            return datoselimindos;
        }


       public int Actualiza_productos(int claveP, string name, byte[] imagen, string categoria, string subcategoria, string descripcion, int presio)
        {
            conectarBD.Open();
            int datos_actualizados = 0;
            MySqlCommand Actualiza = new MySqlCommand("update products set name=@name, image=@imagen, categoria=@categoria, subcategoria=@subcategoria, descripcion=@descripcion, presio=@presio where claveP=@claveP", conectarBD);
            Actualiza.Parameters.AddWithValue("@name", name);
            Actualiza.Parameters.AddWithValue("@imagen", imagen);
            Actualiza.Parameters.AddWithValue("@categoria", categoria);
            Actualiza.Parameters.AddWithValue("@subcategoria", subcategoria);
            Actualiza.Parameters.AddWithValue("@descripcion", descripcion);
            Actualiza.Parameters.AddWithValue("@presio", presio);
            Actualiza.Parameters.AddWithValue("@claveP", claveP);
            try
            {
                datos_actualizados = Actualiza.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
            return datos_actualizados;
        }

        public int Actualiza_usuarios_pwd(int claveP, string mail, string password, string fnacimiento, string telefono, string direccion)
        {
            conectarBD.Open();
            int datos_actualizados = 0;
            MySqlCommand Actualiza = new MySqlCommand("update usuarios set  mail=@mail, password=@password, fechaNacimiento=@fnacimiento, phone=@telefono, direccion=@direccion where idUsuario=@claveP", conectarBD);
           
            Actualiza.Parameters.AddWithValue("@mail", mail);
            Actualiza.Parameters.AddWithValue("@password", password);
            
            Actualiza.Parameters.AddWithValue("@fnacimiento", fnacimiento);
            Actualiza.Parameters.AddWithValue("@telefono", telefono);
            Actualiza.Parameters.AddWithValue("@direccion", direccion);
            Actualiza.Parameters.AddWithValue("@claveP", claveP);
            try
            {
                datos_actualizados = Actualiza.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
            return datos_actualizados;
        }

        public int Actualiza_usuarios(int claveP, string mail, string fnacimiento, string telefono, string direccion)
        {
            conectarBD.Open();
            int datos_actualizados = 0;
            MySqlCommand Actualiza = new MySqlCommand("update usuarios set mail=@mail, fechaNacimiento=@fnacimiento, phone=@telefono, direccion=@direccion where idUsuario=@claveP", conectarBD);
          
            Actualiza.Parameters.AddWithValue("@mail", mail);
            Actualiza.Parameters.AddWithValue("@fnacimiento", fnacimiento);
            Actualiza.Parameters.AddWithValue("@telefono", telefono);
            Actualiza.Parameters.AddWithValue("@direccion", direccion);
            Actualiza.Parameters.AddWithValue("@claveP", claveP);
            try
            {
                datos_actualizados = Actualiza.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
            return datos_actualizados;
        }



        public int registrarUsuario(string nombre, string correo, string pwd, string genero, string fechaN)
        {

            int usuario_r = 0;
            conectarBD.Open();
            string telefono = "";
            string direccion = "";
           
            MySqlCommand registraU = new MySqlCommand("insert into usuarios values(0, @nombre, @correo, @pwd, @genero, @fechaN, @telefono, @direccion)", conectarBD);
            registraU.Parameters.AddWithValue("@nombre",nombre);
            registraU.Parameters.AddWithValue("@correo", correo);
            registraU.Parameters.AddWithValue("@pwd", pwd);
            registraU.Parameters.AddWithValue("@genero", genero);
            registraU.Parameters.AddWithValue("@fechaN", fechaN);
            registraU.Parameters.AddWithValue("@telefono", telefono);
            registraU.Parameters.AddWithValue("@direccion", direccion);

            try
            {
                usuario_r = registraU.ExecuteNonQuery();
            }
            catch (Exception)
            {

               
            }
            conectarBD.Close();
            return usuario_r;
        }
        
        public string inicia_sesion(string correo, string contra)
        {
            string usuario = "";
            try
            {
                conectarBD.Open();
                MySqlCommand inicia = 
                new MySqlCommand("select idUsuario from usuarios where mail=@correo and password=@contra", conectarBD);
                inicia.Parameters.AddWithValue("@correo", correo);
                inicia.Parameters.AddWithValue("@contra", contra);
                MySqlDataReader usuario_contrado = inicia.ExecuteReader();

                if (usuario_contrado.Read())
                {
                    usuario= usuario_contrado["idUsuario"].ToString();
                }
            }
            catch (Exception)
            {

            }
            conectarBD.Close();
            return usuario;
        }

        public string comprueba_password(string contra)
        {
            string usuario = "";
            try
            {
                conectarBD.Open();
                MySqlCommand inicia =
                new MySqlCommand("select password from usuarios where password=@contra", conectarBD);
                
                inicia.Parameters.AddWithValue("@contra", contra);
                MySqlDataReader usuario_contrado = inicia.ExecuteReader();

                if (usuario_contrado.Read())
                {
                    usuario = usuario_contrado["password"].ToString();
                }
            }
            catch (Exception)
            {

            }
            conectarBD.Close();
            return usuario;
        }

        public int Publicar_BD(byte[] img)
        {
            int se_publico = 0;
            conectarBD.Open();
            MySqlCommand publica = new MySqlCommand("insert into destacado values(0, @img)", conectarBD);
            publica.Parameters.AddWithValue("@img", img);
            try
            {
               se_publico = publica.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
           return se_publico;
        }

        public int delete_publicacion(int Ident)
        {
            int se_elimino = 0;
            conectarBD.Open();
            MySqlCommand eliminado = new MySqlCommand("delete from destacado where identificador=@Ident",conectarBD);
            eliminado.Parameters.AddWithValue("@Ident", Ident);
            try
            {
                se_elimino = eliminado.ExecuteNonQuery();
            }
            catch (Exception)
            {

               
            }
            conectarBD.Close();
            return se_elimino;

        }

        public int mi_listaP(int claveU, int claveP, string nombre, int precio)
        {
            int se_agrego = 0;
            conectarBD.Open();
            MySqlCommand mete_lista = new MySqlCommand("insert into mi_listap values(0, @claveU, @claveP, @nombre, @precio)", conectarBD);
            mete_lista.Parameters.AddWithValue("@claveU", claveU);
            mete_lista.Parameters.AddWithValue("@claveP", claveP);
            mete_lista.Parameters.AddWithValue("@nombre", nombre);
            mete_lista.Parameters.AddWithValue("@precio", precio);
            try
            {
                se_agrego = mete_lista.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
            return se_agrego;
        }

        public int registra_pedido(int Idusuario, string productos, int precioT, string fecha)
        {
            string estado = "Pendiente";
            int se_hizo = 0;
            conectarBD.Open();
            MySqlCommand pedido = new MySqlCommand("insert into pedidos values(0, @Idusuario, @productos, @precioT, @fecha, @estado)", conectarBD);
            pedido.Parameters.AddWithValue("@Idusuario", Idusuario);
            pedido.Parameters.AddWithValue("@productos", productos);
            pedido.Parameters.AddWithValue("@precioT", precioT);
            pedido.Parameters.AddWithValue("@fecha", fecha);
            pedido.Parameters.AddWithValue("@estado", estado);
            try
            {
                se_hizo = pedido.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
            return se_hizo;

        }

        public string inicia_sesion_admin(string correo, string contra)
        {
            string usuario = "";
            try
            {
                conectarBD.Open();
                MySqlCommand inicia =
                new MySqlCommand("select idAdmin from administrador where correo=@correo and password=@contra", conectarBD);
                inicia.Parameters.AddWithValue("@correo", correo);
                inicia.Parameters.AddWithValue("@contra", contra);
                MySqlDataReader usuario_contrado = inicia.ExecuteReader();

                if (usuario_contrado.Read())
                {
                    usuario = usuario_contrado["idAdmin"].ToString();
                }
            }
            catch (Exception)
            {

            }
            conectarBD.Close();
            return usuario;
        }

        public int registra_admin(string nombre, string correo, string pwd)
        {
            conectarBD.Open();
            int se_registro = 0;
            MySqlCommand registra = new MySqlCommand("insert into administrador values(0, @nombre, @correo, @pwd)", conectarBD);
            registra.Parameters.AddWithValue("@nombre", nombre);
            registra.Parameters.AddWithValue("@correo", correo);
            registra.Parameters.AddWithValue("@pwd", pwd);

            try
            {
                se_registro = registra.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conectarBD.Close();
            return se_registro;


        }


        public int Actualiza_adminCorreo(int caso, int claveP, string mail, string pwd)
        {
            conectarBD.Open();
            int datos_actualizados = 0;
            switch (caso)
            {
                case 1:
                    MySqlCommand Actualiza = new MySqlCommand("update administrador set correo=@mail where idAdmin=@claveP", conectarBD);
                    Actualiza.Parameters.AddWithValue("@mail", mail);
                    Actualiza.Parameters.AddWithValue("@claveP", claveP);
                    try
                    {
                        datos_actualizados = Actualiza.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;

                case 2:
                    MySqlCommand Actualiza2 = new MySqlCommand("update administrador set password=@mail where idAdmin=@claveP", conectarBD);
                    Actualiza2.Parameters.AddWithValue("@mail", mail);
                    Actualiza2.Parameters.AddWithValue("@claveP", claveP);
                    try
                    {
                        datos_actualizados = Actualiza2.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;


                case 3:
                    MySqlCommand Actualiza3 = new MySqlCommand("update administrador set correo=@mail, password=@pwd  where idAdmin=@claveP", conectarBD);
                    Actualiza3.Parameters.AddWithValue("@mail", mail);
                    Actualiza3.Parameters.AddWithValue("@pwd", pwd);
                    Actualiza3.Parameters.AddWithValue("@claveP", claveP);
                    try
                    {
                        datos_actualizados = Actualiza3.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
            }
            conectarBD.Close();
            return datos_actualizados;
        }

    }
}