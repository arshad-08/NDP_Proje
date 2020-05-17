using System;
using System.Data.SqlClient;// SQL Server visuala getirir
using System.Windows.Forms;


namespace KitabimKitabindir
{
    public partial class Giris : Form
    {
        SqlConnection con = new SqlConnection(VeriTut.SQL_CONNECTION_STRING );//SQL Server ile bağlanır
        public Giris()
        {
            InitializeComponent();
        }

        private void göster()
        {
            con.Open();//Database açılır
            SqlCommand com = new SqlCommand("Select * from USERS",con);
            //Sorgu metni ve bir SqlConnection ile SqlCommand sınıfının yeni bir örneğini başlatır.
            SqlDataReader oku = com.ExecuteReader();
            //Bu kayıtları okumak ve işlemek için veritabanından birden fazla kayıt alan bir sorgu iletilirken kullanılır.
            while (oku.Read())
            {
                ListViewItem liste = new ListViewItem();//yeni tanım listesi
                liste.Text = oku["kullaniciad"].ToString(); //kullanıcı adını yazılır
                liste.SubItems.Add(oku["sifre"].ToString());//kullanıcı şifre yazılır
                liste.SubItems.Add(oku["tc"].ToString());//kullanıcı T.C yazılır
                listView1.Items.Add(liste);
            }
            con.Close();//Database kapanır
        }
        public static string kullaniciad, sifre,tc;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            göster();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == txtUser.Text || listView1.Items[i].SubItems[1].Text ==txtPassword.Text )
                    //Kullanıcı adı ve sifre listviewimizdeki değerler ile eşleşirse gerekli yönlendirmeyi yapıyoruz
                {
                    kullaniciad = listView1.Items[i].SubItems[0].Text;//kullaniciad değişkenine listview1 deki olması gerekn değeri atıyoruz
                    sifre = listView1.Items[i].SubItems[1].Text;//sifre değişkenine listview1 deki olması gerekn değeri atıyoruz
                    tc = listView1.Items[i].SubItems[2].Text;//tc değişkenine listview1 deki olması gerekn değeri atıyoruz
                    Hesabim hesabim = new Hesabim();  
                    hesabim.Show();//Hesap sayfası açılır
                    this.Hide();//Bu sayfayı kapanır
                }
                
               
                  
            }
        }

        private void linkSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();// Bu sayfayı kapat
            YeniSifre yeniSifre = new YeniSifre();//yeni tanımı
            yeniSifre.Show();//Yeni şifre sayfası açılır
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();// Bu sayfayı kapanır
            YeniHesap yeniHesap = new YeniHesap();
            yeniHesap.Show();//Yeni Hesap sayfası açılır
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

