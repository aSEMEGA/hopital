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

namespace hopital
{
    
    public partial class Form2 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-KN4EBP5\\SQLEXPRESS;Initial Catalog=hopitaldb;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAdresse.Text == "" || PatAge.Text == "" || PatPhone.Text == "" || PatGenre.Text == "" || PatSang.Text == "" || PatMaladie.Text == "")
            {
                MessageBox.Show("Pas de remplissage vide accepter");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into PatientTbl values(@PatId,@PatName,@PatAdresse,@PatPhone,@PatAge,@PatGenre,@PatSang,@PatMaladie)",Con);
                cmd.Parameters.AddWithValue("@PatId", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@PatName", textBox2.Text);
                cmd.Parameters.AddWithValue("@PatAdresse", textBox3.Text);
                cmd.Parameters.AddWithValue("@PatPhone", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@PatAge", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@PatGenre", PatGenre.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatSang", PatSang.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatMaladie", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout du Patient avec succès");
                Con.Close();
                populate();
            }
        }

        private void MODIFIER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update PatientTbl set PatName = @PatName, PatAdresse = @PatAdresse, PatPhone = @PatPhone, PatAge = @PatAge, PatGenre = @PatGenre, Patsang = @PatSang, PatMaladie = @PatMaladie where PatId = @PatId",Con);
            cmd.Parameters.AddWithValue("@PatId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PatName", textBox2.Text);
            cmd.Parameters.AddWithValue("@PatAdresse", textBox3.Text);
            cmd.Parameters.AddWithValue("@PatPhone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@PatAge", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@PatGenre", PatGenre.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PatSang", PatSang.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PatMaladie", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modifier avec succès");
            Con.Close();
            populate();
        }

        private void SUPPRIMER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("delete PatientTbl where PatId = @PatId",Con);
            cmd.Parameters.AddWithValue("@PatId", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modifier avec succès");
            Con.Close();
            populate();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
