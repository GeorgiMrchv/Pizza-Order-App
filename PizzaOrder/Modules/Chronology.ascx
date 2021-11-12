<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Chronology.ascx.cs" Inherits="PizzaOrder.Modules.Chronology" %>
<div class="menu">
    <!-- <asp:Panel ID="ticketsViewPnl" runat="server" Style="display: inline-block;"><a href="/TicketsView">Tickets</a></asp:Panel>-->
    <a href="/Offers">Offers</a>
    <a href="/Orders">Orders</a>
    <a href="/Info">Information</a>
</div>
<div class="menu2">
    <a href="/Chronology">Chronology</a>
</div>



<div id="h22">
    <h2>Предишни поръчки</h2>
</div>

<div class="inner-content ic-suppor-ticket">
    <asp:Repeater ID="orderRepeater" runat="server">
        <ItemTemplate>
            <div class="content">
                <div class="rowTV">
                    <p class="figure"><%# Container.ItemIndex+1 %>.&nbsp;</p>
                    <div class="t-container">
                        Telephone: 
                        0<asp:Label ID="Telephone" runat="server" Text='<%# Eval("Telephone") %>' CssClass="label-text" />
                    </div>
                    <div class="t-container">
                        Addreess:
                        <asp:Label ID="Address" runat="server" Text='<%# Eval("Address") %>' CssClass="label-text" />
                    </div>

                </div>
                <div class="rowTV">
                    <p class="t-container">
                        Category:
                        <asp:Label ID="Category" runat="server" Text='<%# Eval("Category") %>' CssClass="label-text" />
                    </p>
                    <p class="t-container">
                        Product:
                        <asp:Label ID="Product" runat="server" Text='<%# Eval("Product") %>' CssClass="label-text" /> 
                    </p>
                </div>
                <div class="rowTV">
                    <p class="t-container">
                        Size:
                        <asp:Label ID="Size" runat="server" Text='<%# Eval("Size") %>' CssClass="label-text" />
                    </p>
                    <p class="t-container">
                        Price:
                        <asp:Label ID="Price" runat="server" Text='<%# Eval("TotalAmount") %>' CssClass="label-text" />lv.
                    </p>
                </div>
                <div class="C-text">
                    <span style="color:chartreuse"><asp:Label ID="exceptionText" runat="server" Text='<%# Eval("Comment") %>' CssClass="C-label" /></span>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
