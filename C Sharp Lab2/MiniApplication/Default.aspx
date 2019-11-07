<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiniApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Enter Name
    </div>
    <div>   
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button Text="Next" ID="ButtonNext" runat="server" OnClick="ButtonNext_Click" />
        <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
    </div>

</asp:Content>

