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
    public partial class DersGirisForm : Form
    {
        public DersGirisForm()
        {
            InitializeComponent();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Ders (DersID, DersAdi, Kredi, OgretimUyesiID) VALUES (@id, @ad, @kredi, @ogretimid)", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtDersID.Text));
            komut.Parameters.AddWithValue("@ad", txtDersAdi.Text);
            komut.Parameters.AddWithValue("@kredi", Convert.ToInt32(txtKredi.Text));
            komut.Parameters.AddWithValue("@ogretimid", txtOgretimUyesi.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();
            MessageBox.Show("Ders başarıyla eklendi.");

        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (txtDersID.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek dersin ID'sini girin.");
                return;
            }

            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Ders SET DersAdi = @adi, Kredi = @kredi, OgretimUyesiID = @ogretimID WHERE DersID = @id", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtDersID.Text));
            komut.Parameters.AddWithValue("@adi", txtDersAdi.Text);
            komut.Parameters.AddWithValue("@kredi", Convert.ToInt32(txtKredi.Text));
            komut.Parameters.AddWithValue("@ogretimID", Convert.ToInt32(txtOgretimUyesi.Text));
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();

            MessageBox.Show("Ders bilgileri güncellendi.");
        }
    }
}
