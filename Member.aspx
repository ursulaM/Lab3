<%--Ursula Mitchell Zach Ritter
Feb 22 2022
This page will be the homepage for members to engage in--%>




<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Lab3.Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:Button ID="btnAddd" runat="server" Text="Add Information" OnClick="btnAdd"  />
    <br />
    <asp:Button ID="btnEditt" runat="server" Text="Edit Information" OnClick="btnEdit" />
    <br />
    <asp:Button ID="btnAward" runat="server" Text="Award a Student" OnClick="SIJ" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Edit Profile" OnClick="EPro" />
    <br />
    <asp:Button ID="Buton" runat="server" Text="Assign a Mentor" OnClick="AMem" />
    <br />
    <asp:Button ID="report2" runat="server" Text="Report" OnClick="Report" />
    <br />
    <asp:Button ID="btnAdmin" runat="server" Text="Admin Page" OnClick="btnAdmin_Click" />
    <br />
    <asp:Button ID="btnCreateMember" runat="server" Text="Create a Member Page" OnClick="btnCreateMember_Click" />
    <br />
    <asp:Button ID="Search" runat="server" Text="Search a Student" OnClick="Search_Click" />
    <br />
    <asp:Button ID="btnLogOut_Click" runat="server" Text="Log Out" 
        OnClick="btnLogOut_Click_Click"/>
    <br />
    <asp:Label ID="Incorrect" runat="server" Text=""></asp:Label>
</asp:Content> 
