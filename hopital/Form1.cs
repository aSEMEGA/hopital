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
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-KN4EBP5\\SQLEXPRESS;Initial Catalog=hopitaldb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DocteurGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
            {
                MessageBox.Show("Pas de remplissage vide accepter");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into DoctorTbl values(@DocId,@DocName,@DocExp,@DocPass)",Con);
                cmd.Parameters.AddWithValue("@DocId", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@DocName", textBox2.Text);
                cmd.Parameters.AddWithValue("@DocExp", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@DocPass", int.Parse(textBox4.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout avec succès");
                Con.Close();
                populate();
            }
        }

        private void MODIFIER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update DoctorTbl set DocName = @DocName, DocExp = @DocExp, DocPass = @DocPass where DocId = @DocId", Con);
            cmd.Parameters.AddWithValue("@DocId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@DocName", textBox2.Text);
            cmd.Parameters.AddWithValue("@DocExp", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@DocPass", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modifier avec succès");
            Con.Close();
            populate();
        }

        private void SUPPRIMER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("delete DoctorTbl where DocId = @DocId", Con);
            cmd.Parameters.AddWithValue("@DocId", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer avec succès");
            Con.Close();
            populate();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
