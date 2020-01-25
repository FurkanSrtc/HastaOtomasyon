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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (cboxBeniHatirla.Checked)
             Properties.Settings.Default["mailadres"] = txtMail.Text;
            
            else
             Properties.Settings.Default[""] = txtMail.Text;

            Properties.Settings.Default.Save();

            KlinikDBEntities db = new KlinikDBEntities();
            Personel personel = db.Personel.Where(x => x.P_EMAIL == txtMail.Text && x.P_SIFRE == txtSifre.Text).FirstOrDefault();

            if (personel != null)
            {
                Main m = new Main(personel.P_POZISYONID);
                m.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtMail.Text = Properties.Settings.Default["mailadres"].ToString();
            if (txtMail.Text.Count() >= 1)
                cboxBeniHatirla.Checked = true;

        }


    }
}
