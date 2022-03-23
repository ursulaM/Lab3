<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Lab3.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Internship Report"></asp:Label>     
    <asp:GridView ID="grdvASDTable" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="true" AllowSorting="true"
        DataSourceID="sqlsrcASD" DataKeyNames="InternApplicantID">
        <Columns>     
            <asp:BoundField HeaderText="Student Name" ReadOnly="true" DataField="StudentName"
                SortExpression="StudentName" />
            <asp:BoundField HeaderText="Internship Name" ReadOnly ="true" DataField="InternshipName"
                SortExpression="Internship Name" />
        </Columns>
        
    </asp:GridView>
   
    <asp:SqlDataSource ID="sqlsrcASD" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="SELECT StudIntern.InternApplicantID, Student.StudentID, Student.FirstName + Student.LastName AS StudentName, 
        StudIntern.InternshipID, Internship.InternshipName  FROM StudIntern
        INNER JOIN Internship ON StudIntern.InternshipID  = Internship.InternshipID
        INNER JOIN Student ON StudIntern.StudentID = Student.StudentID"
        UpdateCommand= "">

        <UpdateParameters>
            <asp:Parameter Type="String" Name="ApplicationStatus" />
            
        </UpdateParameters>
            </asp:SqlDataSource>
</asp:Content>

