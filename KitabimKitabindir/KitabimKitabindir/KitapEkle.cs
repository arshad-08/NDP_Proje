using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KitabimKitabindir
{
    public partial class KitapEkle : Form
    {
        SqlConnection conn = new SqlConnection(VeriTut.SQL_CONNECTION_STRING);//Sql Server ile bağlantı kurulur
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void btnCikis2_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamayı kapanır
        }
        private void kitapekle()
        {
            conn.Open();//Database açılır
            SqlCommand comm = new SqlCommand("Update USERS set kitap=@kitapad where tc=@tc", conn);
            //Sorgu metni ve bir SqlConnection ile SqlCommand sınıfının yeni bir örneğini başlatır.
            comm.Parameters.AddWithValue("kitapad", txtKitap.Text);
            comm.Parameters.AddWithValue("tc", Giris.tc);
            comm.ExecuteNonQuery();//Bu sorgu Veritabanından döndürülen veri kalmaması için Ekle öğelerinden verileri değiştirmek için kullanılır.
            conn.Close();//database kapanır
        }
        private void linkGeriDon1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//Bu sayfa kapanır
            Hesabim hesabim = new Hesabim();//yenı tanımı
            hesabim.Show();//Hesap sayfası açılır
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKitap.Text))
              // bu kod boş bırakılmaması için kullandım kitap Adı yazmak zorunda bırakacaktır
            {
                MessageBox.Show("Kitabın adını giriniz !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //bu kod boş olursa bu mesajı gösterilir
                txtKitap.Focus();
                return;
            }
            kitapekle();//kitap eklenır
            MessageBox.Show("Kıtap eklendi");
        }

        private void txtKitap_TextChanged(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
