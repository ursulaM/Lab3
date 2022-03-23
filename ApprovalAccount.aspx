<%@ Page Title="" Language="C#" MasterPageFile="~/Lab3Master.Master" AutoEventWireup="true" CodeBehind="ApprovalAccount.aspx.cs" Inherits="Lab2.ApprovalAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:Label ID="lblApprove" runat="server" Text="To apporve change the approval number from 0 --> 1"></asp:Label>
    <br />
           <asp:GridView ID="grdvwApprove" AutoGenerateEditButton="true" runat="server" AllowPaging="true" AutoGenerateColumns="false" AllowSorting="true"  DataSourceID="sqlsrcPerson" DataKeyNames="UserID">
        <Columns>

      
            <asp:BoundField HeaderText="Username" ReadOnly="true" DataField="Username"
                SortExpression="Username" />
            <asp:BoundField HeaderText="Email" ReadOnly ="true" DataField="Email"
                SortExpression="Email" />
            <asp:BoundField HeaderText="Approved"  DataField="Approved"
                SortExpression="Approved" />
                     
        </Columns>
      </asp:GridView>

    <asp:SqlDataSource ID="sqlsrcPerson" runat="server"
        ConnectionString="<%$ ConnectionStrings:AUTH%>"
        SelectCommand="Select [UserID], [Email], [Username], [Approved] From [Person]"
        UpdateCommand="UPDATE [Person] SET [Approved] = @Approved"> 
        <UpdateParameters>
            <asp:Parameter Type="String" Name="Approved" />
        </UpdateParameters>
            </asp:SqlDataSource>--%>
   <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />        
</asp:Content>
