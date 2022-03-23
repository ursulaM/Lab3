<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This is the home student page--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="Lab3.ViewStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="Button2" runat="server" Text="Report" OnClick="Report" />
    <br />
    <asp:Button ID="Button4" runat="server" Text="Upload Your Resume" OnClick="Button4_Click" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Apply" OnClick="Apply" /> 
    <br />
     <asp:Button ID="Button3" runat="server" Text="Edit Your Profile" OnClick="Button3_Click"  /> 
    <br />
    <asp:Button ID="btnLogOut_Click" runat="server" Text="Log Out" 
        OnClick="btnLogOut_Click_Click"/>
    <br />
    <asp:Label ID="Incorrect" runat="server" Text=""></asp:Label>
</asp:Content>
