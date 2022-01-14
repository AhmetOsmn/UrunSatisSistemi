using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using UrunSatisSistemi.Entity;
using System.Web.UI.WebControls;

namespace UrunSatisSistemi
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            USSEntities db = new USSEntities();
            Kategoriler kategoriler  = new Kategoriler();
            kategoriler.KategoriAd = TextBox1.Text;
            db.Kategoriler.Add(kategoriler);
            db.SaveChanges();
            Response.Redirect("KategoriSayfasi.aspx");
        }
    }
}