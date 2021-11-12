<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Offers.ascx.cs" Inherits="PizzaOrder.Modules.Offers" %>
<div class="menu">
    <!-- <asp:Panel ID="ticketsViewPnl" runat="server" Style="display: inline-block;"><a href="/TicketsView">Tickets</a></asp:Panel>-->
    <a href="/Offers">Offers</a>
    <a href="/Orders">Orders</a>
    <a href="/Info">Information</a>
</div>
<div class="menu2">
    <a href="/Chronology">Chronology</a>
</div>

<div class="pizza">
    <asp:Repeater ID="pizzaRepeater" runat="server">
        <ItemTemplate>
            <img src='<%# Eval("ProductImage") %>' height="250" />
            <!-- Eval-cheto izvikva stoinostta na kolonata za vseki red,koito se zarejda v repeater-a -->
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="coke">
    <asp:Repeater ID="cokeRepeater" runat="server">
        <ItemTemplate>
            <img src='<%# Eval("ProductImage") %>' height="250" />
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="hamburger">
    <asp:Repeater ID="hamburgerRepeater" runat="server">
        <ItemTemplate>
            <img src='<%# Eval("ProductImage") %>' height="250" />
        </ItemTemplate>
    </asp:Repeater>
</div>

