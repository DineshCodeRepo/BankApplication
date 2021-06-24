<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Account-Search Executive.aspx.cs" Inherits="UI.WebForm46" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Account Search</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" ></asp:TextBox>
            </asp:TableCell>
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
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" OnTextChanged="TextBox2_TextChanged" AutoPostBack="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Select Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </asp:TableCell>
            
        </asp:TableRow>

        <asp:TableRow>
           
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="View"  OnClick="Button1_Click"/>
            </asp:TableCell>
             <asp:TableCell><asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click"/></asp:TableCell>
        </asp:TableRow>
        
    </asp:Table>
</asp:Content>

