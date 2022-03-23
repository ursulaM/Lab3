<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to add a job--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="Lab3.AddJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Insert Job Name "></asp:Label>
            <asp:TextBox ID="Nam" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Nam" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Insert Job Salary "></asp:Label>
            <asp:TextBox ID="Sal" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="Sal" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in an integer"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Insert Job Location "></asp:Label>
            <asp:TextBox ID="Loco" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Loco" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Job" OnClick="StudentApp_Button" />
            <br />
            <asp:Label ID="Stuff" runat="server" Text=""></asp:Label>
</asp:Content>
