using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;
namespace UrunSatisSistemi.Urun
{
    public partial class UrunSayfasi : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.Urunler.Where(x => x.Durum == true).ToList();
            var urunler = (from x in db.Urunler where x.Durum == true
                            select new 
                            {
                                x.UrunID,
                                x.UrunAd,
                                x.UrunMarka,
                                x.Kategoriler.KategoriAd,
                                x.UrunFiyat,
                                x.UrunStok,
                            }).ToList();
                          

            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}