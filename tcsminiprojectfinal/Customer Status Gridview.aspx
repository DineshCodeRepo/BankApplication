<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Customer Status Gridview.aspx.cs" Inherits="ProductBacklog.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><center>Customer Status</center></h1>
    <asp:GridView runat="server" AutoGenerateColumns="False" ID="Grid" HorizontalAlign="Center" OnRowUpdating="Grid_RowUpdating" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
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

            <asp:TemplateField HeaderText="Customer SSN ID">
                <ItemTemplate>
                    <asp:Label ID="lb2" runat="server" Text='<%#Eval("Customerssnid") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="lb2" runat="server" Text='<%#Eval("Customerssnid") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label ID="lb3" runat="server" Text='<%#Eval("Cusstatus") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb3" runat="server" Text='<%#Eval("Cusstatus") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <asp:Label ID="lb4" runat="server" Text='<%#Eval("Cusmessage") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb4" runat="server" Text='<%#Eval("Cusmessage") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>


            <asp:TemplateField HeaderText="Last Updated">
                <ItemTemplate>
                    <asp:Label ID="lb5" runat="server" Text='<%#Eval("Updatedate") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lb5" runat="server" Text='<%#Eval("Updatedate") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Operations">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkRefresh" runat="server" Text="Refresh" CommandName="Refresh" PostBackUrl="~/Customer Status Gridview.aspx"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="View Profile">
                <ItemTemplate>

                    <asp:LinkButton ID="lnkViewDetails" runat="server" Text="ViewDetails" CommandName="Update"></asp:LinkButton>
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
</asp:Content>
