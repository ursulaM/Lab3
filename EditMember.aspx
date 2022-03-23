<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to edit  a member--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="EditMember.aspx.cs" Inherits="Lab3.EditMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="ddlmemberlist" DataTextField="MemberName"
        DataValueField="MemberID" DataSourceID="sqlsrcMember" runat="server">
    </asp:DropDownList>
     <asp:HiddenField ID="HiddenField1" runat="server" Value="" />
    <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="TextBox1" Text="" runat="server"></asp:TextBox>

    <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="TextBox2" Text="" runat="server"></asp:TextBox>

    <br />
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="TextBox3" Text="" runat="server"></asp:TextBox>


    <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>
    <asp:TextBox ID="TextBox4" Text="" runat="server"></asp:TextBox>

    <br />
        <asp:Label ID="Label5" runat="server" Text="Grad Year"></asp:Label>
    <asp:TextBox ID="TextBox5" Text="" runat="server"></asp:TextBox>
    
    <br />
        <asp:Label ID="Label6" runat="server" Text="Title"></asp:Label>
    <asp:TextBox ID="TextBox6" Text="" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="updtButton" runat="server" Text="Edit" OnClick="updtButton_Click"  />
    <asp:SqlDataSource ID="sqlsrcMember" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="SELECT MemberID,  FirstName + LastName as MemberName FROM MEMBER">

    </asp:SqlDataSource>
</asp:Content>
