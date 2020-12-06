<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestAPI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Empfänger: (Link) <br />
    <asp:TextBox ID="txtURL" runat="server" Width="300px"></asp:TextBox> <br />
    <asp:TextBox ID="txtNachricht" runat="server" Height="80" Width="300"></asp:TextBox> <br />
    <asp:Button ID="btnSend" runat="server" Text="Senden" OnClick="btnSend_Click"/> <br />
    Empfangen: <br />
    <asp:ListBox ID="ChatLog" runat="server" Width="230"></asp:ListBox> <br />
    Protokoll: <br />
    <asp:ListBox ID="LogList" runat="server" Width="160px"></asp:ListBox>
    <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick"></asp:Timer>
</asp:Content>
