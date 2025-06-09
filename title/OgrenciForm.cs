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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try { 
            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Ogrenci (OgrenciID, AdSoyad, Sinif, Bolum) VALUES (@id, @ad, @sinif, @bolum)", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtOgrenciID.Text));
            komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@sinif", txtSinif.Text);
            komut.Parameters.AddWithValue("@bolum", txtBolum.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();
            MessageBox.Show("Öğrenci başarıyla eklendi.");
        }
            catch (Exception ex) {

                MessageBox.Show("HATA: " + ex.Message);
                Veritabani.Baglanti.Close();
            }
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOgrenciID.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek öğrencinin ID'sini girin.");
                return;
            }
             

            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Ogrenci SET AdSoyad = @ad, Bolum = @bolum, Sinif = @sinif WHERE OgrenciID = @id", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtOgrenciID.Text));
            komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@bolum", txtBolum.Text);
            komut.Parameters.AddWithValue("@sinif", txtSinif.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();

            MessageBox.Show("Öğrenci bilgileri güncellendi.");
            
        }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
                Veritabani.Baglanti.Close();
            }
        }

    }
}

