<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriSayfasi.aspx.cs" Inherits="UrunSatisSistemi.KategoriSayfasi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">

        <tr>
            <th>#</th>
            <th>Kategori Adı</th>
            <th></th>
            <th></th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KategoriID") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/KategoriSil.aspx?KategoriID="+ Eval("KategoriID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/KategoriGuncelle.aspx?KategoriID="+ Eval("KategoriID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="KategoriEkle.aspx" class="btn btn-info">Kategori Ekle</a>
</asp:Content>
