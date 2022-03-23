<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page is a nav window--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="ApplyNav.aspx.cs" Inherits="Lab3.ApplyNav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Apply for an Internship" OnClick="AppI"/>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Apply for a Job" OnClick="AppJ" style="height: 35px" />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Apply for a Scholarship" OnClick="AppS" />
</asp:Content>
