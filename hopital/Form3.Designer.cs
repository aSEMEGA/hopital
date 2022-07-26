
namespace hopital
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IDPATIENT = new System.Windows.Forms.ComboBox();
            this.NomP = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SymP = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Diano = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Medi = new System.Windows.Forms.Label();
            this.dianoGV = new System.Windows.Forms.DataGridView();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.MODIFIER = new System.Windows.Forms.Button();
            this.SUPPRIMER = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dianoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYETEME DE GESTION D\'HOPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(349, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnostic";
            // 
            // IDD
            // 
            this.IDD.AutoSize = true;
            this.IDD.BackColor = System.Drawing.Color.Green;
            this.IDD.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IDD.Location = new System.Drawing.Point(12, 114);
            this.IDD.Name = "IDD";
            this.IDD.Size = new System.Drawing.Size(278, 35);
            this.IDD.TabIndex = 1;
            this.IDD.Text = "ID du Diagnostic";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 39);
            this.textBox1.TabIndex = 2;
            // 
            // IDPATIENT
            // 
            this.IDPATIENT.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPATIENT.FormattingEnabled = true;
            this.IDPATIENT.Location = new System.Drawing.Point(18, 199);
            this.IDPATIENT.Name = "IDPATIENT";
            this.IDPATIENT.Size = new System.Drawing.Size(272, 34);
            this.IDPATIENT.TabIndex = 3;
            this.IDPATIENT.Text = "ID du Patient";
            this.IDPATIENT.SelectionChangeCommitted += new System.EventHandler(this.IDPATIENT_SelectionChangeCommitted);
            // 
            // NomP
            // 
            this.NomP.AutoSize = true;
            this.NomP.BackColor = System.Drawing.Color.Green;
            this.NomP.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NomP.Location = new System.Drawing.Point(12, 248);
            this.NomP.Name = "NomP";
            this.NomP.Size = new System.Drawing.Size(261, 35);
            this.NomP.TabIndex = 4;
            this.NomP.Text = "Nom du Patient";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 39);
            this.textBox2.TabIndex = 6;
            // 
            // SymP
            // 
            this.SymP.AutoSize = true;
            this.SymP.BackColor = System.Drawing.Color.Green;
            this.SymP.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SymP.Location = new System.Drawing.Point(12, 295);
            this.SymP.Name = "SymP";
            this.SymP.Size = new System.Drawing.Size(178, 35);
            this.SymP.TabIndex = 5;
            this.SymP.Text = "Symptome";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 39);
            this.textBox3.TabIndex = 8;
            // 
            // Diano
            // 
            this.Diano.AutoSize = true;
            this.Diano.BackColor = System.Drawing.Color.Green;
            this.Diano.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diano.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Diano.Location = new System.Drawing.Point(12, 385);
            this.Diano.Name = "Diano";
            this.Diano.Size = new System.Drawing.Size(195, 35);
            this.Diano.TabIndex = 7;
            this.Diano.Text = "Diagnostic";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 517);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 39);
            this.textBox4.TabIndex = 10;
            // 
            // Medi
            // 
            this.Medi.AutoSize = true;
            this.Medi.BackColor = System.Drawing.Color.Green;
            this.Medi.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Medi.Location = new System.Drawing.Point(12, 479);
            this.Medi.Name = "Medi";
            this.Medi.Size = new System.Drawing.Size(211, 35);
            this.Medi.TabIndex = 9;
            this.Medi.Text = "Medicament";
            // 
            // dianoGV
            // 
            this.dianoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dianoGV.Location = new System.Drawing.Point(405, 114);
            this.dianoGV.Name = "dianoGV";
            this.dianoGV.Size = new System.Drawing.Size(497, 267);
            this.dianoGV.TabIndex = 11;
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.Color.Green;
            this.AJOUTER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AJOUTER.Location = new System.Drawing.Point(462, 413);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(97, 36);
            this.AJOUTER.TabIndex = 12;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // MODIFIER
            // 
            this.MODIFIER.BackColor = System.Drawing.Color.Green;
            this.MODIFIER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODIFIER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MODIFIER.Location = new System.Drawing.Point(581, 413);
            this.MODIFIER.Name = "MODIFIER";
            this.MODIFIER.Size = new System.Drawing.Size(97, 36);
            this.MODIFIER.TabIndex = 13;
            this.MODIFIER.Text = "MODIFIER";
            this.MODIFIER.UseVisualStyleBackColor = false;
            this.MODIFIER.Click += new System.EventHandler(this.MODIFIER_Click);
            // 
            // SUPPRIMER
            // 
            this.SUPPRIMER.BackColor = System.Drawing.Color.Green;
            this.SUPPRIMER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPRIMER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SUPPRIMER.Location = new System.Drawing.Point(462, 455);
            this.SUPPRIMER.Name = "SUPPRIMER";
            this.SUPPRIMER.Size = new System.Drawing.Size(97, 36);
            this.SUPPRIMER.TabIndex = 14;
            this.SUPPRIMER.Text = "SUPPRIMER";
            this.SUPPRIMER.UseVisualStyleBackColor = false;
            this.SUPPRIMER.Click += new System.EventHandler(this.SUPPRIMER_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Green;
            this.Home.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home.Location = new System.Drawing.Point(581, 455);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(97, 36);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(923, 585);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.SUPPRIMER);
            this.Controls.Add(this.MODIFIER);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.dianoGV);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Medi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Diano);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SymP);
            this.Controls.Add(this.NomP);
            this.Controls.Add(this.IDPATIENT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dianoGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox IDPATIENT;
        private System.Windows.Forms.Label NomP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label SymP;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Diano;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Medi;
        private System.Windows.Forms.DataGridView dianoGV;
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.Button MODIFIER;
        private System.Windows.Forms.Button SUPPRIMER;
        private System.Windows.Forms.Button Home;
    }
}