<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" Height="445px" Width="620px" />&nbsp;<asp:Button 
            ID="btnZoomMais" runat="server" onclick="btnZoomMais_Click" Text="Zoom +" />
        <asp:Button ID="btnZoomMenos" runat="server" onclick="btnZoomMenos_Click" 
            Text="Zoom -" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Esquerda" />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Cima" />
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Baixo" />
        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
            Text="Direita" />
    </div>
    </form>
</body>
</html>
