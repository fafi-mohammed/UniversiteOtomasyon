using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UniversiteOtomasyon.Program;

namespace UniversiteOtomasyon
{
    public partial class NotGirisForm : Form
    {
        public NotGirisForm()
        {
            InitializeComponent();
        }

        private void NotGirisForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daOgrenci = new SqlDataAdapter("SELECT OgrenciID, AdSoyad FROM Ogrenci", Veritabani.Baglanti);
            DataTable dtOgrenci = new DataTable();
            daOgrenci.Fill(dtOgrenci);
            cmbOgrenciId.DataSource = dtOgrenci;
            cmbOgrenciId.DisplayMember = "AdSoyad";
            cmbOgrenciId.ValueMember = "OgrenciID";
            cmbOgrenciId.SelectedIndex = -1;

            // Ders ComboBox doldurma
            SqlDataAdapter daDers = new SqlDataAdapter("SELECT DersID, DersAdi FROM Ders", Veritabani.Baglanti);
            DataTable dtDers = new DataTable();
            daDers.Fill(dtDers);
            cmbDersId.DataSource = dtDers;
            cmbDersId.DisplayMember = "DersAdi";
            cmbDersId.ValueMember = "DersID";
            cmbDersId.SelectedIndex = -1;
        }
   
    

        private void HesaplaOrtalama()
        {
            if (double.TryParse(txtVize.Text, out double vize) &&
                double.TryParse(txtFinal.Text, out double final))
            {
                double ort = (vize * 0.4) + (final * 0.6);
                txtOrtalama.Text = ort.ToString("0.00");
            }
        }

        private void txtVize_TextChanged(object sender, EventArgs e)
        {
            HesaplaOrtalama();
        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {
            HesaplaOrtalama();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciId.SelectedIndex == -1 || cmbDersId.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen öğrenci ve ders seçiniz.");
                return;
            }

            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Kayitlar (OgrenciID, DersID, Vize, Final, Ortalama) VALUES (@ogrID, @dersID, @vize, @final, @ortalama)", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@ogrID", cmbOgrenciId.SelectedValue);
            komut.Parameters.AddWithValue("@dersID", cmbDersId.SelectedValue);
            komut.Parameters.AddWithValue("@vize", Convert.ToDouble(txtVize.Text));
            komut.Parameters.AddWithValue("@final", Convert.ToDouble(txtFinal.Text));
            komut.Parameters.AddWithValue("@ortalama", Convert.ToDouble(txtOrtalama.Text));
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();

            MessageBox.Show("Kayıt başarıyla eklendi.");
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciId.SelectedIndex == -1 || cmbDersId.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen öğrenci ve ders seçiniz.");
                return;
            }

            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Kayitlar SET Vize=@vize, Final=@final, Ortalama=@ortalama WHERE OgrenciID=@ogrID AND DersID=@dersID", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@vize", Convert.ToDouble(txtVize.Text));
            komut.Parameters.AddWithValue("@final", Convert.ToDouble(txtFinal.Text));
            komut.Parameters.AddWithValue("@ortalama", Convert.ToDouble(txtOrtalama.Text));
            komut.Parameters.AddWithValue("@ogrID", cmbOgrenciId.SelectedValue);
            komut.Parameters.AddWithValue("@dersID", cmbDersId.SelectedValue);
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();

            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }
    }
}
