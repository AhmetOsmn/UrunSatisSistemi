using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;
namespace UrunSatisSistemi
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var varOlanKategoriler = (from x in db.Kategoriler select new { x.KategoriID, x.KategoriAd }).ToList();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = varOlanKategoriler;
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.UrunAd = TextBoxUrunAd.Text;
            urun.UrunStok = short.Parse(TextBoxStok.Text);
            urun.UrunMarka = TextBoxMarka.Text;
            urun.UrunFiyat = decimal.Parse(TextBoxFiyat.Text);
            urun.UrunKategori = byte.Parse(DropDownList1.SelectedValue);
            urun.Durum = true;
            db.Urunler.Add(urun);
            db.SaveChanges();
            Response.Redirect("UrunSayfasi.aspx");
            
        }
    }
}