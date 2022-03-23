<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Farmacia_san_juan.Administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administrador</title>
    <link rel="stylesheet" type="text/css" href="css_farmacia/Administrador_estilo.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet"  >
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.min.js" integrity="sha384-Atwg2Pkwv9vp0ygtn1JAojH0nYbwNJLPhwyoVbhoPwBhjQPR5VtM2+xf0Uwh9KtT" crossorigin="anonymous"></script>
</head>


<body>
    <form  runat="server">
        
        <header style="position:relative; top:-2147483648%; left: -1px;">
             <nav class="navbar navbar-expand-lg navbar-dark bg-primary ">
                <div class="container-fluid">
                 <a class="navbar-brand" href="Administrador.aspx">Farmacias San Juan Admin</a>
                   <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                      <span class="navbar-toggler-icon"></span>
                    </button>
             <div class="collapse navbar-collapse" id="navbarSupportedContent">
                  <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                  <li class="nav-item">
                  <a class="nav-link active" aria-current="page" href="Administrador.aspx">Inicio</a>
                  </li>
                  <li class="nav-item">
                 <asp:LinkButton runat="server" CssClass="btn btn-primary"  data-bs-toggle="offcanvas" href="#offcanvasExample" role="button" aria-controls="offcanvasExample"> Perfil</asp:LinkButton>
     <div class="offcanvas offcanvas-start" tabindex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
    <div class="offcanvas-header">
      <h5 class="offcanvas-title" id="offcanvasExampleLabel"><asp:Label runat="server" ID="name_usr"> Nombre de Admin <br /></asp:Label> <br /> <asp:Label runat="server" ID="Id_usr" style="float:left; margin-top:0%;">ID</asp:Label> <br /> <asp:Label runat="server" ID="correo_txt" style="float:left; margin-top:0%;">Correo</asp:Label> </h5>
      <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
    </div>
    <div class="offcanvas-body">
      <div style="text-align:left;">
         
          <asp:Button runat="server" ID="Cerrar_sesion" CssClass="btn btn-outline-danger" Text="Cerrar Sesion" OnClick="Cerrar_sesion_Click" OnClientClick="Cerrar_sesion_Click" />
          <br />

          <asp:Panel ID="panel_perfil" runat="server" Visible="true">
              <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_correo">Correo</asp:Label>
          <asp:TextBox runat="server"  CssClass="form-control" ID="txt_correo" ></asp:TextBox>
         
    <asp:Label runat="server" for="staticEmail" CssClass="col-sm-2 col-form-label" ID="lb_password2">Contraseña nueva</asp:Label>
          <asp:TextBox runat="server" ID="txt_pwd" CssClass="form-control" TextMode="Password" ></asp:TextBox> <br />

                <asp:Panel ID="p_AC_succes" runat="server" CssClass="alert alert-success alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="mg_succes" CssClass="mensaje">Mensaje</asp:Label>
            </asp:Panel>
            
            <asp:Panel ID="p_AC_err" runat="server" CssClass="alert alert-danger alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="mg_err" CssClass="mensaje">Mensaje</asp:Label>
            </asp:Panel>
           
          <asp:Button runat="server" ID="Actualiza_admin" Text="Actualizar Perfil" CssClass="btn btn-outline-primary" OnClick="Actualiza_admin_Click" OnClientClick="Actualiza_admin_Click"/>
          </asp:Panel>
          
      </div>
    </div>
  </div>
  </li>
              
             </div>
            </div>
            </nav>

     
   
        </header>

        <div style="position:absolute;">
       
        <div id="Agregar_container">
           <div id="Head">
           <h3>Productos</h3>
           </div>
           
            <label>Clave producto</label> <br />
            <asp:TextBox runat="server" ID="Clave" OnTextChanged="Calve_TextChanged"  CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="Buscar" Text="Buscar" CssClass="btn btn-outline-primary" OnClick="Buscar_Click" OnUnload="Buscar_Unload"/> 
            <br />
            <label>Nombre</label>
            <br />
             
            <asp:TextBox  CssClass="form-control" runat="server" ID="Name" ></asp:TextBox> 
            <label>Categoria</label> 
            <asp:DropDownList  CssClass="form-control" ID="Category" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Category_SelectedIndexChanged" OnLoad="Category_Load">
               <asp:ListItem>Diabetes</asp:ListItem>
                <asp:ListItem>Farmacia</asp:ListItem>
                <asp:ListItem>Bebe</asp:ListItem>
                <asp:ListItem>Belleza y Derma</asp:ListItem>
                <asp:ListItem>Cuidado Hombre</asp:ListItem>
                <asp:ListItem>Higiene personal</asp:ListItem>
                <asp:ListItem>Salud sexual</asp:ListItem>
            </asp:DropDownList> 
            <label>Sub-categoria</label> 
             <asp:DropDownList  CssClass="form-control" ID="subcategoria" runat="server">
             </asp:DropDownList> <br />
            <label>Imagen</label> <br />
             <asp:FileUpload  CssClass="form-control" runat="server" ID="Image2" OnDataBinding="Image_DataBinding" /> <br />
           
           
            <asp:Image  ID="Image1" runat="server" Height="300px" Width="400px" Visible="False" /> <asp:Button ID="Preview" runat="server" Text="vista Previa" OnClick="Preview_Click" CssClass="btn btn-outline-primary"/> <br />
 
            <label>Descripcion</label>
            
            <asp:TextBox  CssClass="form-control" ID="Descripcion" runat="server" ></asp:TextBox>
           
            <label>Presio</label>
           
            <asp:TextBox  CssClass="form-control" ID="Presio" runat="server" ></asp:TextBox>

           <br />
            <asp:Panel ID="Notification" runat="server" CssClass="alert alert-success alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="Mesagge" CssClass="mensaje">Mensaje</asp:Label>
                 <asp:Button  runat="server" CssClass="btn-close" OnClick="Unnamed2_Click" data-bs-dismiss="alert" aria-label="Close" />
               
            </asp:Panel>
            
            <asp:Panel ID="Error" runat="server" CssClass="alert alert-danger alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="MesaggeEr" CssClass="mensaje">Mensaje</asp:Label>
                 <asp:Button  runat="server" CssClass="btn-close" OnClick="Unnamed2_Click" data-bs-dismiss="alert" aria-label="Close" />
               
            </asp:Panel>

           <br />
            <asp:Button runat="server" Text="Registrar" CssClass="btn btn-outline-primary" OnClick="Unnamed1_Click" /> 
            <asp:Button runat="server" Text="Actualizar" ID="update" CssClass="btn btn-outline-success" OnClick="update_Click" /> 
            <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-outline-danger"  ID="delete" OnClick="delete_Click"/> 
        </div>
         <div id="lista-productos" style="overflow:scroll" >
             <asp:Repeater runat="server" ID="repetidor">
                 <ItemTemplate>
                     
                     <div id="targeta" class="card" style="width: 12rem; height:16rem;">
                    
                      <img  class="card-img-top" width ="100px" height="100px" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"image")) %>"/>        
                         <div class="card-body">
                         <asp:Label runat="server">Clave<%#DataBinder.Eval(Container.DataItem,"claveP") %></asp:Label>  <br />  
                         <asp:Label CssClass="card-title" runat="server"> <%#DataBinder.Eval(Container.DataItem,"name") %></asp:Label>   
                         <asp:Label CssClass="card-text" runat="server"> <%#DataBinder.Eval(Container.DataItem,"categoria") %></asp:Label> 
                         <asp:Label CssClass="card-text" runat="server"> <%#DataBinder.Eval(Container.DataItem,"subcategoria") %></asp:Label> 
                         <asp:Label  CssClass="card-text" runat="server"> <%#DataBinder.Eval(Container.DataItem,"descripcion") %></asp:Label>  
                         <asp:Label  CssClass="card-text" runat="server">$<%#DataBinder.Eval(Container.DataItem,"presio") %></asp:Label> 
                         </div>
                         
                    
                     </div>
                 </ItemTemplate>
             </asp:Repeater>     

          </div>
   <div class="accordion" id="accordionPanelsStayOpenExample">
  <div class="accordion-item">
    <h2 class="accordion-header" id="panelsStayOpen-headingOne">
      <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
        Agregar Oferta o Comunicado o Tip
      </button>
    </h2>
    <div id="panelsStayOpen-collapseOne" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingOne">
      <div class="accordion-body">
      Seleccione la imagen a publicar (solo imagenes en *.png)</h3>
      <asp:FileUpload  CssClass="form-control" runat="server" ID="Publicacion_img" OnDataBinding="Image_DataBinding" /> 

           <asp:Panel ID="Img_Succes" runat="server" CssClass="alert alert-success alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="LB_succes" CssClass="mensaje">Mensaje</asp:Label>
                 <asp:Button  runat="server" CssClass="btn-close" OnClick="Unnamed2_Click" data-bs-dismiss="alert" aria-label="Close" />
               
            </asp:Panel>
            
            <asp:Panel ID="Img_error" runat="server" CssClass="alert alert-danger alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="LB_error" CssClass="mensaje">Mensaje</asp:Label>
                 <asp:Button  runat="server" CssClass="btn-close" OnClick="Unnamed2_Click" data-bs-dismiss="alert" aria-label="Close" />
               
            </asp:Panel>

           <asp:Button runat="server" Text="Publicar" CssClass="btn btn-outline-primary" ID="Publicar" OnClick="Publicar_Click" /> 
          <br />
         <br />
          <asp:TextBox ID="identificador_del" runat="server" CssClass="form-control" TextMode="Number" placeholder="Identificador" Width="300px"></asp:TextBox>
          <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" ID="del_publicacion" OnClick="del_publicacion_Click"/>
         
          <div >
              <h3>Publicaciones</h3>
              <div class="Tabla_publicacion">
                 <asp:Repeater runat="server" ID="Repite_publicacion">
                 <ItemTemplate>
                     <div id="targeta" class="card" style="width:10rem;">
                      <img  class="card-img-top" width ="100px" height="100px" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"publica")) %>"/>        
                         <div class="card-body">
                        <asp:Label  CssClass="card-text" runat="server"> Identificador: <%#DataBinder.Eval(Container.DataItem,"identificador") %></asp:Label> 
                         </div>
                         
                     </div>
                 </ItemTemplate>
             </asp:Repeater>     
              </div>
          </div>

      </div>
    </div>
  </div>
  
</div>

        <div class="accordion" id="accordionPanelsStayOpenExample">
            <div class="accordion-item">
                <h1 class="accordion-header" id="panelsStayOpen-headingOne" >
                     <label class="accordion-button"  data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
                        <h2>Pedidos </h2>
                         <div class="d-flex"  style="float:right;">
                            <asp:TextBox runat="server" ID="txt_buscar_pedido" CssClass="form-control me-2" TextMode="Search" placeholder="Buscar id pedido" style="width:650px" aria-label="Search" > </asp:TextBox>
                            <asp:Button runat="server" Text="Buscar pedido" CssClass="btn btn-outline-dark" type="submit" ID="Buscar_pdo" OnClick="Buscar_pdo_Click" OnClientClick="Buscar_pdo_Click"/>
                          </div>
                     </label>
                </h1>
            </div>
         
            <div style="float:left; height:500px; overflow: scroll; width:100%;">
  
                <table class="table table-dark table-hover">
                <tr class="table-dark">
                    <th scope="col" class="table-dark">No.Pedido</th>
                    <th scope="col" class="table-dark">ID usuario</th>
                    <th scope="col" class="table-dark">productos</th>
                     <th scope="col" class="table-dark"> Precio total</th>
                     <th scope="col" class="table-dark">fecha</th>
                     <th scope="col" class="table-dark">estado</th>
                </tr>

                    <asp:Repeater runat="server" ID="repite_misPedidos" ViewStateMode="Enabled" OnItemCommand="repite_misPedidos_ItemCommand">
                        <ItemTemplate>
                         <tr class="table-dark">

                        <td class="table-dark"> <%# Eval("Nopedido") %></td>
                        <td class="table-dark"> <%# Eval("idUsuario") %></td>
                        <td class="table-dark"> <%# Eval("productos") %></td>
                        <td class="table-dark"> <%# Eval("precioT") %></td>
                        <td class="table-dark"> <%# Eval("fecha") %></td>
                        <td class="table-dark"> <%# Eval("estado") %></td>
                        <asp:HiddenField runat="server" ID="clave_pedidos" Value='<%# Eval("Nopedido") %>'/>
                        <asp:HiddenField runat="server" ID="estado" Value='<%# Eval("estado") %>'/>
                        <td class="table-dark"><asp:LinkButton runat="server" CssClass="btn btn-outline-primary" ID="cancela_pedido" Enabled="True" CommandName="cancelaPD">Entregado</asp:LinkButton> </td>

                        </tr>
                        </ItemTemplate>
                    </asp:Repeater>
              </table>
            </div>
        </div>

         <div class="accordion" id="accordionPanelsStayOpenExample">
            <div class="accordion-item">
                <h1 class="accordion-header" id="panelsStayOpen-headingOne" >
                     <label class="accordion-button"  data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
                        <h2>Usuarios </h2>
                         <div class="d-flex"  style="float:right;">
                            <asp:TextBox runat="server" ID="busca_usuario" CssClass="form-control me-2" TextMode="Search" placeholder="Buscar id usuario" style="width:650px" aria-label="Search" > </asp:TextBox>
                            <asp:Button runat="server" Text="Buscar Usuario" CssClass="btn btn-outline-dark" type="submit" ID="Busca_usd" OnClick="Buscar_usd_Click" OnClientClick="Buscar_usd_Click"/>
                          </div>
                     </label>
                </h1>
            </div>
         
            <div style="float:left; height:500px; overflow: scroll; width:100%;">
  
                <table class="table table-dark table-hover">
                <tr class="table-dark">
                    <th scope="col" class="table-dark">Id usuario</th>
                    <th scope="col" class="table-dark">Nombre</th>
                    <th scope="col" class="table-dark">correo</th>
                     <th scope="col" class="table-dark">contraseña</th>
                     <th scope="col" class="table-dark">fecha de nacimiento</th>
                     <th scope="col" class="table-dark">telefono</th>
                     <th scope="col" class="table-dark">direccion</th>
                </tr>

                    <asp:Repeater runat="server" ID="Repeater_usuarios" ViewStateMode="Enabled" >
                        <ItemTemplate>
                         <tr class="table-dark">

                        <td class="table-dark"> <%# Eval("idUsuario") %></td>
                        <td class="table-dark"> <%# Eval("name") %></td>
                        <td class="table-dark"> <%# Eval("mail") %></td>
                        <td class="table-dark"> <%# Eval("password") %></td>
                        <td class="table-dark"> <%# Eval("fechaNacimiento") %></td>
                        <td class="table-dark"> <%# Eval("phone") %></td>
                        <td class="table-dark"> <%# Eval("direccion") %></td>

                        </tr>
                        </ItemTemplate>
                    </asp:Repeater>
              </table>
            </div>
        </div>

        <div style="float:left;">
            <h2>Agregar nueva cuenta de Administrador</h2>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Nombre</label>
                <asp:TextBox runat="server" type="text" CssClass="form-control" ID="Nombre_admin" placeholder="Nombre"></asp:TextBox>
                </div>
             <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Correo</label>
                <asp:TextBox runat="server" type="email" CssClass="form-control" ID="correo_admin" placeholder="name@example.com"></asp:TextBox>
                </div>

             <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Contraseña</label>
                <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="pwd_admin" placeholder="password"></asp:TextBox>
                </div>

            <asp:Panel ID="p_succes" runat="server" CssClass="alert alert-success alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="Mensaje_succes" CssClass="mensaje">Mensaje</asp:Label>
            </asp:Panel>
            
            <asp:Panel ID="p_err" runat="server" CssClass="alert alert-danger alert-dismissible fade show" Visible="False">
                <asp:Label runat="server" ID="Mensaje_err" CssClass="mensaje">Mensaje</asp:Label>
            </asp:Panel>


            <div class="mb-3">
                <asp:Button runat="server" CssClass="btn btn-outline-primary" ID="Registra_admin" Text="Registrar" OnClick="Registra_admin_Click" OnClientClick="Registra_admin_Click"/>
                </div>

                </div>

           <div style="float:right; height:500px; overflow: scroll; ">

            <div class="accordion" id="accordionPanelsStayOpenExample">
            <div class="accordion-item">
                <h1 class="accordion-header" id="panelsStayOpen-headingOne" >
                     <label class="accordion-button"  data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
                        <h2>Administradores </h2>
                         <div class="d-flex"  style="float:right;">
                            <asp:TextBox runat="server" ID="txt_administrador" CssClass="form-control me-2" TextMode="Search" placeholder="Buscar id administrador" style="width:200px" aria-label="Search" > </asp:TextBox>
                            <asp:Button runat="server" Text="Buscar Admin" CssClass="btn btn-outline-dark" type="submit" ID="btn_administrador" OnClick="btn_administrador_Click" OnClientClick="btn_administrador_Click"/>
                          </div>
                     </label>
                </h1>
            </div>
  
                <table class="table table-dark table-hover">
                <tr class="table-dark">
                    <th scope="col" class="table-dark">ID admin</th>
                    <th scope="col" class="table-dark">Nombre</th>
                    <th scope="col" class="table-dark">Correo</th>
                    <th scope="col" class="table-dark">Contraseña</th>
                   
                </tr>

                    <asp:Repeater runat="server" ID="repite_administrador" ViewStateMode="Enabled" >
                        <ItemTemplate>
                         <tr class="table-dark">

                        <td class="table-dark"> <%# Eval("idAdmin") %></td>
                        <td class="table-dark"> <%# Eval("nombre") %></td>
                        <td class="table-dark"> <%# Eval("correo") %></td>
                         <td class="table-dark"> <%# Eval("password") %></td>

                        </tr>
                        </ItemTemplate>
                    </asp:Repeater>
              </table>
            </div>

               </div>

            </div>

    </form>
</body>
</html>
