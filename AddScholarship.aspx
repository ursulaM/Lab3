<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AddScholarship.aspx.cs" Inherits="Lab3.AddScholarship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to add a scholarship--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Insert Scholarship Name "></asp:Label>
            <asp:TextBox ID="Snam" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Snam" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Insert Scholarship Year "></asp:Label>
            <asp:TextBox ID="Year" runat="server"></asp:TextBox>
     <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="Year" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in a year"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Insert Scholarship Amount "></asp:Label>
            <asp:TextBox ID="Sa" runat="server"></asp:TextBox>
     <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="Sa" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in an integer"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Insert Scholarship Description "></asp:Label>
            <asp:TextBox ID="Sd" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Sd" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Internship" OnClick="StudentApp_Button" />
            <br />
            <asp:Label ID="Stuff" runat="server" Text=""></asp:Label>
</asp:Content>
