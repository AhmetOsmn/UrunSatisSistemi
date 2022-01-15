using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    public partial class Istatistikler : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Urunler.Count().ToString();
            Label2.Text = db.Musteriler.Count().ToString();
            Label3.Text = db.Satislar.Sum(x => x.Fiyat).ToString();
            Label4.Text = db.Kategoriler.Count().ToString();
            Label5.Text = db.Urunler.Count(x => x.Durum == true).ToString();
            Label6.Text = db.Urunler.Count(x => x.Durum == false).ToString();
            Label7.Text = (from x in db.Urunler orderby x.UrunStok descending select x.UrunAd).FirstOrDefault();

            var data = db.Urunler.Where(w => w.Durum == true).GroupBy(u => u.UrunKategori).Select(u => new { u.FirstOrDefault().Kategoriler.KategoriAd, adet = u.Count() }).OrderByDescending(o => o.adet).Take(1).ToList();

            Label8.Text = (from item in data select item.KategoriAd).FirstOrDefault();
        }
    }
}