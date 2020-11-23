<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestAPI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Empfänger: (Link) <br />
    <asp:TextBox ID="txtURL" runat="server" Width="142px"></asp:TextBox> <br />
    <asp:TextBox ID="txtNachricht" runat="server" Height="80" Width="300"></asp:TextBox> <br />
    <asp:Button ID="btnSend" runat="server" Text="Senden" OnClick="btnSend_Click"/> <br />
    <asp:Label ID="lblStatus" runat="server" Text="-"></asp:Label> <br />
    Protokoll: <br />
    <asp:ListBox ID="LogList" runat="server" Width="160px"></asp:ListBox>
</asp:Content>
