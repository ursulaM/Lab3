<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to award an internship--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AwardInternship.aspx.cs" Inherits="Lab3.AwardInternship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="To award Internship, change Internship Status to 1 and click Award"></asp:Label>
    <br />
     <asp:Label ID="Label2" runat="server" Text="To Delete Application, change Internship Status to 3 and click Delete"></asp:Label>
           <asp:GridView ID="grdvAInternTable" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="true" AllowSorting="true"
        DataSourceID="sqlsrcAIntern" DataKeyNames="InternApplicationID">
        <Columns>
      
            <asp:BoundField HeaderText="Student Name" ReadOnly="true" DataField="StudentName"
                SortExpression="StudentName" />
            <asp:BoundField HeaderText="Internship Name" ReadOnly ="true" DataField="InternshipName"
                SortExpression="Internship Name" />
            <asp:BoundField HeaderText="Application Date" ReadOnly="true" DataField="ApplicationDate"
                SortExpression="ApplicationDate" />
            <asp:BoundField HeaderText="Application Status" DataField="ApplicationStatus"
                SortExpression="ApplicationStatus" />

            
        </Columns>
        
    </asp:GridView>
   
    <asp:SqlDataSource ID="sqlsrcAIntern" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="	SELECT InternApplicationID, Student.FirstName + Student.LastName AS StudentName, ApplicationDate, ApplicationDetails, ApplicationStatus
        ,Internship.InternshipName, Student.StudentID, Internship.InternshipID FROM InternApplicant
        INNER JOIN Student ON Student.StudentID = InternApplicant.StudentID
        INNER JOIN Internship ON Internship.InternshipID = InternApplicant.InternshipID"
        UpdateCommand= "UPDATE [InternApplicant] SET [ApplicationStatus]=@ApplicationStatus WHERE [InternApplicationID]=@InternApplicationID">

        <UpdateParameters>
            <asp:Parameter Type="String" Name="ApplicationStatus" />
            
        </UpdateParameters>
            </asp:SqlDataSource>
     <asp:Button ID="Award1" runat="server" Text="Award" OnClick ="Award" />
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />

</asp:Content>
