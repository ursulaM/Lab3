<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page is a nav window--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="EditNav.aspx.cs" Inherits="Lab3.EditNav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Edit Student" OnClick ="EditS" />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Edit Member" OnClick="EditM" />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Edit Scholarship" OnClick="EditSc" />
    <br />
    <asp:Button ID="Button4" runat="server" Text="Edit Internship" OnClick ="EditI" />
    <br />
    <asp:Button ID="Button5" runat="server" Text="Edit Job" OnClick="EditJ" />
</asp:Content>
