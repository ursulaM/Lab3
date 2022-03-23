<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to edit an internship--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="EditInternship.aspx.cs" Inherits="Lab3.EditInternship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="ddlsclist" DataTextField="InternshipName"
        DataValueField="InternshipID" DataSourceID="sqlsrcIntern" runat="server">
    </asp:DropDownList>
     <asp:HiddenField ID="HiddenField1" runat="server" Value="" />
    <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Internship Name"></asp:Label>
    <asp:TextBox ID="TextBox1" Text="" runat="server"></asp:TextBox>
   
    <br />
        <asp:Label ID="Label2" runat="server" Text="Internship Description"></asp:Label>
    <asp:TextBox ID="TextBox2" Text="" runat="server"></asp:TextBox>

    <br />
        <asp:Label ID="Label3" runat="server" Text="Internship Year"></asp:Label>
    <asp:TextBox ID="TextBox3" Text="" runat="server"></asp:TextBox>
 
    <br />
        <asp:Label ID="Label4" runat="server" Text="Internship Date Start"></asp:Label>
    <asp:TextBox ID="TextBox4" Text="" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="updtButton" runat="server" Text="Edit" OnClick="updtButton_Click"  />
    <asp:SqlDataSource ID="sqlsrcIntern" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="SELECT InternshipID, InternshipName FROM Internship">

    </asp:SqlDataSource>
</asp:Content>
