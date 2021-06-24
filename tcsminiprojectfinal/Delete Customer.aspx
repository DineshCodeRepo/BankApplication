<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Delete Customer.aspx.cs" Inherits="UI.WebForm4" %>
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
    <h1><center>Delete customer</center></h1>
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
                <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Confirm Delete" CssClass="button" OnClick="Button1_Click" />
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" OnClick="Button2_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
