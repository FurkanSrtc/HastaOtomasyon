using KlinikApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikApp
{
    public partial class RandevuSonuc : Form
    {

        RSonuc rs;
        public RandevuSonuc(string r)
        {
            KlinikDBEntities db = new KlinikDBEntities();
            int rsonucId = Convert.ToInt32(r);
             rs = db.RSonuc.Where(x => x.S_ID == rsonucId).FirstOrDefault();


            InitializeComponent();
        }

        private void RandevuSonuc_Load(object sender, EventArgs e)
        {
            txtHastaAdSoyad.Text=rs.Randevu.Hasta.H_AD+" "+rs.Randevu.Hasta.H_SOYAD;
            txtPersonelAdSoyad.Text = rs.Randevu.Personel.P_AD+" "+rs.Randevu.Personel.P_SOYAD;
            txtAldigiHizmet.Text = rs.Randevu.Hizmet.H_AD;
            txtHastaBilgiTuru.Text = rs.RSTur.T_AD;
            txt_HastaBilgisi.Text = rs.S_ACIKLAMA;
            txt_randAciklamasi.Text = rs.Randevu.R_ACIKLAMA;

            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            DateTime randTarih = Convert.ToDateTime(rs.Randevu.R_TARIH);
            dateTimePicker1.Value = randTarih;
        


        }
    }
}
