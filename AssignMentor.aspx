<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to assign a mentor--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AssignMentor.aspx.cs" Inherits="Lab3.AssignMentor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server" ></asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Assign Mentorship" OnClick ="AssignMen" />
    <br />
    <asp:Label ID="Stuff" runat="server" Text=""></asp:Label>
</asp:Content>
