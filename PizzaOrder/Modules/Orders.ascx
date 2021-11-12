<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Orders.ascx.cs" Inherits="PizzaOrder.Modules.Orders" %>
<div class="menu">
    <!-- <asp:Panel ID="ticketsViewPnl" runat="server" Style="display: inline-block;"><a href="/TicketsView">Tickets</a></asp:Panel>-->
    <a href="/Offers">Offers</a>
    <a href="/Orders">Orders</a>
    <a href="/Info">Information</a>
</div>
<div class="menu2">
    <a href="/Chronology">Chronology</a>
</div>


<div id="h2">
    <h2>Моля,попълнете вашата поръчка!</h2>
</div>

<div class="field">
    <div class="row">
        <div class="validator-container">                                                                                       <!--tova otdolu ^[0-9]+$ dobur validator za telefon  -->
            <asp:RegularExpressionValidator CssClass="validator" Display="Dynamic" ControlToValidate="Telephone" ID="phoneNumberValidator" ValidationExpression="^[0-9]+$" runat="server" ErrorMessage="Minimum 5 and Maximum 20 characters required." ForeColor="Red" />
        </div>

        <div class="validator-container">                                                                                                                                           <!--tova otdolu (?<s>^[\D]+[ ])(?<h>[\d]+)(?<e>.*?$)| dobur validator za address  -->
            <asp:RegularExpressionValidator CssClass="validator" Display="Dynamic" ControlToValidate="Address" ID="emailValidator" runat="server" ErrorMessage="Please enter correct address" ForeColor="Red" ValidationExpression="(?<s>^[\D]+[ ])(?<h>[\d]+)(?<e>.*?$)|" />
        </div>
    </div>
    <div class="row">
        <div class="tb-container">
            <img src="App_Themes/First/phone.png" alt="" />
            <asp:TextBox ID="Telephone" onclick="HideText(this, 'Telephone')" onblur="ShowDefaultText(this, 'Telephone')" Text="Telephone" runat="server" ></asp:TextBox>
        </div>
        <div class="tb-container">
            <img src="App_Themes/First/email.png" alt="" />
            <asp:TextBox ID="Address" onclick="HideText(this, 'Address')" onblur="ShowDefaultText(this, 'Address')" Text="Address" runat="server" ></asp:TextBox>
        </div>
    </div>
    <div class="row1">
        <div class="tb-container1">
            <asp:DropDownList ID="Categories" runat="server" Height="22px" Width="250px" AutoPostBack="true" OnSelectedIndexChanged="Categories_SelectedIndexChanged">
                <asp:ListItem Text="Select Category" Value="0" Selected="True" />
                <asp:ListItem Text="Pizza" Value="1" />
                 <asp:ListItem Text="Drinks" Value="2" />
                 <asp:ListItem Text="Burgers" Value="3" />
            </asp:DropDownList>
        </div>
        <div class="tb-container1">
            <asp:DropDownList ID="Products" runat="server" Height="22px" Width="250px" AutoPostBack="true" OnSelectedIndexChanged="Products_SelectedIndexChanged">
                <asp:ListItem Text="Select Product" Value="0" Selected="True" />
            </asp:DropDownList>
        </div>
        </div>
    <div class="row2">
          <div class="tb-container1">
            <asp:DropDownList ID="Size" runat="server" Height="22px" Width="250px">
                <asp:ListItem Text="Select Size" Value="0" Selected="True" />
            </asp:DropDownList>
        </div>
    </div>
    <div class="comment">
        <img src="App_Themes/First/pencil.png" alt="" />
        <asp:TextBox ID="boxComment" onclick="HideText(this, 'Comment')" onblur="ShowDefaultText(this, 'Comment')" Text="Comment" runat="server" TextMode="MultiLine" Height="200px" CssClass="text-box" />
    </div>

    <div class="send-button">
        <asp:Button ID="btn" Text="SEND" runat="server" CssClass="send-btn" OnClick="btn_Click" />
    </div>
</div>

<!-- java script funkciika za premaxvane na default-niq tekst v kutiikite  -->
<script type="text/javascript">
    function HideText(object, defaultText) {
        if (object.value == defaultText) {
            object.value = '';
        }
    }

    function ShowDefaultText(object, defaultText) {
        if (object.value == '') {
            object.value = defaultText;
        }
    }
</script>

