<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to add an internship--%>



<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AddInternship.aspx.cs" Inherits="Lab3.AddInternship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Insert Internship Name "></asp:Label>
            <asp:TextBox ID="Nam" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Nam" ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Insert Internship Description "></asp:Label>
            <asp:TextBox ID="Des" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Des" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Insert Internship Year "></asp:Label>
            <asp:TextBox ID="Year" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="Year" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in a Year"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Insert Internship Date Start "></asp:Label>
            <asp:TextBox ID="Ds" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="Ds" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in a date as an integer"></asp:CompareValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Internship" OnClick="StudentApp_Button" />
            <br />
            <asp:Label ID="Stuff" runat="server" Text=""></asp:Label>
</asp:Content>
