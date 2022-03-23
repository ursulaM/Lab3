<%--Ursula Mitchell Zach Ritter
March 9 2022
This page is for members to search for a student and view their profile --%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="StudentSearch.aspx.cs" Inherits="Lab3.StudentSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:Label ID="Label8" runat="server" Text="Enter in First Name"></asp:Label>
    <asp:TextBox ID="TextBox8" Text="" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Enter in Last Name"></asp:Label>
    <asp:TextBox ID="TextBox7" Text="" runat="server"></asp:TextBox>
         <asp:HiddenField ID="HiddenField1" runat="server" Value="" />
    <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
    <asp:Label ID="TextBox1" Text="" runat="server"></asp:Label>
    <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
    <asp:Label ID="TextBox2" Text="" runat="server"></asp:Label>
    <br />
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
    <asp:Label ID="TextBox3" Text="" runat="server"></asp:Label>
    <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>
    <asp:Label ID="TextBox4" Text="" runat="server"></asp:Label>
    <br />
        <asp:Label ID="Label5" runat="server" Text="Grad Year"></asp:Label>
    <asp:Label ID="TextBox5" Text="" runat="server"></asp:Label>
    <br />
        <asp:Label ID="Label6" runat="server" Text="Major"></asp:Label>
    <asp:Label ID="TextBox6" Text="" runat="server"></asp:Label>
    <br />
   
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="pdfupload">
            <HeaderStyle BackColor="#0066FF" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="pdfupload" ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="SELECT FileName, FileLocation FROM Student WHERE FirstName=@Fname AND LastName=@Lname" runat="server">
            <SelectParameters>
                <asp:ControlParameter  Name ="Fname" ControlID="Textbox8" />
            </SelectParameters>
                        <SelectParameters>
                <asp:ControlParameter  Name ="Lname" ControlID="Textbox7" />
            </SelectParameters>
        </asp:SqlDataSource> 
       
</asp:Content>
