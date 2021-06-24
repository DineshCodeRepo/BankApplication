<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Create Account.aspx.cs" Inherits="UI.WebForm6" %>
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
    <h1><center>Create Account</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Customer ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtcusid" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
             <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter ID" ControlToValidate="txtcusid" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Account type:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlacctype" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Current</asp:ListItem>
                    <asp:ListItem>Savings</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select Account Type" ControlToValidate="ddlacctype" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Deposit Amount:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtamt" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Account Type" ControlToValidate="txtamt" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <p class="label">(*)Fields are compulsory</p>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="button" ValidationGroup="valid" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
