using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunSatisSistemi.Entity;

namespace UrunSatisSistemi
{
    public partial class Login : System.Web.UI.Page
    {
        USSEntities db = new USSEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Adminler where x.Kullanici == TextBoxKullaniciAdi.Text && x.Sifre == TextBoxSifre.Text select x;
            if (sorgu .Any())
            {
                Response.Redirect("~/Musteri/MusteriSayfasi.aspx");
            }
            else
            {
                TextBoxSifre.Text = "kullanıcı adı veya şifre hatalı";
            }
        }
    }
}