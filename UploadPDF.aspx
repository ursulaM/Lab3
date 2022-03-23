<%--Ursula Mitchell Zach Ritter
March 9 2022
This page is the upload pdf resume page for students 
    I used this video to help me https://www.youtube.com/watch?v=h7sswv6LyIw --%>

<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="UploadPDF.aspx.cs" Inherits="Lab3.UploadPDF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        File Upload
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        File Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Upload PDF Resume" OnClick="Button1_Click" />
    </p>
    <p>

    </p>
</asp:Content>
