<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Account Status Gridview.aspx.cs" Inherits="UI.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Account Status</center></h1>
    
    <asp:GridView runat="server" AutoGenerateColumns="False" ID="gd" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod"></AlternatingRowStyle>
        <Columns>

            <asp:TemplateField HeaderText="Customer ID">
                <ItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("Customerid") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("Customerid") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Account ID">
                <ItemTemplate>
                    <asp:Label ID="lb2" runat="server" Text='<%#Eval("Accountid") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="lb2" runat="server" Text='<%#Eval("Accountid") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Account Type">
                <ItemTemplate>
                    <asp:Label ID="lb3" runat="server" Text='<%#Eval("Type") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb3" runat="server" Text='<%#Eval("Type") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Account Status">
                <ItemTemplate>
                    <asp:Label ID="lb4" runat="server" Text='<%#Eval("Accstatus") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb4" runat="server" Text='<%#Eval("Accstatus") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <asp:Label ID="lb5" runat="server" Text='<%#Eval("Accmessage") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb5" runat="server" Text='<%#Eval("Accmessage") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Last Updated">
                <ItemTemplate>
                    <asp:Label ID="lb6" runat="server" Text='<%#Eval("Updatedate") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb6" runat="server" Text='<%#Eval("Updatedate") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Operations">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkRefresh" runat="server" Text="Refresh" PostBackUrl="~/Account Status Gridview.aspx" CommandName="Refresh"></asp:LinkButton>
                </ItemTemplate>
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

    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow >
            <%--<asp:TableCell>

            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>--%>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Refresh the List" PostBackUrl="~/Account Status Gridview.aspx"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
