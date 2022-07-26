
namespace hopital
{
    partial class Form1
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
            this.DocId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DocName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DocExp = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DocPass = new System.Windows.Forms.Label();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.MODIFIER = new System.Windows.Forms.Button();
            this.SUPPRIMER = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.DocteurGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocteurGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(833, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYSTEME DE GESTION D\'HOPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(348, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Docteur";
            // 
            // DocId
            // 
            this.DocId.AutoSize = true;
            this.DocId.BackColor = System.Drawing.Color.Green;
            this.DocId.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DocId.Location = new System.Drawing.Point(13, 107);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(198, 30);
            this.DocId.TabIndex = 1;
            this.DocId.Text = "ID Du Docteur";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 35);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 35);
            this.textBox2.TabIndex = 4;
            // 
            // DocName
            // 
            this.DocName.AutoSize = true;
            this.DocName.BackColor = System.Drawing.Color.Green;
            this.DocName.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DocName.Location = new System.Drawing.Point(13, 192);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(227, 30);
            this.DocName.TabIndex = 3;
            this.DocName.Text = "Nom Du Docteur";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 35);
            this.textBox3.TabIndex = 6;
            // 
            // DocExp
            // 
            this.DocExp.AutoSize = true;
            this.DocExp.BackColor = System.Drawing.Color.Green;
            this.DocExp.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocExp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DocExp.Location = new System.Drawing.Point(13, 276);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(287, 30);
            this.DocExp.TabIndex = 5;
            this.DocExp.Text = "Année D\'Experience";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(13, 393);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 35);
            this.textBox4.TabIndex = 8;
            // 
            // DocPass
            // 
            this.DocPass.AutoSize = true;
            this.DocPass.BackColor = System.Drawing.Color.Green;
            this.DocPass.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DocPass.Location = new System.Drawing.Point(13, 359);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(196, 30);
            this.DocPass.TabIndex = 7;
            this.DocPass.Text = "Mot De Passe";
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.Color.Green;
            this.AJOUTER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AJOUTER.Location = new System.Drawing.Point(18, 447);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(88, 38);
            this.AJOUTER.TabIndex = 9;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // MODIFIER
            // 
            this.MODIFIER.BackColor = System.Drawing.Color.Green;
            this.MODIFIER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODIFIER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MODIFIER.Location = new System.Drawing.Point(123, 447);
            this.MODIFIER.Name = "MODIFIER";
            this.MODIFIER.Size = new System.Drawing.Size(88, 38);
            this.MODIFIER.TabIndex = 10;
            this.MODIFIER.Text = "MODIFIER";
            this.MODIFIER.UseVisualStyleBackColor = false;
            this.MODIFIER.Click += new System.EventHandler(this.MODIFIER_Click);
            // 
            // SUPPRIMER
            // 
            this.SUPPRIMER.BackColor = System.Drawing.Color.Green;
            this.SUPPRIMER.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPRIMER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SUPPRIMER.Location = new System.Drawing.Point(18, 501);
            this.SUPPRIMER.Name = "SUPPRIMER";
            this.SUPPRIMER.Size = new System.Drawing.Size(88, 38);
            this.SUPPRIMER.TabIndex = 11;
            this.SUPPRIMER.Text = "SUPPRIMER";
            this.SUPPRIMER.UseVisualStyleBackColor = false;
            this.SUPPRIMER.Click += new System.EventHandler(this.SUPPRIMER_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Green;
            this.Home.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home.Location = new System.Drawing.Point(123, 501);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(88, 38);
            this.Home.TabIndex = 12;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // DocteurGV
            // 
            this.DocteurGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DocteurGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocteurGV.Location = new System.Drawing.Point(354, 120);
            this.DocteurGV.Name = "DocteurGV";
            this.DocteurGV.Size = new System.Drawing.Size(445, 328);
            this.DocteurGV.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(833, 573);
            this.Controls.Add(this.DocteurGV);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.SUPPRIMER);
            this.Controls.Add(this.MODIFIER);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocteurGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DocId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DocName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label DocExp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label DocPass;
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.Button MODIFIER;
        private System.Windows.Forms.Button SUPPRIMER;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.DataGridView DocteurGV;
    }
}