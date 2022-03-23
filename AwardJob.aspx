<%--Ursula Mitchell Zach Ritter
FEB 28 2022
This page allows a member to award a job--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="AwardJob.aspx.cs" Inherits="Lab3.AwardJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label1" runat="server" Text="To award Job, change Job Status to 1 and click Award"></asp:Label>
    <br />
         <asp:Label ID="Label2" runat="server" Text="To Delete Application, change Job Status to 3 and click Delete"></asp:Label>
               <asp:GridView ID="grdvAJobTable" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="true" AllowSorting="true"
        DataSourceID="sqlsrcAJob" DataKeyNames="JobApplicationID">
        <Columns>
      
            <asp:BoundField HeaderText="Student Name" ReadOnly="true" DataField="StudentName"
                SortExpression="StudentName" />
            <asp:BoundField HeaderText="Job Name" ReadOnly ="true" DataField="JobName"
                SortExpression="Job Name" />
            <asp:BoundField HeaderText="Application Date" ReadOnly="true" DataField="ApplicationDate"
                SortExpression="ApplicationDate" />
            <asp:BoundField HeaderText="Application Status" DataField="ApplicationStatus"
                SortExpression="ApplicationStatus" />

            
        </Columns>
        
    </asp:GridView>
   
    <asp:SqlDataSource ID="sqlsrcAJob" runat="server"
        ConnectionString ="<%$ ConnectionStrings:Lab3 %>"
        SelectCommand="	SELECT JobApplicationID, Student.FirstName + Student.LastName AS StudentName, ApplicationDate, ApplicationDetails, ApplicationStatus
        ,Job.JobName, Student.StudentID, Job.JobID FROM JobApplicant
        INNER JOIN Student ON Student.StudentID = JobApplicant.StudentID
        INNER JOIN Job ON Job.JobID = JobApplicant.JobID"
        UpdateCommand= "UPDATE [JobApplicant] SET [ApplicationStatus]=@ApplicationStatus WHERE [JobApplicationID]=@JobApplicationID">

        <UpdateParameters>
            <asp:Parameter Type="String" Name="ApplicationStatus" />
            
        </UpdateParameters>
            </asp:SqlDataSource>--%>
     <asp:Button ID="Award1" runat="server" Text="Award" OnClick ="Award" />
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
</asp:Content>
