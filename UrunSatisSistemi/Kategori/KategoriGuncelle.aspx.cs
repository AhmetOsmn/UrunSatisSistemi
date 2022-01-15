using System;
using System.Collections.Generic;
using System.Linq;
using UrunSatisSistemi.Entity;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrunSatisSistemi
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack ==false)
            {
                int id = Convert.ToInt32(Request.QueryString["KategoriID"]);
                TextBox1.Text = id.ToString();

                var arananKategori = db.Kategoriler.Find(id);
                TextBox2.Text = arananKategori.KategoriAd;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KategoriID"]);
            var arananKategori = db.Kategoriler.Find(id);
            arananKategori.KategoriAd = TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("KategoriSayfasi.aspx");
        }
    }
}