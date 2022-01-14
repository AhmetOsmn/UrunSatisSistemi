<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunSayfasi.aspx.cs" Inherits="UrunSatisSistemi.Urun.UrunSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <table class="table table-bordered">

        <tr>
            <th>#</th>
            <th>Ürün Adı</th>
            <th>Marka</th>
            <th>Kategori</th>
            <th>Fiyat</th>
            <th>Stok</th>
            <th></th>
            <th></th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("UrunID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("UrunMarka") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td><%#Eval("UrunFiyat") %></td>
                    <td><%#Eval("UrunStok") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/UrunSil.aspx?UrunID="+ Eval("UrunID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/UrunGuncelle.aspx?UrunID="+ Eval("UrunID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="UrunEkle.aspx" class="btn btn-info">Ürün Ekle</a>
</asp:Content>
