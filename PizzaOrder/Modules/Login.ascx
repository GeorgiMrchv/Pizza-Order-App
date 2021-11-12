<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="PizzaOrder.Modules.Login" %>

<div id="profile"><h5>(За да направите вашата поръчка е небходимо да влезете във вашия профил!)</h5></div>
<div id="logForm">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Username:</td>
            <td class="auto-style4">
                <asp:TextBox ID="UsernameBox" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UsernameBox" ErrorMessage="Username required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Password:</td>
            <td class="auto-style4">
                <asp:TextBox ID="PasswordBox" runat="server" Width="216px" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordBox" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" Height="30px" Text="Proceed" Width="83px" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Height="30px" Text="Register now!" Width="103px" OnClick="Button2_Click" CausesValidation="False" />
                <br />
                <asp:CheckBox ID="checkBoxRemember" runat="server" Text="Remember me!" OnCheckedChanged="CheckBox1_CheckedChanged" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</div>
