<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a student to look at and edit their profile--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="EditStudentProfile.aspx.cs" Inherits="Lab3.EditStudentProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <asp:HiddenField ID="HiddenField1" runat="server" Value="" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="TextBox1" Text="" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
    <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="TextBox2" Text="" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
    <br />
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="TextBox3" Text="" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
    <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>
    <asp:TextBox ID="TextBox4" Text="" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox4" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
    <br />
        <asp:Label ID="Label5" runat="server" Text="Grad Year"></asp:Label>
    <asp:TextBox ID="TextBox5" Text="" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="CompareValidator" ControlToValidate="TextBox5" 
            ForeColor="Red" Operator="DataTypeCheck" Type="Integer" Text="Enter in an integer"></asp:CompareValidator>
    <br />
        <asp:Label ID="Label6" runat="server" Text="Major"></asp:Label>
    <asp:TextBox ID="TextBox6" Text="" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox6" 
            ForeColor="Red" Text="Required Text Field"></asp:RequiredFieldValidator>
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
        SelectCommand="SELECT FileName, FileLocation FROM Student WHERE StudentID=@SID" runat="server">
            <SelectParameters>
                <asp:SessionParameter Name="SID" SessionField="SID" />
            </SelectParameters>
        </asp:SqlDataSource> 
        <asp:Button ID="updtButton" runat="server" Text="Edit" OnClick="updtButton_Click"  />
     
 
</asp:Content>
