<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Customer-Search.aspx.cs" Inherits="ProductBacklog.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .label
        {
            color:red;
        }
        .button{
            border-radius:10px;
            background-color:steelblue;
            color:yellow;
            font-size:medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Customer Search</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Enter SSN ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtSSNid" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <%--<asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter SSN id" ControlToValidate="txtSSNid"></asp:RequiredFieldValidator>
            </asp:TableCell>--%>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                OR
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Enter Customer ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtcusid" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
           <%-- <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Customer id" ControlToValidate="txtcusid"></asp:RequiredFieldValidator>
            </asp:TableCell>--%>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Update" CssClass="button" OnClick="Button1_Click" />
            </asp:TableCell>
             <asp:TableCell>
                <asp:Button ID="Button2" runat="server" Text="Delete" CssClass="button" OnClick="Button2_Click" />
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>
