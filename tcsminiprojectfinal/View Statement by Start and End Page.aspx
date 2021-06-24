<%@ Page Title="" Language="C#" MasterPageFile="~/Cashier_Teller Master.Master" AutoEventWireup="true" CodeBehind="View Statement by Start and End Page.aspx.cs" Inherits="UI.WebForm15" %>
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
    <h1><center>Account Statement</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Account ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Account id" ControlToValidate="TextBox3" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Start Date:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" TextMode="Date" runat="server" ></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Start Date" ControlToValidate="TextBox1" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                End Date:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" TextMode="Date" runat="server" ></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter End Date" ControlToValidate="TextBox2" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                (*)Fields are compulsory
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click" ValidationGroup="valid" />
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
