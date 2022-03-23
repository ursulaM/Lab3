<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Lab3.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnApply" runat="server" Text="Apply for a scholarship" OnClick="btnApply_Click" />
    <br />
    <asp:Button ID="btnStudentProfile" runat="server" Text="Student Profile" OnClick="btnStudentProfile_Click"/>  
    <br />
    <asp:Button ID="btnEditStudentInfo" runat="server" Text="Edit Student Profile" OnClick="btnEditStudentInfo_Click" />
</asp:Content>
