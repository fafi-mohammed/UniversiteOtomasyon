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
    public partial class OgretimUyesiForm : Form
    {
        public OgretimUyesiForm()
        {
            InitializeComponent();
        }

        private void btnOgretimEkle_Click(object sender, EventArgs e)
        {
         
            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO OgretimUyesi (OgretimUyesiID, AdSoyad, Unvan) VALUES (@id, @ad, @unvan)", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtOgretimUyesiID.Text));
            komut.Parameters.AddWithValue("@ad", txtOgAdSoyad.Text);
            komut.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();
            MessageBox.Show("Öğretim üyesi başarıyla eklendi.");
        }

        private void btnOgretimGuncelle_Click(object sender, EventArgs e)
        {
         
            if (txtOgretimUyesiID.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek öğretim üyesinin ID'sini girin.");
                return;
            }

            Veritabani.Baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE OgretimUyesi SET AdSoyad = @ad, Unvan = @unvan WHERE OgretimUyesiID = @id", Veritabani.Baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtOgretimUyesiID.Text));
            komut.Parameters.AddWithValue("@ad", txtOgAdSoyad.Text);
            komut.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            komut.ExecuteNonQuery();
            Veritabani.Baglanti.Close();

            MessageBox.Show("Öğretim üyesi bilgileri güncellendi.");
        }

    }
}


