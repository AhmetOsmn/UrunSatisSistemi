using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    
    public partial class MusteriSayfasi : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var olanMusteriler = db.Musteriler.ToList();
                Repeater1.DataSource = olanMusteriler;
                Repeater1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.MusteriAd = TextBox1.Text;
            musteri.MusteriSoyad = TextBox2.Text;
            db.Musteriler.Add(musteri);
            db.SaveChanges();
            Response.Redirect("MusteriSayfasi.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}