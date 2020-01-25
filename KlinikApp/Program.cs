using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hastaekle());
        }
    }
}

/*
Login - Giriş Sayfası (db kontrol, diğer formlarda giriş yapan kişinin pozisyon bilgisi tutulcak ve ona göre aktarma yapıcak.)
Yetkilş Paneli - Yönlendirme Sayfası(yapıcağı işlemi seçebilicek. kendi panelini görüp takip yapabilecek)
Yetkisiz Paneli - Yönlendirme Sayfası(yapacağı işlemi seçebilecek. kendi panelini görüp takip yapabilecek)
Hasta - Hasta Bilgileri Sayfası(Hasta bilgilerini çekicek. eğer çeken kişi yetkiliyse randevu sonuc bilgilerinide çekicek)
Randevu - Randevu Bilgileri Sayfası(Randevuları çekicek)
Seans - Randevu Anında Açık Olan Sayfa(sadece yetkili kişi girebilecek. randevu ile ilgili işlemler yapılcak)
EkleveGuncelle - Hasta veya Randevu Ekleme veya Guncelleme Sayfası





    login
    main
    seans
    randevu
    hasta
    hastabilgi

    hastaekle
    randevuekle

    

*/
