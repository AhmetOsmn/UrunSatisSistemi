using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            USSEntities db = new USSEntities();
            int id = Convert.ToInt32(Request.QueryString["KategoriID"]);
            var arananKategori = db.Kategoriler.Find(id);
            db.Kategoriler.Remove(arananKategori);
            db.SaveChanges();
            Response.Redirect("KategoriSayfasi.aspx");

        }
    }
}