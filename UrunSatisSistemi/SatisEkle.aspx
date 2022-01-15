<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisEkle.aspx.cs" Inherits="UrunSatisSistemi.SatisEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        Ürün Seçin
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        Personel Seçin
        <div>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        Müşteri Seçin
        <div>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        Fiyat
        <div>
            <asp:TextBox ID="TextBoxFiyat" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Satış Yap" CssClass="btn btn-primary" OnClick="Button1_Click" />

    </form>
</asp:Content>
