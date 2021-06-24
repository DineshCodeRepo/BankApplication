<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Update Customer.aspx.cs" Inherits="UI.WebForm3" %>
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
    <h1><center>Update Customer</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Customer SSN ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbSSNid" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Customer ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbcusID" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>    
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
               Old Customer Name:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbOldcus" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
               New Customer Name:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtNewcus" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter New Name" ControlToValidate="txtNewcus" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Old Address:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbOldadd" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
               New Address:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtNewadd" TextMode="MultiLine" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter New Address" ControlToValidate="txtNewadd" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Old Age:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbOldage" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
               New Age:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtNewage" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter New Age" ControlToValidate="txtNewage" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>
               <p class="label"> (*)Fields are compulsory</p>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Update" CssClass="button" OnClick="Button1_Click" ValidationGroup="valid"/>
            </asp:TableCell>
            <asp:TableCell>

            </asp:TableCell>
            </asp:TableRow>
        

    </asp:Table>
</asp:Content>
