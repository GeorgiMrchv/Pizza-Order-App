<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="PizzaOrder.Modules.Registration" %>
<div id="regBox">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Username:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxUN" runat="server" Height="25px" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Username filled is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">E-mail:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxEmail" runat="server" Height="25px" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="You must enter a valid E-mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Password:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxPass" runat="server" Height="25px" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Password is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Confirm password:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxConfirm" runat="server" Height="25px" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxConfirm" ErrorMessage="You have forgot to confirm the password!" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxConfirm" ErrorMessage="Both passwords must be the same!" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Neighbourhood:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownListHood" runat="server" Height="25px" Width="187px">
                    <asp:ListItem>Select Hood</asp:ListItem>
                    <asp:ListItem>Kartala</asp:ListItem>
                    <asp:ListItem>Zonata</asp:ListItem>
                    <asp:ListItem>Pishmana</asp:ListItem>
                    <asp:ListItem>Cholakovci</asp:ListItem>
                    <asp:ListItem>Triugulnika</asp:ListItem>
                    <asp:ListItem>Akaciq</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownListHood" ErrorMessage="Select a country name!" ForeColor="Red" InitialValue="Select Hood"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" Text="Submit!" OnClick="Button1_Click" Height="24px" Width="90px" />
                <input id="Reset1" class="auto-style5" type="reset" value="reset" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</div>
<div id="backbtn">
    <asp:Button ID="Back" runat="server" Text="Back" OnClick="Button2_Click" Height="24px" Width="90px" CausesValidation="False" /></div>
