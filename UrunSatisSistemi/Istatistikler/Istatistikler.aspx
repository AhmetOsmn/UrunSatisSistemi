<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Istatistikler.aspx.cs" Inherits="UrunSatisSistemi.Istatistikler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="clearfix"></div>

    <ul class="ca-menu">
        <li>
            <a href="#">
                <i class="fa fa-pie-chart" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub">Ürün Sayımız</h3>
                </div>
            </a>
        </li>
        <li>
            <a href="#">
                <i class="fa fa-user" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main one">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub one">Müşteri Sayımız</h3>
                </div>
            </a>
        </li>
        <li>
            <a href="#">
                <i class="fa fa-money" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main two">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub two">Kasadaki Tutar</h3>
                </div>
            </a>
        </li>
        <li>
            <a href="#">
                <i class="fa fa-apple" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main three">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub three">Kategori Sayımız</h3>
                </div>
            </a>
        </li>

    </ul>

    <ul class="ca-menu">
        <li>
            <a href="#">
                <i class="fa fa-list" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main">
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub">Aktif Ürün Sayısı</h3>
                </div>
            </a>
        </li>
        <li>
            <a href="#">
                <i class="fa fa-language" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main one">
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub one">Pasif Ürün Sayısı</h3>
                </div>
            </a>
        </li>
        <li>
            <a href="#">
                <i class="fa fa-database" aria-hidden="true"></i>
                <div class="ca-content">
                    <h4 class="ca-main two">
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></h4>
                    <h3 class="ca-sub two">Stokta En Çok Olan Ürün</h3>
                </div>
            </a>
        </li>
        <li>
            <a href="#">
                <i class="fa fa-sticky-note" aria-hidden="true"></i>
                <div class="ca-content">

                    <h4 class="ca-main three">
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></h4>

                    <h3 class="ca-sub three">En Fazla Ürünü Olan Kategori</h3>
                </div>
            </a>
        </li>
    </ul>
</asp:Content>
