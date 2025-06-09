using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteOtomasyon
{
    public partial class AnaMenuForm : Form
    {
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void btnOgrenciForm_Click(object sender, EventArgs e)
        {
            OgrenciForm f = new OgrenciForm();
            f.Show();
        }

        private void btnOgretimForm_Click(object sender, EventArgs e)
        {
            OgretimUyesiForm  o = new OgretimUyesiForm();
            o.Show();
        }

        private void btnDersForm_Click(object sender, EventArgs e)
        {
            DersGirisForm d = new DersGirisForm();
            d.Show();
        }

        private void btnNotForm_Click(object sender, EventArgs e)
        {
            NotGirisForm n = new NotGirisForm();    
            n.Show();
        }
    }
}
