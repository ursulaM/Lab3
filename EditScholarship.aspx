<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to eidt a scholarship--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="EditScholarship.aspx.cs" Inherits="Lab3.EditScholarship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="ddlsclist" DataTextField="ScholarshipName"
        DataValueField="ScholarshipID" DataSourceID="sqlsrcStudent" runat="server">
    </asp:DropDownList>
     <asp:HiddenField ID="HiddenField1" runat="server" Value="" />
    <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Scholarship Name"></asp:Label>
    <asp:TextBox ID="TextBox1" Text="" runat="server"></asp:TextBox>

    <br />
        <asp:Label ID="Label2" runat="server" Text="Scholarship Year"></asp:Label>
    <asp:TextBox ID="TextBox2" Text="" runat="server"></asp:TextBox>

    <br />
        <asp:Label ID="Label3" runat="server" Text="Scholarship Amount"></asp:Label>
    <asp:TextBox ID="TextBox3" Text="" runat="server"></asp:TextBox>
    
    <br />
        <asp:Label ID="Label4" runat="server" Text="ScholarshipDescription"></asp:Label>
    <asp:TextBox ID="TextBox4" Text="" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="updtButton" runat="server" Text="Edit" OnClick="updtButton_Click"  />
    <asp:SqlDataSource ID="sqlsrcStudent" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="SELECT ScholarshipID, ScholarshipName FROM Scholarship">

    </asp:SqlDataSource>
</asp:Content>
