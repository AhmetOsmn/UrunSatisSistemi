using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    public partial class UrunSil : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["UrunID"]);
            var arananUrun = db.Urunler.Find(id);
            arananUrun.Durum = false;
            db.SaveChanges();
            Response.Redirect("UrunSayfasi.aspx");
        }
    }
}