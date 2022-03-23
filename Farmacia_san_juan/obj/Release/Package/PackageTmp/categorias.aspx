<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorias.aspx.cs" Inherits="Farmacia_san_juan.categorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Categorias</title>
    <script src="https://kit.fontawesome.com/712575d4a5.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="css_farmacia\estilo_categoria.css">
   
  </head>
  <body>
  <!--esto es el encabezados -->
<header class="cabeza">
  <ul class="menu">
    <li><a href="Principal.aspx">Inicio</a></li>
    <li><a href="iniciar sesion.aspx">iniciar sesion</a></li>
    <li><a href="crear_cuenta.aspx">Crear cuenta</a></li>
    <li><a href="#">contacto</a></li>
    <li><a href="#">Ayuda</a></li>
    
<div id="search">
<input type="text" placeholder="Buscar" required>
<div id="btn">
  <i class="fas fa-search"></i>
</div>
    </div>
  </ul>

 <div id="categorias">
   <ul id="navi">
<li id="M1"><a id="l1" href="">Categorias</a>
  <section id="subcategoria">
    <div id="subC">
      <ul id="productos">

        <li class="far" id="M2"><a id="l2" href="">Farmacia</a>
          <div id="farmacia"> 
                  
             <div id="sub_farmacia">
              <ul>
                <li><a href="">antitaco</a></li>
                <li><a href="">Cuidado de los ojos </a></li>
                <li><a href="">Cuidado de los pies </a></li>
                <li><a href="">Dolor y fiebre</a></li>
                <li><a href="">Estomacal</a></li>
                <li><a href="">Ginecologia </a></li>
                <li><a href="">Pruebas de embarazo </a></li>
                <li><a href="">Sueros</a></li>
                <li><a href="">Gripa y tos</a></li>
                <li><a href="">Curacion</a></li>
                <li><a href="">Vitaminas y minerales </a></li>
                <li><a href="">Suplementos</a></li>
              </ul>
              <img id="logo"src="imagenes_farmacia\Farmacia.jpg" alt="">
             </div>         
                  
          </div>
        </li>

        <li class="dia" id="M2"><a id="l2" href="">Diabetes</a>
          <div id="diabetes"> 
              <div id="sub_diabetes">
                <ul>
                  <li><a href="">Articulo de medicion</a></li>
                  <li><a href="">Dermatologia </a></li>
                  <li><a href="">Gripa y tos </a></li>
                  <li><a href="">Suplementos alimenticios </a></li>
                  <li><a href="">Meterial de curacion </a></li>
                  <li><a href="">Especializados </a></li>
                  <li><a href="">vitaminas y minerales </a></li>
                </ul>
                <img id="logo" src="imagenes_farmacia\Diabetes.jpg" alt="">
              </div>
          </div>
          
        </li>

        <li class="be" id="M2"><a id="l2" href="">Bebe</a>
          <div id="bebe"> 
                  <div id="sub_bebe">
                    <ul>
                      <li><a href="">Formulas</a></li>
                      <li><a href="">Leches</a></li>
                      <li><a href="">Alimentacion bebe</a></li>
                      <li><a href="">Pañales y toalla</a></li>
                      <li><a href="">Cuidado del bebe</a></li>
                      <li><a href="">Embarazo y latancia</a></li>
                      <li><a href="">Medicamentos infantiles</a></li>
                     
                    </ul>
                    <img id="logo" src="imagenes_farmacia\Bebes.png" alt="">
                    </div>

          </div>
        </li>

        <li class="bell" id="M2"><a id="l2" href="">Belleza y derma</a>
          <div id="belleza"> 
            <div id="sub_belleza">
              <ul>
                <li><a href="">Accesorios</a></li>
                <li><a href="">Derma</a></li>
                <li><a href="">Fragancia</a></li>
                <li><a href="">Maquillaje</a></li>
                <li><a href="">Mascarillas</a></li>
                <li><a href="">Outlet de belleza</a></li>
                <li><a href="">Rutinas</a></li>
               
              </ul>
              <img id="logo" src="imagenes_farmacia\belleza.jpg" alt="">
            </div>
           
          </div>
        </li>

        <li class="hom" id="M2"><a id="l2" href="">Cuidado hombre</a>
          <div id="hombre"> 
            <div id="sub_hombre">
              <ul>
                <li><a href="">Afeitado</a></li>
                <li><a href="">Capilar </a></li>
                <li><a href="">Corporal</a></li>
                <li><a href="">Cuido facial</a></li>
                <li><a href="">Fragancias </a></li>
              </ul>
              <img id="logo" src="imagenes_farmacia\hombres.jpg" alt="">
            </div>
            
          </div>

        </li>
        <li class="hig" id="M2"><a id="l2" href="">Higiene personal</a>
          <div id="higiene"> 
            <div id="sub_higiene">
              <ul>
                <li><a href="">Articulos para el hogar</a></li>
                <li><a href="">Cuidado bucal</a></li>
                <li><a href="">Incontigencia</a></li>
                <li><a href="">Afeitado</a></li>
                <li><a href="">Desodorantes</a></li>
                <li><a href="">Articulos de viaje</a></li>
                <li><a href="">cuidado del cabello</a></li>
                <li><a href="">Cuidado de la piel </a></li>
                <li><a href="">Proteccion femenina</a></li>
                <li><a href="">Jabones</a></li>
               
              </ul>
              <img id="logo" src="imagenes_farmacia\Higiene.png" alt="">
            </div>
            
          </div>
        </li>
        <li class="bien" id="M2"><a id="l2" href="">Bienestar sexual</a>
          <div id="bienestar"> 
            <div id="sub_bienestar">
              <ul>
                <li><a href="">Suplementos</a></li>
                <li><a href="">Perservativos</a></li>
                <li><a href="">Lubricantes</a></li>
                <li><a href="">Accesorio sexual</a></li>
              
               
              </ul>
              <img id="logo" src="imagenes_farmacia\bienestar.jpg" alt="">
            </div>
            
          </div>
        
        
        </li>
      </ul>
      

    </div>
    

  </section>
</li>
<li id="M1"><a id="l1" href="">Me quiero bien</a></li>
<li id="M1"><a id="l1" href="">Mi bebe crece</a></li>
<li id="M1"><a id="l1" href="">Diabetes</a></li>
<li id="M1"><a id="l1" href="">Rutinas</a></li>
<li id="M1"><a id="l1" href="">Consejos</a></li>
<li id="M1"><a id="l1" href="">Mascarillas</a></li>

   </ul>
 </div>


</header>

<section class="seccion">
 
<div id="sub_cate">

<div class="logos" >
  <img src="imagenes_farmacia\Farmacia.jpg" alt="">
  <a href="">Farmacia</a>
  
</div>

<div class="logos" >
  <img src="imagenes_farmacia\Diabetes.jpg" alt="">
  <a href="">Diabetes</a>
  
</div>

<div class="logos" >
  <img src="imagenes_farmacia\Belleza_.jpg" alt="">
  <a href="">Belleza</a>
  
</div>
<div class="logos" >
  <img src="imagenes_farmacia\derma.jpg" alt="">
  <a href="">Belleza</a>
  
</div>

<div class="logos">
  <img src="imagenes_farmacia\Bebes.png" alt="">
  <a href="">Bebes</a>
  
</div>

<div class="logos">
  <img src="imagenes_farmacia\Hombres.jpg" alt="">
  <a href="">Hombre</a>
  
</div>

<div class="logos">
  <img src="imagenes_farmacia\Higiene.png" alt="">
  <a href="">Higiene</a>
    </div>

    <div class="logos">
      <img src="imagenes_farmacia\bienestar.jpg" alt="">
      <a href="">Sexual</a>
  </div>

  <div class="logos">
    <img src="imagenes_farmacia\otros.jpg" alt="">
    <a href="">Otros</a>
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
  </body>

</html>
