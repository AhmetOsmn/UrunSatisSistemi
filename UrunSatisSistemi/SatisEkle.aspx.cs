using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using UrunSatisSistemi.Entity;
using System.Web.UI.WebControls;

namespace UrunSatisSistemi
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var olanUrunler = (from x in db.Urunler select new { x.UrunID, x.UrunAd }).ToList();
                DropDownList1.DataTextField = "UrunAd";
                DropDownList1.DataValueField = "UrunID";
                DropDownList1.DataSource = olanUrunler;
                DropDownList1.DataBind();

                var olanPersoneller = (from x in db.Personeller select new { x.PersonelID, x.PersonelAdSoyad }).ToList();
                DropDownList2.DataTextField = "PersonelAdSoyad";
                DropDownList2.DataValueField = "PersonelID";
                DropDownList2.DataSource = olanPersoneller;
                DropDownList2.DataBind();

                var olanMusteriler = (from x in db.Musteriler select new { x.MusteriID, ADSOYAD = x.MusteriAd + " " + x.MusteriSoyad }).ToList();
                DropDownList3.DataTextField = "ADSOYAD";
                DropDownList3.DataValueField = "MusteriID";
                DropDownList3.DataSource = olanMusteriler;
                DropDownList3.DataBind();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Satislar satis = new Satislar();
            satis.Urun = int.Parse(DropDownList1.SelectedValue);
            satis.Musteri = int.Parse(DropDownList3.SelectedValue);
            satis.Personel = byte.Parse(DropDownList2.SelectedValue);
            satis.Fiyat = decimal.Parse(TextBoxFiyat.Text);
            db.Satislar.Add(satis);
            db.SaveChanges();
            Response.Redirect("SatisSayfasi.aspx");
        }
    }
}