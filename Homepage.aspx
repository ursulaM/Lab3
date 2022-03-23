<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page is the home login page--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Lab3.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblHome" runat="server" Text="Please login to continue"></asp:Label>
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
    <br />
     <asp:Label ID="lblIncorrectLogin" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
    <br />
   <asp:Label ID="lblStatus" runat="server"></asp:Label>
    <br />
    <asp:Button ID="btnCreateStudent" runat="server" Text="Student Signup" OnClick="btnCreateStudent_Click" />
</asp:Content>
