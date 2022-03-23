<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page is a navigation window--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AddNav.aspx.cs" Inherits="Lab3.AddNav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" Text="Add Member" OnClick="AddM" />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Add Scholarship" OnClick="AddSc" />
    <br />
    <asp:Button ID="Button4" runat="server" Text="Add Internship" OnClick ="AddI" />
    <br />
    <asp:Button ID="Button5" runat="server" Text="Add Job" OnClick="AddJ" />
</asp:Content>
