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
    public partial class Form3 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-KN4EBP5\\SQLEXPRESS;Initial Catalog=hopitaldb;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        void populatecombo()
        {

            SqlCommand cmd = new SqlCommand("select* from PatientTbl", Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                IDPATIENT.ValueMember = "PatId";
                IDPATIENT.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }

        }
        string patname;
        void fecthpatientname()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("select * from Patienttbl where PatId = @IDPATIENT", Con);
            cmd.Parameters.AddWithValue("@IDPATIENT", IDPATIENT.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                NomP.Text = patname;
            }
            Con.Close();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosticTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dianoGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void AJOUTER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into DiagnosticTbl values(@IID,@IDPATIENT,@NomP,@SymP,@Diano,@Medi)",Con);
            cmd.Parameters.AddWithValue("@IID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@IDPATIENT", IDPATIENT.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@NomP", NomP.Text);
            cmd.Parameters.AddWithValue("@SymP", textBox2.Text);
            cmd.Parameters.AddWithValue("@Diano", textBox3.Text);
            cmd.Parameters.AddWithValue("@Medi", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajout du Dianostic avec succès");
            Con.Close();
            populate();
        }

        private void MODIFIER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("update DiagnosticTbl set PatId = @IDPATIENT, PatName = @NomP, Symptome = @SymP, Dianostic = @Diano, Medicament = @Medi where DiagId = @IID", Con);
            cmd.Parameters.AddWithValue("@IID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@IDPATIENT", IDPATIENT.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@NomP", NomP.Text);
            cmd.Parameters.AddWithValue("@SymP", textBox2.Text);
            cmd.Parameters.AddWithValue("@Diano", textBox3.Text);
            cmd.Parameters.AddWithValue("@Medi", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modifier avec succès");
            Con.Close();
            populate();
        }

        private void SUPPRIMER_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("delete DiagnosticTbl where PatId = @IDPATIENT", Con);
            cmd.Parameters.AddWithValue("@IDPATIENT", IDPATIENT.SelectedValue.ToString());
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

        private void Form3_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void IDPATIENT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthpatientname();
        }
    }
}
