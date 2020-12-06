<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestAPI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Empfänger: (Link) <br />
    <asp:TextBox ID="txtURL" runat="server" Width="450px"></asp:TextBox> <br />
    Nachricht: <br />
    <asp:TextBox ID="txtNachricht" runat="server" TextMode="MultiLine" Height="80" Width="450"></asp:TextBox> <br />
    <asp:Button ID="btnSend" runat="server" Text="Absenden" OnClick="btnSend_Click"/> <br />
    Empfangen: <br />
    <asp:UpdatePanel ID="UP1" runat="server">
        <ContentTemplate>
            <asp:ListBox ID="ChatLog" runat="server" Height="100" Width="450"></asp:ListBox> <br />
            <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick"></asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
    Protokoll: <br />
    <asp:ListBox ID="LogList" runat="server" Height="100" Width="450"></asp:ListBox>
</asp:Content>
