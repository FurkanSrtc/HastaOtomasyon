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
    public partial class Hastaekle : Form
    {
        public Hastaekle()
        {
            InitializeComponent();
        }
        KlinikDBEntities db = new KlinikDBEntities();
        private void Hastaekle_Load(object sender, EventArgs e)
        {
            btnGuncelle.Visible = false;
            bynSil.Visible = false;
            //Ekleme Güncelleme İşlemeri İçin Kullanılıcak.
            //datagridviewde Randevusonucları gözükücek.
            //hastalar tablosundan seçilen kişi güncelleme için veya ekleme işlem için kullanılacak.

            foreach (var item in db.RSTur.ToList().Select(y => y.T_AD))
            {
                listRSTur.Items.Add(item);
            }

            foreach (var item in db.Cinsiyet.Select(x => x.Cinsiyet1).ToList())
            {
                cmbCinsiyet.Items.Add(item);
            }

            //Kullanıcıya yeni kayıt ekleme izni.
            dataGridView1.AllowUserToAddRows = true;
            //Kullanıcıya kayıt silme izni.
            dataGridView1.AllowUserToDeleteRows = true;
            //Veriye tıklandığında satır seçimi sağlama.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridYenile();

        }

        private void DataGridYenile()
        {
            var data = from d in db.Hasta.Where(d => d.H_DURUM == true).OrderBy(d => d.H_AD)
                       select new
                       {
                           Id = d.H_ID,
                           Ad = d.H_AD,
                           Soyad = d.H_SOYAD,
                           TC = d.H_TC,
                           Telefon = d.H_TEL,
                           DogumTarihi = d.H_DTARIH,
                           EMail = d.H_EMAIL,
                           Adres = d.H_ADRES,
                           Cinsiyet = d.Cinsiyet.Cinsiyet1
                       };

            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        Boolean yeniKayit = false;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
            btnEkle.Visible = true;
            if (yeniKayit == false)
            {
                Yenile();
                btnEkle.Text = "Kaydet";
                btnGuncelle.Visible = false;
                bynSil.Visible = false;
                yeniKayit = true;
            }
            else
            {
                try
                {
                    Hasta yeniHasta = new Hasta();
                    yeniHasta.H_CID = Convert.ToByte(cmbCinsiyet.SelectedIndex);
                    yeniHasta.H_AD = txtAd.Text;
                    yeniHasta.H_SOYAD = txtSoyad.Text;
                    yeniHasta.H_EMAIL = txtEmail.Text;
                    yeniHasta.H_ADRES = txtAdres.Text;
                    yeniHasta.H_DTARIH = dateTimeDogumTarihi.Value;
                    yeniHasta.H_DURUM = true;
                    yeniHasta.H_TC = txtTC.Text;
                    yeniHasta.H_TEL = txtTel.Text;

                    db.Hasta.Add(yeniHasta);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Hasta Kayıt Edildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Yenile();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hasta Kayıt Edilemedi !! Veri Girişlerini Kontrol Edin", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Veritabanına Ulaşılamıyor. Ağ Bağlantınızı Kontrol Edin ve Verileri Düzgün girdiğinizden emin olun", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
         


        }

        private void Yenile()
        {
            txtAd.Text="";
            txtAdres.Text="";
            txtEmail.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTel.Text = "";
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

           
      

        }
     
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            yeniKayit = false;
                Yenile();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString();
                txtTC.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value?.ToString();
        
                string date = "";
                date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value).ToShortDateString();

                dateTimeDogumTarihi.Value = Convert.ToDateTime(date);
          
       
            txtEmail.Text = dataGridView1.CurrentRow.Cells[6].Value?.ToString();
          txtAdres.Text= dataGridView1.CurrentRow.Cells[7].Value?.ToString();
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString()=="Erkek")
                cmbCinsiyet.SelectedIndex=0;
            else if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Kadın")
                cmbCinsiyet.SelectedIndex = 1;
            else
                cmbCinsiyet.SelectedIndex = 2;

            btnEkle.Text = "Yeni Hasta";
            btnGuncelle.Visible = true;
            bynSil.Visible = true;
            //-----------------------------------------------------------------------------------------
            int hastaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            //List<RSonuc> RSTurList = db.RSonuc.Where(x => x.Randevu.R_HASTAID == hastaId ).ToList();

            //    foreach (var item in RSTurList) //Adama ait kaç tane RSTur var
         

       



        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int hastaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           Hasta yeniHasta= db.Hasta.Find(hastaId);
         
        
            DialogResult dg = MessageBox.Show(yeniHasta.H_AD + " " + yeniHasta.H_SOYAD + " İsimli Hastanın Bilgilerini Güncellemek İstediğinize Emin Misiniz ?", "Hasta Güncelleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dg)
            {


                case DialogResult.Yes:

                    yeniHasta.H_CID = Convert.ToByte(cmbCinsiyet.SelectedIndex);
                    yeniHasta.H_AD = txtAd.Text;
                    yeniHasta.H_SOYAD = txtSoyad.Text;
                    yeniHasta.H_EMAIL = txtEmail.Text;
                    yeniHasta.H_ADRES = txtAdres.Text;
                    yeniHasta.H_DTARIH = dateTimeDogumTarihi.Value;
                    yeniHasta.H_DURUM = true;
                    yeniHasta.H_TC = txtTC.Text;
                    yeniHasta.H_TEL = txtTel.Text;
                    db.SaveChanges();
                    DataGridYenile();

                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    ContextMenu m = new ContextMenu();
            //    m.MenuItems.Add(new MenuItem("Cut"));
            //    m.MenuItems.Add(new MenuItem("Copy"));
            //    m.MenuItems.Add(new MenuItem("Paste"));

            //    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            //    if (currentMouseOverRow >= 0)
            //    {
            //        m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
            //    }

            //    m.Show(dataGridView1, new Point(e.X, e.Y));

            //}
        }

        private void ListRSTur_MouseClick(object sender, MouseEventArgs e)
        {

            // Creating and setting  
            // properties of the GroupBox 

            int hastaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in db.RSonuc.Where(x=>x.Randevu.R_HASTAID==hastaId && x.S_TURID==listRSTur.SelectedIndex).ToList())
            {

                //GroupBox box = new GroupBox();

                //box.Size = new Size(329, 94);
                //box.Text = "a";
                //box.Name = "GBox" + item.S_ID;

                //this.flowLayoutPanel1.Controls.Add(box);

                TextBox a = new TextBox();
                a.Text = item.S_ACIKLAMA;
                a.Height = 140;
                a.Width = 340;
                a.Name = "txt" + item.S_ID;
                a.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                a.Multiline = true;
                flowLayoutPanel1.Controls.Add(a);

                Button b = new Button();
                b.Text = "Daha Fazla";
                b.Name =  item.S_ID.ToString();
                b.Height = 140;
                b.Width = 70;
                b.Click += new EventHandler(button_Click);


                flowLayoutPanel1.Controls.Add(b);

              
            }

          

        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            RandevuSonuc randevuSonuc = new RandevuSonuc(button.Name);
            randevuSonuc.Show();
            this.Hide();

         
        }

        private void BynSil_Click(object sender, EventArgs e)
        {
            int hastaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
         
            Hasta hastaSil = db.Hasta.Find(hastaId);
           DialogResult dg= MessageBox.Show(hastaSil.H_AD+ " " + hastaSil.H_SOYAD+" İsimli Hastayı Silmek İstediğinize Emin Misiniz ?","Hasta Silme Ekranı",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dg)
            {
             
           
                case DialogResult.Yes:
                    hastaSil.H_DURUM = false;
                    db.SaveChanges();
                    DataGridYenile();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
          
        }
    }
}
