<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iniciar sesion.aspx.cs" Inherits="Farmacia_san_juan.iniciar_sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Inicia sesion</title>
    <script src="https://kit.fontawesome.com/712575d4a5.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="css_farmacia/estilo_sesion.css">

<link rel="stylesheet" type="text/css" href="css_farmacia/esilo_login.css">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet"  >
   <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.min.js" integrity="sha384-Atwg2Pkwv9vp0ygtn1JAojH0nYbwNJLPhwyoVbhoPwBhjQPR5VtM2+xf0Uwh9KtT" crossorigin="anonymous"></script>
  </head>
  <body>
      <form runat="server" id="todo">
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

  <div class="Login">
    <h1>Inicia sesion</h1>
      <label>Correo</label>
    <asp:TextBox runat="server" ID="Mail" CssClass="form-control" TextMode="Email" required></asp:TextBox>
      <br />
      <label>Contraseña</label>
       <asp:TextBox runat="server" ID="Password" CssClass="form-control" TextMode="Password" ></asp:TextBox>
      <br />
      <asp:Panel ID="Error" runat="server" CssClass="alert alert-danger alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="MesaggeEr" CssClass="mensaje">Mensaje</asp:Label>
                 <asp:Button  runat="server" CssClass="btn-close" OnClick="Unnamed2_Click" data-bs-dismiss="alert" aria-label="Close" />
            </asp:Panel>
    <asp:Button runat="server" Text="Iniciar sesion" CssClass="btn btn-outline-primary" OnClick="Unnamed1_Click"/>
      <br />
      <br />
    <h6><a href="">¿Olvidaste tu contraseña?</a></h6>
    <h6><a href="crear_cuenta.aspx">¿No tienes cuenta?¡registrate aqui!</a></h6>
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

