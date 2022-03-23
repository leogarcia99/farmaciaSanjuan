<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crear_cuenta.aspx.cs" Inherits="Farmacia_san_juan.crear_cuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Crear cuenta</title>
    <script src="https://kit.fontawesome.com/712575d4a5.js" ></script>
    <link rel="stylesheet" type="text/css" href="css_farmacia\estilo_crear.css">
    <link rel="stylesheet" type="text/css" href="css_farmacia\estilocreacuenta.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet"  >
   
  </head>
  <body>
  <!--esto es el encabezados -->

      <form runat="server">
<header class="cabeza">
  <ul class="menu">
    <li><a href="Principal.aspx">Inicio</a></li>
    <li><a href="#">contacto</a></li>
    <li><a href="#">Ayuda</a></li>
    
<div id="search">
<input type="text" placeholder="Buscar" >
<div id="btn">
  <i class="fas fa-search"></i>
</div>
    </div>
  </ul>
</header>
<section class="seccion">
  <div class="mb-3 box" >
    <h1>Crear cuenta</h1>
    <label class="form-label">Nombre Completo</label>
  <asp:TextBox runat="server" ID="Nombre"  CssClass="form-control" required></asp:TextBox>
       <label class="form-label">Correo</label>
      <asp:TextBox runat="server" ID="Correo" CssClass="form-control" TextMode="Email" required></asp:TextBox> 
       <label class="form-label">Contraseña</label>
      <asp:TextBox runat="server" ID="pwd" CssClass="form-control" TextMode="Password" OnTextChanged="pwd_TextChanged" ></asp:TextBox> 
       <label class="form-label">Confirma contraseña</label>
      <asp:TextBox runat="server" ID="pwd2" CssClass="form-control" TextMode="Password" ></asp:TextBox> 
      <label class="form-label">Genero</label>
      <asp:RadioButtonList ID="Genero" runat="server" CssClass="form-check"  required>
         <asp:ListItem > Hombre </asp:ListItem>
            <asp:ListItem >Mujer</asp:ListItem>
      </asp:RadioButtonList>
      
     <label class="form-label">Fecha de Nacimiento</label>
      <asp:TextBox runat="server" ID="Nacimiento" CssClass="form-control" TextMode="Date" required></asp:TextBox> 
      <br />
        <asp:Panel ID="Error" runat="server" CssClass="alert alert-danger alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="MesaggeEr" CssClass="mensaje">Mensaje</asp:Label>
                 <asp:Button  runat="server" CssClass="btn-close" OnClick="Unnamed2_Click" data-bs-dismiss="alert" aria-label="Close" />
            </asp:Panel>
      
        <asp:Button runat="server" Text="Crear Cuenta" CssClass="btn btn-outline-primary" OnClick="Unnamed1_Click" /> 
      <br />
      <br />
    <h6><a href="iniciar sesion.aspx">¿Ya tienes cuenta?, ingresa aqui.</a></h6>
  </div>
</section>


<footer class="abajo">
  <div id="ayuda">
<ul>
  Ayuda y servicios
  <li><a href="">sobre nosotros</a></li>
  <li><a href="">promocionales</a></li>
</ul>
  </div>

  <div id="servicios">
<ul>
  Servicios
  <li><a href="">Sucursales</a></li>
  <li><a href="">Servicio a domicilio</a></li>
  <li><a href="">Nuestro servicio</a></li>
  <li><a href="">Orientacion medica</a></li>
 
</ul>
  </div> 

  <div id="compra">
      <ul>
        Compra en linea
        <li><a href="">Facturacion</a></li>
        <li><a href="">Horarios y entrega</a></li>
        <li><a href="">Formas de pago</a></li>
      </ul>
  </div>

  <div id="cliente">
<ul>
  Servicio al cliente
  <li><a href="">Preguntas frecuentes</a></li>
  <li><a href="">Aviso de privacidad</a></li>
  <li><a href="">Recepcion de facturas</a></li>
  <li><a href="">Medios de contacto</a></li>
  <li><a href="">Empleados y provedor</a></li>
</ul>

  </div>
  <div id="hr">
    <hr>
  </div>

  <div id="parrafo">
    <p>
      TODOS LOS DERECHOS RESERVADOS POR COMERCIALIZADORA FARMACÉUTICA DE CHIAPAS S.A.P.I. DE C.V., MÉXICO D.F. 2020
COFEPRIS: 143300201 B1447 | NO. DE LICENCIA SANITARIA: 09 011 09 0096

Aviso de Privacidad | Términos y Condiciones
    </p>
  </div>

</footer>
          </form>
  </body>

</html>
