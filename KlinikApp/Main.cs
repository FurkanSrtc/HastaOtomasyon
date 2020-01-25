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
    public partial class Main : Form
    {
        byte personelPozisyon;
        public Main(byte? p)
        {
            personelPozisyon = Convert.ToByte(p);
            InitializeComponent();
        }

        //datagridview right click menu ile silme, güncelleme ve seans başlatma işlemleri.
        //seans başlattığı zaman o randevu ile iglili seans kısmı açılıcak.

        private void Main_Load(object sender, EventArgs e)
        {
            if (personelPozisyon == 2) // Üye Girişi Yapan Kişi Danışman İse
            {

            }
            // yetkili biri değilse bu çalışıcak topMenu.Items[0].Visible = false;
            Invisible();
        }

        private void Invisible()
        {
            dataCombo.Visible = false;
            dataDate.Visible = false;
            dataTxt.Visible = false;
            araBtn.Visible = false;
        }

        private void araTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (araTxt.SelectedItem.ToString())
            {
                case "Tümü":
                    Invisible();
                    break;
                case "Hastanın Adı":
                    Invisible();
                    dataTxt.Visible = true;
                    araBtn.Visible = true;
                    
                    break;
                case "Personel Adı":
                    Invisible();
                    dataTxt.Visible = true;
                    araBtn.Visible = true;
                    break;
                case "Randevu Durumu":
                    Invisible();
                    dataCombo.Visible = true;
                    araBtn.Visible = true;
                    break;
                case "Randevu Tarihi":
                    Invisible();
                    dataDate.Visible = true;
                    araBtn.Visible = true;
                    break;
                case "Randevu Hizmeti":
                    Invisible();
                    dataCombo.Visible = true;
                    araBtn.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            //randevuData.DataSource = ""; çekilen veriye göre datayı güncelleme.
            switch (araTxt.SelectedItem.ToString())
            {
                case "Hastanın Adı":
                    Invisible();
                    dataTxt.Visible = true;
                    araBtn.Visible = true;

                    break;
                case "Personel Adı":
                    Invisible();
                    dataTxt.Visible = true;
                    araBtn.Visible = true;
                    break;
                case "Randevu Durumu":
                    Invisible();
                    dataCombo.Visible = true;
                    araBtn.Visible = true;
                    break;
                case "Randevu Tarihi":
                    Invisible();
                    dataDate.Visible = true;
                    araBtn.Visible = true;
                    break;
                case "Randevu Hizmeti":
                    Invisible();
                    dataCombo.Visible = true;
                    araBtn.Visible = true;
                    break;
                default:
                    break;
            }

        }


    }
}
