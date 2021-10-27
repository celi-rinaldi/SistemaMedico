<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaMedico.aspx.cs" Inherits="WebMedicos.VistaMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:<asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox>
            <br />
             Apellido:<asp:TextBox ID="txtApellido" runat="server" ></asp:TextBox>
              <br />
             Nro Matricula:<asp:TextBox ID="txtNroMatricula" runat="server" ></asp:TextBox>
              <br />
             Id:<asp:TextBox ID="txtId" runat="server" ></asp:TextBox>
            <br />
              Especialidad:<asp:DropDownList ID="ddlEspecialidad" runat="server" OnSelectedIndexChanged="ddlEspecialidad_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
            <asp:Label ID="lblPrueba" runat="server" Text="Prueba"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click" />
            <br />
            <br />
            <asp:GridView ID="gridMedico" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
