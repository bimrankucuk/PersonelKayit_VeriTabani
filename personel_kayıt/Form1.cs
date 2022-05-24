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

namespace personel_kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HOMUJP6;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
       
        void temizle1()
        {
            perad.Text = "";
            persoyad.Text = "";
            persehir.Text = "";
            permaas.Text = "";
            permeslek.Text = "";
            perevli.Checked = false;
            perbekar.Checked = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void listele_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet4.Table_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet4.Table_1);

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_1 (perad,persoyad,persehir,permaas,permeslek,perdurum)values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", perad.Text);
            komut.Parameters.AddWithValue("@p2", persoyad.Text);
            komut.Parameters.AddWithValue("@p3", persehir.Text);
            komut.Parameters.AddWithValue("@p4", permaas.Text);
            komut.Parameters.AddWithValue("@p5", permeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void perevli_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "1";
        }

        private void perbekar_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "0";

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            temizle1();
        }
    }
}
