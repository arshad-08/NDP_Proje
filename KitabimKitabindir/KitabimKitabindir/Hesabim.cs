using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitabimKitabindir
{
    public partial class Hesabim : Form
    {
        SqlConnection conn = new SqlConnection(VeriTut.SQL_CONNECTION_STRING);//SQL Server ile bağlantı kurulur
        private void göster()
        {
            conn.Open();//Database açılır
            SqlCommand com = new SqlCommand("Select * from USERS", conn);
            //Sorgu metni ve bir SqlConnection ile SqlCommand sınıfının yeni bir örneğini başlatır.
            SqlDataReader oku = com.ExecuteReader();
            //Bu kayıtları okumak ve işlemek için veritabanından birden fazla kayıt alan bir sorgu iletilirken kullanılır.
            
            while (oku.Read())
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = oku["kitap"].ToString();
                liste.SubItems.Add(oku["ad"].ToString());
                liste.SubItems.Add(oku["tel"].ToString());
                liste.SubItems.Add(oku["eposta"].ToString());
                listView2.Items.Add(liste);
            }
            conn.Close();//Database kapanır
        }
        public Hesabim()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis1_Click(object sender, EventArgs e)
        {
            Application.Exit();// Bu uygulamayı kapanıır
        }

        private void btnYeniKitapEkle_Click(object sender, EventArgs e)
        {
            this.Hide();// Bu sayfayı kapat
            KitapEkle kitapEkle = new KitapEkle();// yeni tanımı
            kitapEkle.Show();//Kıtap Ekle sayfası gösterilir

        }

        private void Hesabim_Load(object sender, EventArgs e)
        {
            göster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";//Kitabın adı
            textBox2.Text = " ";//Eklenen kişinin adı
            textBox3.Text = " ";//Eklenen kişinin telefon numarası
            textBox4.Text = " ";//Eklenen kişinin E-postası

            for (int i = 0; i < listView2.Items.Count ; i++)
            {
                if (txtKitapArama.Text ==listView2.Items[i].SubItems[0].Text )
                {
                    textBox1.Text = listView2.Items[i].SubItems[0].Text;//textbox1 e listemizdeki kitap adı değerini yazdırıyoruz
                    textBox2.Text = listView2.Items[i].SubItems[1].Text;//textbox2 e listemizdeki kitapı ekleyen kişiyi yazdırıyoruz
                    textBox3.Text = listView2.Items[i].SubItems[2].Text;//textbox3 e listemizdeki kitapı ekleyen kişinin telefon numarasını yazdırıyoruz
                    textBox4.Text = listView2.Items[i].SubItems[3].Text;//textbox4 e listemizdeki kitapı ekleyen kişinin e-postasını yazdırıyoruz
                }
            }
        }
    }
}
