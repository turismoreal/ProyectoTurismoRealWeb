<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Portafolio.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="BodyBody" runat="server">

    
   <div class="text-center"">
                    <h1>Login</h1>
                </div>
    <hr/>
   <div class="mx-auto" style="width: 200px;" >
  <div >
    <label for="ejemploEmail">Dirección de correo</label>
    <input type="email" class="form-control" id="ejemploEmail" placeholder="correo@ejemplo.com">
  </div>
  <div class="form-group">
    <label for="ejemploFormPassword2">Contraseña</label>
    <input type="password" class="form-control" id="ejemploFormPassword2" placeholder="Contraseña">
  </div>
  <div class="form-group">
    <div class="form-check">
      <input type="checkbox" class="form-check-input" id="dropdownCheck2">
      <label class="form-check-label" for="dropdownCheck2">
        Recuerda mis datos
      </label>
    </div>
  </div>
  <button type="submit" class="btn btn-primary">Ingresar</button>
  <button type="submit" class="btn btn-primary">Registro</button>
  </div>
   

</asp:Content>
