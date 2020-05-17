using System;
using System.Windows.Forms;

/*************************************************************************  **
 *                        SAKARYA ÜNİVERSİTESİ                              **
 *               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  **
 *                BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                    **
 *                  NESNEYE DAYALI PROGRAMLAMA DERSİ                        **
 *                       2019-2020 BAHAR DÖNEMİ                             **
 *                                                                          **
 *                    PROJE NUMARASI.........: Tassarım                     **
 *                    ÖĞRENCİ ADI............: Arshad Amir Monsur           **
 *                    ÖĞRENCİ NUMARASI.......: B171200555                   **
 *                    DERSİN ALINDIĞI GRUP...:  A                           **
 * 
 * ****************************************************************************/
namespace KitabimKitabindir
{

    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();// Bu sayfayı kapat
            YeniHesap yeniHesap = new YeniHesap();//yeni tanımı 
            yeniHesap.Show();//Yeni Hesap sayfası açılır

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();// Bu sayfayı kapat
            Giris giris = new Giris();//yeni tanımı
            giris.Show();//Giriş sayfası açılır
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
