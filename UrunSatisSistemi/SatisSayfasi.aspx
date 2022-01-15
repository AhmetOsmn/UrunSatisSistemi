<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisSayfasi.aspx.cs" Inherits="UrunSatisSistemi.SatisSayfasi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">

        <tr>
            <th>#</th>
            <th>Ürün</th>
            <th>Personel</th>
            <th>Müşteri</th>
            <th>Fiyat</th>

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("SatisID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("PersonelAdSoyad") %></td>
                    <td><%#Eval("MUSTERI") %></td>
                    <td><%#Eval("Fiyat") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="SatisEkle.aspx" class="btn btn-info">Yeni Satış</a>
</asp:Content>
