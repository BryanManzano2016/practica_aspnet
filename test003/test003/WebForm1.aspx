<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test003.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="styles/WebForm1.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">Formulario de ingreso</asp:Label>
        </div>
        <p>Cedula:</p>
        <p>
            <asp:TextBox ID="cedula" runat="server" Width="378px"></asp:TextBox>
            </p>
        <p>Nombre: 
            </p>
    <p>
        <asp:TextBox ID="nombre" runat="server" Width="381px"></asp:TextBox>
        </p>
    <p>Edad: 
        </p>
    <p>
        <asp:TextBox ID="edad" runat="server" Width="384px"></asp:TextBox>
        </p>
        <asp:Button ID="boton_enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" />
        <p>
            <asp:TextBox ID="resultado_consulta" runat="server" Width="1139px"></asp:TextBox>
        </p>
    </form>
    </body>
</html>
