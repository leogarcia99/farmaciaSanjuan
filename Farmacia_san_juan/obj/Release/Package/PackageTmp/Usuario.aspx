<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Farmacia_san_juan.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>farmacias san juan </title>
    <script src="https://kit.fontawesome.com/30bb6915e6.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="css_farmacia/estilo_principal.css">
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.min.js" integrity="sha384-Atwg2Pkwv9vp0ygtn1JAojH0nYbwNJLPhwyoVbhoPwBhjQPR5VtM2+xf0Uwh9KtT" crossorigin="anonymous"></script>
  </head>
  <body>
  <!--esto es el encabezados -->
<form runat="server" id="principal">

<header class="cabeza">

  <nav class="navbar navbar-expand-lg navbar-dark bg-primary ">
  <div class="container-fluid">
    <a class="navbar-brand" href="Usuario.aspx">Farmacias San Juan</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="Usuario.aspx">Inicio</a>
        </li>

        <li class="nav-item">
          <a class="nav-link" href="#">Acerca de</a>
        </li>
           <li class="nav-item">
          <a class="nav-link" href="#">Contactanos</a>
        </li>
           <li class="nav-item">
          <a class="nav-link" href="#" >Ayuda</a>
        </li>




      <div class="d-flex" >
          <asp:TextBox runat="server" ID="txt_buscar" CssClass="form-control me-2" TextMode="Search" pleaceholder="Buscar Producto" style="width:650px" aria-label="Search" > </asp:TextBox>
        <asp:Button runat="server" Text="Buscar" CssClass="btn btn-outline-dark" type="submit" OnClick="Unnamed1_Click"/>
      </div>
    </div>
  </div>
</nav>
 <nav id="categorias" class="navbar navbar-expand-lg navbar-dark bg-primary" style="">
   <ul id="navi">
       <li id="M1">
           <asp:LinkButton runat="server" CssClass="btn btn-primary"  data-bs-toggle="offcanvas" href="#offcanvasExample" role="button" aria-controls="offcanvasExample" OnClick="Load_Click" OnClientClick="Load_click"> <i class="fas fa-user"></i> / <i class="fas fa-shopping-cart"></i></asp:LinkButton>
           <div class="offcanvas offcanvas-start" tabindex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
    <div class="offcanvas-header">
      <h5 class="offcanvas-title" id="offcanvasExampleLabel"><asp:Label runat="server" ID="name_usr"> Nombre de cliente  <br /></asp:Label> <br /> <asp:Label runat="server" ID="Id_usr" style="float:left; margin-top:0%;">ID</asp:Label> </h5>
      <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
    </div>
    <div class="offcanvas-body">
      <div style="text-align:left;">
          <asp:Button runat="server" ID="Cargar_perfil" CssClass="btn btn-outline-primary" Text="Editar perfil" OnClick="Cargar_perfil_Click" OnClientClick="Cargar_perfil_Click"/> 
          <asp:Button runat="server" ID="Cerrar_sesion" CssClass="btn btn-outline-danger" Text="Cerrar Sesion" OnClick="Cerrar_sesion_Click" OnClientClick="Cerrar_sesion_Click"/>
          <br />

          <asp:Panel ID="panel_perfil" runat="server" Visible="False">
              <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_correo">Correo</asp:Label>
          <asp:TextBox runat="server"  CssClass="form-control" ID="txt_correo" ></asp:TextBox>
         
          <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_genero1">Genero: </asp:Label>
          <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_genero"></asp:Label> <br />

          <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_fecha">Fecha de nacimiento</asp:Label>
          <asp:TextBox runat="server" ID="txt_fechaN" CssClass="form-control" TextMode="Date"></asp:TextBox>

          <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_telefono">Telefono</asp:Label>
          <asp:TextBox runat="server" ID="txt_telefono" CssClass="form-control"></asp:TextBox>

          <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_direccion">Direccion</asp:Label>
          <asp:TextBox runat="server" ID="txt_direccion" CssClass="form-control" OnTextChanged="txt_direccion_TextChanged" type="text"></asp:TextBox> 

           <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_password">Ingresa Contraseña para guardar Cambios</asp:Label>
          <asp:TextBox runat="server" ID="txt_pwd" CssClass="form-control" TextMode="Password" OnTextChanged="txt_pwd_TextChanged"></asp:TextBox>

           <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_password2">Contraseña nueva (opcional)</asp:Label>
          <asp:TextBox runat="server" ID="new_pwd" CssClass="form-control" TextMode="Password" OnTextChanged="txt_pwd_TextChanged"></asp:TextBox> <br />
           
          <asp:Button runat="server" ID="Actualiza_usd" Text="Actualizar Perfil" CssClass="btn btn-outline-primary" OnClick="Actualiza_usd_Click" OnClientClick="Actualiza_usd_Click"/>
          </asp:Panel>
          
      </div>

        <div style="float: left;">
            <div><h5>Mi lista de productos</h5></div>
            <table class="table table-dark table-hover">
                <tr class="table-dark">
                    <th scope="col" class="table-dark">Nombre producto</th>
                    <th scope="col" class="table-dark"> precio</th>
                </tr>

                <asp:Repeater runat="server" ID="repite_lista"  OnItemCommand="repite_lista_ItemCommand" ViewStateMode="Enabled">
                <ItemTemplate>
                    <tr class="table-primary">
                        <td class="table-primary"> <%# Eval("nombreP") %></td>
                        <td class="table-primary"> <%# Eval("precio") %></td>
                         <asp:HiddenField runat="server" ID="claveList" Value='<%# Eval("NoL") %>'/>
                        <td class="table-primary"><asp:LinkButton runat="server" CssClass="btn btn-outline-primary" ID="eliminaProducto" Enabled="True" CommandName="eliminaP">Eliminar</asp:LinkButton> </td>
                    </tr>

                 </ItemTemplate>
             </asp:Repeater> 
            </table>
            
        </div>
       <br />

        <div style="float:left;">
            <h6>Total a pagar</h6> 
            <asp:Label ID="MI_Lista_junta" runat="server"> </asp:Label> 
             <asp:Label ID="pp" runat="server" Visible="false">A</asp:Label> 
        </div>
        <div style="float:right;">
            <asp:Button runat="server" ID="Realiza_pedido" Text="Realizar Pedido" CssClass="btn btn-primary" OnClick="Realiza_pedido_Click" OnClientClick="Realiza_pedido_Click"/>
          
        </div>
        <br />
        <br />
        <div>
            <div style="float:left;">
                <h6>Mis pedidos</h6>
                <table class="table table-dark table-hover">
                <tr class="table-dark">
                    <th scope="col" class="table-dark">#</th>
                    <th scope="col" class="table-dark">productos</th>
                     <th scope="col" class="table-dark"> Precio total</th>
                     <th scope="col" class="table-dark">fecha</th>
                     <th scope="col" class="table-dark">estado</th>
                </tr>

                    <asp:Repeater runat="server" ID="repite_misPedidos" ViewStateMode="Enabled" OnItemCommand="repite_misPedidos_ItemCommand">
                        <ItemTemplate>
                         <tr class="table-primary">

                        <td class="table-primary"> <%# Eval("Nopedido") %></td>
                        <td class="table-primary"> <%# Eval("productos") %></td>
                        <td class="table-primary"> <%# Eval("precioT") %></td>
                        <td class="table-primary"> <%# Eval("fecha") %></td>
                        <td class="table-primary"> <%# Eval("estado") %></td>
                        <asp:HiddenField runat="server" ID="clave_pedidos" Value='<%# Eval("Nopedido") %>'/>
                        <asp:HiddenField runat="server" ID="estado" Value='<%# Eval("estado") %>'/>

                        <td class="table-primary">
                            <asp:LinkButton runat="server" CssClass="btn btn-outline-primary" ID="cancela_pedido" Enabled="True" CommandName="cancelaPD">Cancelar</asp:LinkButton> </td>

                        </tr>
                        </ItemTemplate>
                    </asp:Repeater>
              </table>
            </div>
        </div>

    </div>
  </div>
       </li>

<li id="M1"><a id="l1" href="#">Categorias</a>
  <section id="subcategoria">
    <div id="subC">
      <ul id="productos" >

        <li class="far" id="M2"><asp:LinkButton runat="server" ID="l2" CommandName="farmacia_ca" OnClick="Categoria_Farmacia_Click" OnClientClick="Categoria_Farmacia_Click" >Farmacia</asp:LinkButton>
          <div id="farmacia"> 
                  
             <div id="sub_farmacia">
              <ul>
                <li><asp:LinkButton runat="server" id="LinkButton7" CommandName="ojos_sb" OnClick="subcategoria_Ojos_Click" OnClientClick="subcategoria_Ojos_Click" >Cuidado de los ojos</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton8" CommandName="pies_sb" OnClick="subcategoria_pies_Click" OnClientClick="subcategoria_pies_Click" >Cuidado de los pies</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton9" CommandName="fiebre_sb" OnClick="subcategoria_fiebre_Click" OnClientClick="subcategoria_fiebre_Click" >Dolor y fibre</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton10" CommandName="estomacal_sb" OnClick="subcategoria_estomacal_Click" OnClientClick="subcategoria_estomacal_Click" >Estomacal</asp:LinkButton> </li>
                <li><asp:LinkButton runat="server" id="LinkButton11" CommandName="gineocologia_sb" OnClick="subcategoria_gineocologia_Click" OnClientClick="subcategoria_gineocologia_Click" >Gieneocologia</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton12" CommandName="embarazo_sb" OnClick="subcategoria_embarazo_Click" OnClientClick="subcategoria_embarazo_Click" >Pruebas de enbarazo</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton13" CommandName="sueros_sb" OnClick="subcategoria_sueros_Click" OnClientClick="subcategoria_sueros_Click" >Sueros</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton14" CommandName="gripa_sb" OnClick="subcategoria_gripa_Click" OnClientClick="subcategoria_gripa_Click" >Gripa y tos</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton15" CommandName="curacion_sb" OnClick="subcategoria_curacion_Click" OnClientClick="subcategoria_curacion_Click" >Curacion</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton16" CommandName="vitamina_sb" OnClick="subcategoria_vitamina_Click" OnClientClick="subcategoria_vitamina_Click" >Vitaminas y minarales</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton17" CommandName="suplementos_sb" OnClick="subcategoria_suplementos_Click" OnClientClick="subcategoria_suplementos_Click" >Suplementos</asp:LinkButton></li>
              </ul>
              <img id="logo"src="imagenes_farmacia\Farmacia.jpg" alt="">
             </div>         
                  
          </div>
        </li>

        <li class="dia" id="M2"><asp:LinkButton runat="server" id="l3" CommandName="Diabetes_ca" OnClick="Categoria_Diabetes_Click" OnClientClick="Categoria_Diabetes_Click" >Diabetes</asp:LinkButton>
          <div id="diabetes"> 
              <div id="sub_diabetes">
                <ul>
                  <li><asp:LinkButton runat="server" id="LinkButton18" CommandName="medicion_sb" OnClick="subcategoria_medicion_Click" OnClientClick="subcategoria_medicion_Click" >Articulos de medicion</asp:LinkButton></li>
                  <li><asp:LinkButton runat="server" id="LinkButton19" CommandName="dermatologia_sb" OnClick="subcategoria_dermatologia_Click" OnClientClick="subcategoria_dermatologia_Click" >Dermatologia</asp:LinkButton></li>
                  <li><asp:LinkButton runat="server" id="LinkButton20" CommandName="tos_sb" OnClick="subcategoria_tos_Click" OnClientClick="subcategoria_tos_Click" >Gripa y tos</asp:LinkButton></li>
                  <li><asp:LinkButton runat="server" id="LinkButton21" CommandName="suplementos_sb" OnClick="subcategoria_Suplementos_Click" OnClientClick="subcategoria_Suplementos_Click" >Suplementos alimenticios</asp:LinkButton></li>
                  <li><asp:LinkButton runat="server" id="LinkButton22" CommandName="curacion_sb" OnClick="subcategoria_Curacion_Click" OnClientClick="subcategoria_Curacion_Click" >Material de curacion</asp:LinkButton></li>
                  <li><asp:LinkButton runat="server" id="LinkButton23" CommandName="especializados_sb" OnClick="subcategoria_especializados_Click" OnClientClick="subcategoria_especializados_Click" >Especializados</asp:LinkButton></li>
                  <li><asp:LinkButton runat="server" id="LinkButton24" CommandName="minerales_sb" OnClick="subcategoria_minerales_Click" OnClientClick="subcategoria_minerales_Click" >Vitaminas y minerales</asp:LinkButton></li>
                </ul>
                <img id="logo" src="imagenes_farmacia\Diabetes.jpg" alt="">
              </div>
          </div>
          
        </li>

        <li class="be" id="M2"><asp:LinkButton runat="server" id="LinkButton1" CommandName="Bebe_ca" OnClick="Categoria_Bebe_Click" OnClientClick="Categoria_Bebe_Click" >Bebe</asp:LinkButton>
          <div id="bebe"> 
                  <div id="sub_bebe">
                    <ul>
                      <li><asp:LinkButton runat="server" id="LinkButton25" CommandName="formulas_sb" OnClick="subcategoria_formulas_Click" OnClientClick="subcategoria_formulas_Click" >Formulas</asp:LinkButton></li>
                      <li><asp:LinkButton runat="server" id="LinkButton26" CommandName="leches_sb" OnClick="subcategoria_leches_Click" OnClientClick="subcategoria_leches_Click" >Leches</asp:LinkButton></li>
                      <li><asp:LinkButton runat="server" id="LinkButton27" CommandName="Alimentacion_sb" OnClick="subcategoria_Alimentacion_Click" OnClientClick="subcategoria_Alimentacion_Click" >Alimentacion bebe</asp:LinkButton></li>
                      <li><asp:LinkButton runat="server" id="LinkButton28" CommandName="panales_sb" OnClick="subcategoria_panales_Click" OnClientClick="subcategoria_panales_Click" >Pañales y tuallas</asp:LinkButton></li>
                      <li><asp:LinkButton runat="server" id="LinkButton29" CommandName="cuidado_sb" OnClick="subcategoria_cuidado_Click" OnClientClick="subcategoria_cuidado_Click" >Cuidado bebe</asp:LinkButton></li>
                      <li><asp:LinkButton runat="server" id="LinkButton30" CommandName="latancia_sb" OnClick="subcategoria_latancia_Click" OnClientClick="subcategoria_latancia_Click" >Embarazo y latancia</asp:LinkButton></li>
                      <li><asp:LinkButton runat="server" id="LinkButton31" CommandName="Infantiles_sb" OnClick="subcategoria_Infantiles_Click" OnClientClick="subcategoria_Infantiles_Click" >Medicamentos infantiles</asp:LinkButton></li>
                     
                    </ul>
                    <img id="logo" src="imagenes_farmacia\Bebes.png" alt="">
                    </div>

          </div>
        </li>

        <li class="bell" id="M2"><asp:LinkButton runat="server" id="LinkButton2" CommandName="Belleza_ca" OnClick="Categoria_Belleza_Click" OnClientClick="Categoria_Belleza_Click" >Belleza y derma</asp:LinkButton>
          <div id="belleza"> 
            <div id="sub_belleza">
              <ul>
                <li><asp:LinkButton runat="server" id="LinkButton32" CommandName="accesorios_sb" OnClick="subcategoria_accesorios_Click" OnClientClick="subcategoria_accesorios_Click" >Accesorios</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton33" CommandName="Derma_sb" OnClick="subcategoria_Derma_Click" OnClientClick="subcategoria_Derma_Click" >Derma</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton34" CommandName="Fragancia_sb" OnClick="subcategoria_Fragancia_Click" OnClientClick="subcategoria_Fragancia_Click" >Fragancia</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton35" CommandName="Maquillaje_sb" OnClick="subcategoria_Maquillaje_Click" OnClientClick="subcategoria_Maquillaje_Click" >Maquillaje</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton36" CommandName="Mascarilla_sb" OnClick="subcategoria_Mascarilla_Click" OnClientClick="subcategoria_Mascarilla_Click" >Mascarilla</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton37" CommandName="outlet_sb" OnClick="subcategoria_outlet_Click" OnClientClick="subcategoria_outlet_Click" >Outlet de belleza</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton38" CommandName="Rutinas_sb" OnClick="subcategoria_Rutinas_Click" OnClientClick="subcategoria_Rutinas_Click" >Rutinas</asp:LinkButton></li>
    
              </ul>
              <img id="logo" src="imagenes_farmacia\belleza.jpg" alt="">
            </div>
           
          </div>
        </li>

        <li class="hom" id="M2"><asp:LinkButton runat="server" id="LinkButton3" CommandName="hombre_ca" OnClick="Categoria_hombre_Click" OnClientClick="Categoria_hombre_Click" >Cuidado Hombre</asp:LinkButton>
          <div id="hombre"> 
            <div id="sub_hombre">
              <ul>
                <li><asp:LinkButton runat="server" id="LinkButton39" CommandName="afeitado_sb" OnClick="subcategoria_afeitado_Click" OnClientClick="subcategoria_afeitado_Click" >Afeitado</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton40" CommandName="capilar_sb" OnClick="subcategoria_capilar_Click" OnClientClick="subcategoria_capilar_Click" >Capilar</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton41" CommandName="corporal_sb" OnClick="subcategoria_corporal_Click" OnClientClick="subcategoria_corporal_Click" >Corporal</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton42" CommandName="facial_sb" OnClick="subcategoria_facial_Click" OnClientClick="subcategoria_facial_Click" >Cuidado facial</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton43" CommandName="fraganciaH_sb" OnClick="subcategoria_fraganciaH_Click" OnClientClick="subcategoria_fraganciaH_Click" >Fragancia</asp:LinkButton></li>
               
              </ul>
              <img id="logo" src="imagenes_farmacia\hombres.jpg" alt="">
            </div>
            
          </div>

        </li>
        <li class="hig" id="M2"><asp:LinkButton runat="server" id="LinkButton4" CommandName="higiene_ca" OnClick="Categoria_higiene_Click" OnClientClick="Categoria_higiene_Click" >Higiene personal</asp:LinkButton>
          <div id="higiene"> 
            <div id="sub_higiene">
              <ul>
                <li><asp:LinkButton runat="server" id="LinkButton48" CommandName="articulos_sb" OnClick="subcategoria_articulos_Click" OnClientClick="subcategoria_articulos_Click" >Articulos para el hogar</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton49" CommandName="bucal_sb" OnClick="subcategoria_bucal_Click" OnClientClick="subcategoria_bucal_Click" >Cuidado bucal</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton50" CommandName="icontigencia_sb" OnClick="subcategoria_icontigencia_Click" OnClientClick="subcategoria_incontigencia_Click" >Incontigencia</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton51" CommandName="afeitadoH_sb" OnClick="subcategoria_afeitadoH_Click" OnClientClick="subcategoria_afeitadoH_Click" >Afeitado</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton52" CommandName="desodorantesH_sb" OnClick="subcategoria_desodorantesH_Click" OnClientClick="subcategoria_desodorantesH_Click" >Desodorantes</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton53" CommandName="viaje_sb" OnClick="subcategoria_viaje_Click" OnClientClick="subcategoria_viaje_Click" >Articulos de viaje</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton54" CommandName="cabello_sb" OnClick="subcategoria_cabello_Click" OnClientClick="subcategoria_cabello_Click" >Cuidado el cabello</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton55" CommandName="piel_sb" OnClick="subcategoria_piel_Click" OnClientClick="subcategoria_piel_Click" >Cuidado de la piel</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton56" CommandName="femenina_sb" OnClick="subcategoria_femenina_Click" OnClientClick="subcategoria_femenina_Click" >Proteccion femenina</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton57" CommandName="jabones_sb" OnClick="subcategoria_jabones_Click" OnClientClick="subcategoria_jabones_Click" >Jabones</asp:LinkButton></li>
               
              </ul>
              <img id="logo" src="imagenes_farmacia\Higiene.png" alt="">
            </div>
            
          </div>
        </li>
        <li class="bien" id="M2"><asp:LinkButton runat="server" id="LinkButton5" CommandName="sexual_ca" OnClick="Categoria_sexual_Click" OnClientClick="Categoria_sexual_Click" >Bienestar Sexual</asp:LinkButton>
          <div id="bienestar"> 
            <div id="sub_bienestar">
              <ul>
                <li><asp:LinkButton runat="server" id="LinkButton44" CommandName="SuplementosS_sb" OnClick="subcategoria_SuplementosS_Click" OnClientClick="subcategoria_SuplementosS_Click" >Suplementos</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton45" CommandName="Perservativos_sb" OnClick="subcategoria_Perservativos_Click" OnClientClick="subcategoria_Perservativos_Click" >Perservativos</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton46" CommandName="Lubricante_sb" OnClick="subcategoria_Lubricante_Click" OnClientClick="subcategoria_Lubricante_Click" >Lubricante</asp:LinkButton></li>
                <li><asp:LinkButton runat="server" id="LinkButton47" CommandName="AcSexual_sb" OnClick="subcategoria_AcSexual_Click" OnClientClick="subcategoria_AcSexual_Click" >Accesorio Sexual</asp:LinkButton></li>
              
               
              </ul>
              <img id="logo" src="imagenes_farmacia\bienestar.jpg" alt="">
            </div>
            
          </div>
        
        
        </li>
      </ul>
      

    </div>
    

  </section>

</li> <!-- fin de la subcategorias -->
<li id="M1"><a id="l1" href="">Me quiero bien</a></li>
<li id="M1"><asp:LinkButton runat="server" id="LinkButton59" CommandName="bebe_ca" OnClick="Categoria_Bebe_Click" OnClientClick="Categoria_Bebe_Click" > Mi bebe crece </asp:LinkButton></li>
<li id="M1"><asp:LinkButton runat="server" id="LinkButton6" CommandName="Diabetes_ca" OnClick="Categoria_Diabetes_Click" OnClientClick="Categoria_Diabetes_Click" > Diabetes </asp:LinkButton> </li>
<li id="M1"><asp:LinkButton runat="server" id="LinkButton58" CommandName="Mascarilla_ca" OnClick="subcategoria_Mascarilla_Click" OnClientClick="subcategoria_Mascarilla_Click" > Mascarillas </asp:LinkButton></li>

   </ul>
 </nav>
</header>  
          
<section class="seccion">
    <br /> <br /> 
   <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
         <div class="carousel-inner">
           <div class="carousel-item active">
                 <img src="imagenes_farmacia/LOGOf.png" class="d-block w-100" alt="..." />
            </div>
      
  <asp:Repeater runat="server" ID="Ofertas_comunicacion">
      <ItemTemplate>
        <div class="carousel-item">
        <img src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"publica")) %>" class="d-block w-100" alt="...">
      </div>
      </ItemTemplate>
</asp:Repeater>  
               </div>
<button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>

    <br />


    <div style="width:100%;" id="litsa_p">
         <asp:Repeater runat="server" ID="repetidor" OnItemCommand="repetidor_ItemCommand" ViewStateMode="Enabled">
                 <ItemTemplate>
                     <div class="card" id="targeta" style="width: 16rem;">
                        <img src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"image")) %>" class="card-img-top" alt="...">
                      <div class="card-body">
                        <h5 class="card-title"><%#DataBinder.Eval(Container.DataItem,"name") %></h5>
                          <asp:Label runat="server" ID="Descripcion_producto" CssClass="card-text"> <%# Eval("descripcion") %> <br /> </asp:Label>
                         <asp:Label runat="server" class="card-text" ID="precio_producto"> $<%#DataBinder.Eval(Container.DataItem,"presio") %> <br /> </asp:Label> 
                          <asp:HiddenField runat="server" ID="clave" Value='<%# Eval("claveP") %>'/>
                          <asp:LinkButton runat="server" CssClass="btn btn-primary" ID="carrito" Enabled="True" OnClientClick="Agrega_carrito_Click" OnClick="Agrega_carrito_Click" CommandName="obtenerP">Agregar al carrito </asp:LinkButton>
                         
                        </div>
                        </div>
                 </ItemTemplate>
             </asp:Repeater>     
    </div>



</section>


<footer class="abajo">
    <hr />
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

