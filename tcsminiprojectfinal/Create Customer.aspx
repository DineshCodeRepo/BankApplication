<%@ Page Title="" Language="C#" MasterPageFile="~/Customer-Account Executive Master.Master" AutoEventWireup="true" CodeBehind="Create Customer.aspx.cs" Inherits="UI.WebForm2" %>
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
    <h1><center>Create Customer Screen</center></h1>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Customer SSN Id:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtSSNid" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
              <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter SSN id" ControlToValidate="txtSSNid" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Customer Name:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtcusname" runat="server"></asp:TextBox>
            </asp:TableCell>
              <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Name" ControlToValidate="txtcusname" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Age:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtage" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
              <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Age" ControlToValidate="txtage" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                Address:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtaddress" TextMode="MultiLine" runat="server"></asp:TextBox>
            </asp:TableCell>
              <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Address" ControlToValidate="txtaddress" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                State:
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>TAMIL NADU</asp:ListItem>
                    <asp:ListItem>ANDHRA PRADESH</asp:ListItem>
                    <asp:ListItem>KERALA</asp:ListItem>
                    <asp:ListItem>KARNATAKA</asp:ListItem>
                    <asp:ListItem>MAHARASHTRA</asp:ListItem>
                    <asp:ListItem>GUJARAT</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
              <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select State" ControlToValidate="ddlState" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>



        <asp:TableRow>
            <asp:TableCell>
                City:
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                   <ContentTemplate>
                       <asp:DropDownList ID="ddlCity" runat="server">
                       <asp:ListItem>Select</asp:ListItem>
                       </asp:DropDownList>
                   </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlState" EventName="SelectedIndexChanged" />
                    </Triggers>
                
                    </asp:UpdatePanel>
            </asp:TableCell>
              <asp:TableCell>
                <p class="label">*</p>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Select City" ControlToValidate="ddlCity" ClientIDMode="Static" SetFocusOnError="True" ValidationGroup="valid"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <p class="label">(*)Fields are compulsory</p>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" CssClass="button" Text="Submit" OnClick="Button1_Click" ValidationGroup="valid" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button2" runat="server" CssClass="button" Text="Reset" OnClick="Button2_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
