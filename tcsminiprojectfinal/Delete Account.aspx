<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Delete Account.aspx.cs" Inherits="UI.WebForm7" %>
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
    <h1><center>Delete Account</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
              
        <asp:TableRow>
            <asp:TableCell>
                Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlaccid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlaccid_SelectedIndexChanged">
              
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Account type:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtacctype" runat="server" ReadOnly="true"  OnTextChanged="txtacctype_TextChanged"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Delete Account" CssClass="button" OnClick="Button1_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
