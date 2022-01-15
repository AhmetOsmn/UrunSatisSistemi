using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    public partial class SatisSayfasi : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var yapilanSatislar = db.Satislar.ToList();
            var yapilanSatislar = (from x in db.Satislar
                                   select new
                                   {
                                       x.SatisID,
                                       x.Urunler.UrunAd,
                                       x.Personeller.PersonelAdSoyad,
                                       MUSTERI = x.Musteriler.MusteriAd+ " " + x.Musteriler.MusteriSoyad,
                                       x.Fiyat
                                   }).ToList();
            Repeater1.DataSource = yapilanSatislar;
            Repeater1.DataBind();
        }
    }
}