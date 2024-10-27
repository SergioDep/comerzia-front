<%@ Page Title="" Language="C#" MasterPageFile="~/App/Layout.Master" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="EventMasterSoftWA.App.login.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Aquí puedes agregar estilos o scripts específicos para esta página -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" rel="stylesheet" />
    <style>
        /* Ajuste de tamaño del logo */
        .logo-img {
            max-width: 300px; /* Aumenta el tamaño del logo */
        }

        /* Control del ancho del formulario */
        .login-container {
            max-width: 280px; /* Ancho máximo del formulario */
            width: 100%; /* Asegura que se mantenga centrado */
        }

         
        /* Ocultar la barra de navegación y el menú lateral solo en la página de login */
        #mainNavbar, #sidebar {
            display: none;
        }
    

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container d-flex justify-content-center align-items-center vh-100">
        <div class="text-center login-container">
            <!-- Imagen y título -->
            <img src="/public/Images/Comerzia.jpg" alt="Comerzia Logo" class="mb-4 logo-img" />
            



            <!-- Formulario de inicio de sesión -->
            <div>
                <div class="form-group">
                    <input type="text" class="form-control mb-3" placeholder="Usuario" />
                </div>
                <div class="form-group">
                    <input type="password" class="form-control mb-3" placeholder="Contraseña" />
                </div>
                <button type="submit" class="btn btn-primary btn-block">Iniciar Sesión</button>
                
            </div>
        </div>
    </div>
</asp:Content>