<%@ Page Title="" Language="C#" MasterPageFile="~/Cashier_Teller Master.Master" AutoEventWireup="true" CodeBehind="View Statement by No of transactions .aspx.cs" Inherits="UI.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Account Statement</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>


        <asp:TableRow>
            <asp:TableCell>
                <asp:RadioButton ID="RadioButton2" GroupName="Type" runat="server" Text="Last Number of Transactions" OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="true" />
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            
            <asp:TableCell>
                <asp:RadioButton ID="RadioButton1" GroupName="Type" runat="server" Text="Start-End Dates" OnCheckedChanged="RadioButton1_CheckedChanged1" AutoPostBack="true"/>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Number of Transactions:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </asp:TableCell>
        
    </asp:TableRow>
        
        
        
        </asp:Table>
    <asp:GridView runat="server" AutoGenerateColumns="False" ID="Grid" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod"></AlternatingRowStyle>
        <Columns>

            <asp:TemplateField HeaderText="Transaction ID">
                <ItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("transactionid") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("transactionid") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Description">
                <ItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("description") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("description") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Date(YYYY-MM-DD)">
                <ItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("date") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("date") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Amount">
                <ItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("amount") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("amount") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="Tan"></FooterStyle>

        <HeaderStyle BackColor="Tan" Font-Bold="True"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue"></PagerStyle>

        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#FAFAE7"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#DAC09E"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#E1DB9C"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#C2A47B"></SortedDescendingHeaderStyle>
    </asp:GridView>
    <asp:Table ID="Table2" runat="server" HorizontalAlign="Center">
    <asp:TableRow>
            
            <asp:TableCell>
                <asp:Button ID="Button2" runat="server" Text="Download As PDF file" Visible="false" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button3" runat="server" Text="Download as Excel file" Visible="false"/>
            </asp:TableCell>
        </asp:TableRow>
        </asp:Table>
</asp:Content>
