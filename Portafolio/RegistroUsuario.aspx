<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="Portafolio.RegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyBody" runat="server">
    

    <div class="container">
        <div class="row">
            <div class="col-6 align-content-center offset-3">
                <div class="text-center"">
                    <h1>Formulario de Registro</h1>
                </div>
               <hr/>

                <div >
                     <input type="text" class="form-control is-valid" id="validationServer01" placeholder="Nombre" value="" required>
                </div>             
                <br />

                <div class="form-row">
                 <div class="form-group col-md-6">
                 <div>
                    <input type="text" class="form-control is-valid" id="validationServer02" placeholder="Apellido Paterno" value="" required>
                </div>
                </div>
                              
                <div class="form-group col-md-6">
                    <input type="text" class="form-control is-valid" id="validationServer03" placeholder="Apellido Materno" value="" required>
                </div>
                </div>   
                <br />
                
                <div class="form-row">
                 <div class="form-group col-md-6">
                <div>
                    <input type="text" class="form-control is-valid" id="validationServer04" placeholder="Rut" value="" required>
                </div>
                </div>
                <br />

                <div class="form-group col-md-6">
                    <input type="number" class="form-control is-valid" id="validationServer05" placeholder="Telefóno" value="" required>
                </div>
                </div> 
                <br />
                                     
                <div>
                    <input type="text" class="form-control is-valid" id="validationServer07" placeholder="Dirección" value="" required>
                </div>
                <br />

                <div class="form-row">
                <div class="form-group col-md-6">
                <div>
                    <input type="date" class="form-control is-valid" id="validationServer06" placeholder="Fecha de nacimiento" value="" required>
                </div>
                </div>
                <br />

                <div class="form-group col-md-6">
                <div>
                    <input type="email" class="form-control is-valid" id="validationServer08" placeholder="Correo electronico" value="" required>
                </div>
                </div>
                </div>
                <br />

                <div class="form-row">
                 <div class="form-group col-md-6">
                <div>
                    <input type="password" class="form-control is-valid" id="validationServer09" placeholder="Contraseña" value="" required>
                </div>
                </div>
                <br />

                <div class="form-group col-md-6">
                <div>
                    <input type="password" class="form-control is-valid" id="validationServer10" placeholder="Vuelva a escribir contraseña" value="" required>
                </div>
                </div>
                </div>
                <br />
                
                <div class="text-center">
                    <asp:Button CssClass="btn btn-outline-primary" ID="BtnAgrergarCliente" runat="server" Text="Registrarse"  />
                </div>
            </div>
      </div> 
    </div>


   
</asp:Content>
