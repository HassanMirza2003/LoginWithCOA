<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logind.aspx.cs" Inherits="LoginWithCOA.Logind" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mb-3">
        <asp:Label ID="LblRes" runat="server" ForeColor="Red"></asp:Label>
    </div>
    <div class="w-50 mx-auto">
        <div class="mb-3">
            <asp:Label ID="LblEmail" runat="server" Text="Please Enter Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <asp:Label ID="LblPassword" runat="server" Text="Please Enter Password"></asp:Label>
            <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="mb-3">
            <asp:Button ID="BtnLogin" runat="server" Text="Login" CssClass="btn btn-primary d-block mx-auto" OnClick="BtnLogin_Click"></asp:Button>
        </div>
    </div>
</asp:Content>
