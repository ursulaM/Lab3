<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page is a nav window--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AwardNav.aspx.cs" Inherits="Lab3.AwardNav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Award Scholarship" OnClick ="ASc" />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Award Job" OnClick ="AJ" />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Award Internship" OnClick ="AI" />
</asp:Content>
