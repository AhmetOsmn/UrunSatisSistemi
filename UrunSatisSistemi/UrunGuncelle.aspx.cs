using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["UrunID"]);
                
                var arananUrun = db.Urunler.Find(id);

                var varOlanKategoriler = (from x in db.Kategoriler select new { x.KategoriID, x.KategoriAd }).ToList();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = varOlanKategoriler;
                DropDownList1.DataBind();

                TextBoxUrunAd.Text = arananUrun.UrunAd;
                TextBoxMarka.Text = arananUrun.UrunMarka;
                TextBoxStok.Text = arananUrun.UrunStok.ToString();
                TextBoxFiyat.Text = arananUrun.UrunFiyat.ToString();

                DropDownList1.SelectedValue = arananUrun.UrunKategori.ToString();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["UrunID"]);
            var arananUrun = db.Urunler.Find(id);

            arananUrun.UrunAd = TextBoxUrunAd.Text;
            arananUrun.UrunMarka = TextBoxMarka.Text;
            arananUrun.UrunKategori = byte.Parse(DropDownList1.SelectedValue.ToString());
            arananUrun.UrunFiyat = decimal.Parse(TextBoxFiyat.Text);
            arananUrun.UrunStok = short.Parse(TextBoxStok.Text);

            db.SaveChanges();
            Response.Redirect("UrunSayfasi.aspx");
        }
    }
}