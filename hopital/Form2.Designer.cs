
namespace hopital
{
    partial class Form2
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
            this.PatId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PatAdresse = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PatPhone = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.PatMaladie = new System.Windows.Forms.Label();
            this.PatGenre = new System.Windows.Forms.ComboBox();
            this.PatSang = new System.Windows.Forms.ComboBox();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.MODIFIER = new System.Windows.Forms.Button();
            this.SUPPRIMER = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYSTEME DE GESTION D\'HOPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(346, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient";
            // 
            // PatId
            // 
            this.PatId.AutoSize = true;
            this.PatId.BackColor = System.Drawing.Color.Green;
            this.PatId.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatId.Location = new System.Drawing.Point(13, 107);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(192, 30);
            this.PatId.TabIndex = 1;
            this.PatId.Text = "ID du Patient";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 35);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 35);
            this.textBox2.TabIndex = 4;
            // 
            // PatName
            // 
            this.PatName.AutoSize = true;
            this.PatName.BackColor = System.Drawing.Color.Green;
            this.PatName.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatName.Location = new System.Drawing.Point(13, 188);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(221, 30);
            this.PatName.TabIndex = 3;
            this.PatName.Text = "Nom du Patient";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(18, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 35);
            this.textBox3.TabIndex = 6;
            // 
            // PatAdresse
            // 
            this.PatAdresse.AutoSize = true;
            this.PatAdresse.BackColor = System.Drawing.Color.Green;
            this.PatAdresse.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatAdresse.Location = new System.Drawing.Point(13, 272);
            this.PatAdresse.Name = "PatAdresse";
            this.PatAdresse.Size = new System.Drawing.Size(130, 30);
            this.PatAdresse.TabIndex = 5;
            this.PatAdresse.Text = "Adresse";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(18, 390);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 35);
            this.textBox4.TabIndex = 8;
            // 
            // PatPhone
            // 
            this.PatPhone.AutoSize = true;
            this.PatPhone.BackColor = System.Drawing.Color.Green;
            this.PatPhone.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatPhone.Location = new System.Drawing.Point(13, 356);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(161, 30);
            this.PatPhone.TabIndex = 7;
            this.PatPhone.Text = "Telephone";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(18, 473);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 35);
            this.textBox5.TabIndex = 10;
            // 
            // PatAge
            // 
            this.PatAge.AutoSize = true;
            this.PatAge.BackColor = System.Drawing.Color.Green;
            this.PatAge.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatAge.Location = new System.Drawing.Point(13, 439);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(223, 30);
            this.PatAge.TabIndex = 9;
            this.PatAge.Text = "Age du Patient";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(19, 630);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 35);
            this.textBox6.TabIndex = 12;
            // 
            // PatMaladie
            // 
            this.PatMaladie.AutoSize = true;
            this.PatMaladie.BackColor = System.Drawing.Color.Green;
            this.PatMaladie.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatMaladie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatMaladie.Location = new System.Drawing.Point(14, 596);
            this.PatMaladie.Name = "PatMaladie";
            this.PatMaladie.Size = new System.Drawing.Size(129, 30);
            this.PatMaladie.TabIndex = 11;
            this.PatMaladie.Text = "Maladie";
            // 
            // PatGenre
            // 
            this.PatGenre.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGenre.FormattingEnabled = true;
            this.PatGenre.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.PatGenre.Location = new System.Drawing.Point(18, 515);
            this.PatGenre.Name = "PatGenre";
            this.PatGenre.Size = new System.Drawing.Size(121, 26);
            this.PatGenre.TabIndex = 13;
            this.PatGenre.Text = "Genre";
            // 
            // PatSang
            // 
            this.PatSang.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatSang.FormattingEnabled = true;
            this.PatSang.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.PatSang.Location = new System.Drawing.Point(18, 556);
            this.PatSang.Name = "PatSang";
            this.PatSang.Size = new System.Drawing.Size(121, 26);
            this.PatSang.TabIndex = 14;
            this.PatSang.Text = "Group Sang";
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.Color.Green;
            this.AJOUTER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AJOUTER.Location = new System.Drawing.Point(460, 440);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(91, 36);
            this.AJOUTER.TabIndex = 15;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // MODIFIER
            // 
            this.MODIFIER.BackColor = System.Drawing.Color.Green;
            this.MODIFIER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODIFIER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MODIFIER.Location = new System.Drawing.Point(569, 440);
            this.MODIFIER.Name = "MODIFIER";
            this.MODIFIER.Size = new System.Drawing.Size(91, 36);
            this.MODIFIER.TabIndex = 16;
            this.MODIFIER.Text = "MODIFIER";
            this.MODIFIER.UseVisualStyleBackColor = false;
            this.MODIFIER.Click += new System.EventHandler(this.MODIFIER_Click);
            // 
            // SUPPRIMER
            // 
            this.SUPPRIMER.BackColor = System.Drawing.Color.Green;
            this.SUPPRIMER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPRIMER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SUPPRIMER.Location = new System.Drawing.Point(460, 482);
            this.SUPPRIMER.Name = "SUPPRIMER";
            this.SUPPRIMER.Size = new System.Drawing.Size(91, 36);
            this.SUPPRIMER.TabIndex = 17;
            this.SUPPRIMER.Text = "SUPPRIMER";
            this.SUPPRIMER.UseVisualStyleBackColor = false;
            this.SUPPRIMER.Click += new System.EventHandler(this.SUPPRIMER_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Green;
            this.Home.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home.Location = new System.Drawing.Point(569, 482);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(91, 36);
            this.Home.TabIndex = 18;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // PatientGV
            // 
            this.PatientGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(337, 107);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.Size = new System.Drawing.Size(639, 279);
            this.PatientGV.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 788);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.SUPPRIMER);
            this.Controls.Add(this.MODIFIER);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.PatSang);
            this.Controls.Add(this.PatGenre);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.PatMaladie);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PatAdresse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PatId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PatName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label PatAdresse;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label PatPhone;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label PatAge;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label PatMaladie;
        private System.Windows.Forms.ComboBox PatGenre;
        private System.Windows.Forms.ComboBox PatSang;
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.Button MODIFIER;
        private System.Windows.Forms.Button SUPPRIMER;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.DataGridView PatientGV;
    }
}