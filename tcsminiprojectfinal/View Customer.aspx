<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="View Customer.aspx.cs" Inherits="tcsminiprojectfinal.WebForm1" %>
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
    <h1><center>Customer Details</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                SSN ID:
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtSSNid" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Customer ID:
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtcusid" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Customer Name:
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtcusname" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Age:
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAge" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Address:
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAddress" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
 </asp:Table>
</asp:Content>
