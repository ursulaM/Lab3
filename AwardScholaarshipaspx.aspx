<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to award a scholarship--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AwardScholaarshipaspx.aspx.cs" Inherits="Lab3.AwardScholaarshipaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="To award Scholarship, change Scholarship Status to 1 and click Award"></asp:Label>
    <br />
         <asp:Label ID="Label2" runat="server" Text="To Delete Application, change Scholarship Status to 3 and click Delete"></asp:Label>
           <asp:GridView ID="grdvAScholarTable" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="true" AllowSorting="true"
        DataSourceID="sqlsrcAScholar" DataKeyNames="ApplicationID">
        <Columns>
      
            <asp:BoundField HeaderText="Student Name" ReadOnly="true" DataField="StudentName"
                SortExpression="StudentName" />
            <asp:BoundField HeaderText="Scholarship Name" ReadOnly ="true" DataField="ScholarshipName"
                SortExpression="Scholarship Name" />
            <asp:BoundField HeaderText="Application Date" ReadOnly="true" DataField="ApplicationDate"
                SortExpression="ApplicationDate" />
            <asp:BoundField HeaderText="Application Status" DataField="ApplicationStatus"
                SortExpression="ApplicationStatus" />

            
        </Columns>
        
    </asp:GridView>
   
    <asp:SqlDataSource ID="sqlsrcAScholar" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="	SELECT ApplicationID, Student.FirstName + Student.LastName AS StudentName, ApplicationDate, ApplicationDetails, ApplicationStatus
        ,Scholarship.ScholarshipName, Student.StudentID, Scholarship.ScholarshipID FROM Applicant
        INNER JOIN Student ON Student.StudentID = Applicant.StudentID
        INNER JOIN Scholarship ON Scholarship.ScholarshipID = Applicant.ScholarshipID"
        UpdateCommand= "UPDATE [Applicant] SET [ApplicationStatus]=@ApplicationStatus WHERE [ApplicationID]=@ApplicationID">

        <UpdateParameters>
            <asp:Parameter Type="String" Name="ApplicationStatus" />
            
        </UpdateParameters>
            </asp:SqlDataSource>--%>
     <asp:Button ID="Award1" runat="server" Text="Award" OnClick ="Award" />
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
</asp:Content>
