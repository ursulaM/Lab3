<%--Ursula Mitchell
Feb 21 2022
This page allows a student to apply for a scholarship--%>



<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="ApplyScholarship.aspx.cs" Inherits="Lab3.ApplyScholarship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Create a Student Application for a Scholarship"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Insert Date as Number (01012022) "></asp:Label>
            <asp:TextBox ID="DateBox" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="DateBox" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in a date as a number"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Insert any other Application Details "></asp:Label>
            <asp:TextBox ID="DetailsBox" runat="server"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="DetailsBox" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create Application" OnClick="StudentApp_Button" />
            <br />
            <asp:Label ID="Stuff" runat="server" Text=""></asp:Label>
</asp:Content>
