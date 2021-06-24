<%@ Page Title="" Language="C#" MasterPageFile="~/Cashier_Teller Master.Master" AutoEventWireup="true" CodeBehind="AccountDetials.aspx.cs" Inherits="UI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Deposit Money</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Customer ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Account Type:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Balance:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            
            <asp:TableCell ColumnSpan="2">
                <asp:Button ID="Button1" runat="server" Text="Withdraw" OnClick="Button1_Click"/>
                <asp:Button ID="Button2" runat="server" Text="Deposit" OnClick="Button2_Click"/>
                <asp:Button ID="Button3" runat="server" Text="Transfer" OnClick="Button3_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
