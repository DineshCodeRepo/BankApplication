<%@ Page Title="" Language="C#" MasterPageFile="~/Cashier_Teller Master.Master" AutoEventWireup="true" CodeBehind="Transfer Money.aspx.cs" Inherits="UI.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1><center>Transfer Money</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Customer ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Source Account Type:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    

                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Target Account Type:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList2" runat="server" >
                    
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        
        
        

        <asp:TableRow>
            <asp:TableCell>
                Transfer Amount:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Transfer" OnClick="Button1_Click" />
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>
