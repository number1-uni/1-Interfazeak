namespace ErronkaForm
{
    partial class Salmentak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salmentak));
            this.AginteKoadrolbl = new System.Windows.Forms.Label();
            this.EstrellaPicBox = new System.Windows.Forms.PictureBox();
            this.Urtealbl = new System.Windows.Forms.Label();
            this.cmbUrteaSalmentak = new System.Windows.Forms.ComboBox();
            this.UrtekoSalmentaklbl = new System.Windows.Forms.Label();
            this.UrteaZnblbl = new System.Windows.Forms.Label();
            this.Salmentaklbl = new System.Windows.Forms.Label();
            this.userControl1 = new ErronkaDll.UserControl1();
            this.userControl21 = new GrafikoaSalmentak.UserControl2();
            this.SalmentakNumlbl = new System.Windows.Forms.Label();
            this.Irabaziaklbl = new System.Windows.Forms.Label();
            this.IrabaziakNumlbl = new System.Windows.Forms.Label();
            this.ItxiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstrellaPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AginteKoadrolbl
            // 
            this.AginteKoadrolbl.AutoSize = true;
            this.AginteKoadrolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AginteKoadrolbl.Location = new System.Drawing.Point(850, 19);
            this.AginteKoadrolbl.Name = "AginteKoadrolbl";
            this.AginteKoadrolbl.Size = new System.Drawing.Size(196, 20);
            this.AginteKoadrolbl.TabIndex = 5;
            this.AginteKoadrolbl.Text = "Aginte koadroa - PhoneTic";
            // 
            // EstrellaPicBox
            // 
            this.EstrellaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("EstrellaPicBox.Image")));
            this.EstrellaPicBox.Location = new System.Drawing.Point(22, 12);
            this.EstrellaPicBox.Name = "EstrellaPicBox";
            this.EstrellaPicBox.Size = new System.Drawing.Size(28, 27);
            this.EstrellaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EstrellaPicBox.TabIndex = 6;
            this.EstrellaPicBox.TabStop = false;
            // 
            // Urtealbl
            // 
            this.Urtealbl.AutoSize = true;
            this.Urtealbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urtealbl.Location = new System.Drawing.Point(891, 100);
            this.Urtealbl.Name = "Urtealbl";
            this.Urtealbl.Size = new System.Drawing.Size(51, 16);
            this.Urtealbl.TabIndex = 7;
            this.Urtealbl.Text = "URTEA: ";
            // 
            // cmbUrteaSalmentak
            // 
            this.cmbUrteaSalmentak.FormattingEnabled = true;
            this.cmbUrteaSalmentak.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.cmbUrteaSalmentak.Location = new System.Drawing.Point(948, 95);
            this.cmbUrteaSalmentak.Name = "cmbUrteaSalmentak";
            this.cmbUrteaSalmentak.Size = new System.Drawing.Size(121, 21);
            this.cmbUrteaSalmentak.TabIndex = 8;
            this.cmbUrteaSalmentak.Text = "2022";
            this.cmbUrteaSalmentak.SelectedIndexChanged += new System.EventHandler(this.cmbUrtea_SelectedIndexChanged);
            // 
            // UrtekoSalmentaklbl
            // 
            this.UrtekoSalmentaklbl.AutoSize = true;
            this.UrtekoSalmentaklbl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrtekoSalmentaklbl.Location = new System.Drawing.Point(104, 95);
            this.UrtekoSalmentaklbl.Name = "UrtekoSalmentaklbl";
            this.UrtekoSalmentaklbl.Size = new System.Drawing.Size(203, 28);
            this.UrtekoSalmentaklbl.TabIndex = 10;
            this.UrtekoSalmentaklbl.Text = "Urteko Salmentak";
            // 
            // UrteaZnblbl
            // 
            this.UrteaZnblbl.AutoSize = true;
            this.UrteaZnblbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrteaZnblbl.Location = new System.Drawing.Point(104, 132);
            this.UrteaZnblbl.Name = "UrteaZnblbl";
            this.UrteaZnblbl.Size = new System.Drawing.Size(56, 25);
            this.UrteaZnblbl.TabIndex = 11;
            this.UrteaZnblbl.Text = "2022";
            // 
            // Salmentaklbl
            // 
            this.Salmentaklbl.AutoSize = true;
            this.Salmentaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salmentaklbl.Location = new System.Drawing.Point(890, 119);
            this.Salmentaklbl.Name = "Salmentaklbl";
            this.Salmentaklbl.Size = new System.Drawing.Size(83, 21);
            this.Salmentaklbl.TabIndex = 17;
            this.Salmentaklbl.Text = "Salmentak";
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(70, 160);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(682, 455);
            this.userControl1.TabIndex = 0;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(676, 173);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(775, 465);
            this.userControl21.TabIndex = 1;
            // 
            // SalmentakNumlbl
            // 
            this.SalmentakNumlbl.AutoSize = true;
            this.SalmentakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalmentakNumlbl.Location = new System.Drawing.Point(890, 140);
            this.SalmentakNumlbl.Name = "SalmentakNumlbl";
            this.SalmentakNumlbl.Size = new System.Drawing.Size(19, 21);
            this.SalmentakNumlbl.TabIndex = 18;
            this.SalmentakNumlbl.Text = "0";
            // 
            // Irabaziaklbl
            // 
            this.Irabaziaklbl.AutoSize = true;
            this.Irabaziaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Irabaziaklbl.Location = new System.Drawing.Point(756, 119);
            this.Irabaziaklbl.Name = "Irabaziaklbl";
            this.Irabaziaklbl.Size = new System.Drawing.Size(72, 21);
            this.Irabaziaklbl.TabIndex = 19;
            this.Irabaziaklbl.Text = "Irabaziak";
            // 
            // IrabaziakNumlbl
            // 
            this.IrabaziakNumlbl.AutoSize = true;
            this.IrabaziakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrabaziakNumlbl.Location = new System.Drawing.Point(758, 140);
            this.IrabaziakNumlbl.Name = "IrabaziakNumlbl";
            this.IrabaziakNumlbl.Size = new System.Drawing.Size(19, 21);
            this.IrabaziakNumlbl.TabIndex = 20;
            this.IrabaziakNumlbl.Text = "0";
            // 
            // ItxiBtn
            // 
            this.ItxiBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItxiBtn.FlatAppearance.BorderSize = 0;
            this.ItxiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItxiBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItxiBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItxiBtn.Image")));
            this.ItxiBtn.Location = new System.Drawing.Point(1416, 2);
            this.ItxiBtn.Name = "ItxiBtn";
            this.ItxiBtn.Size = new System.Drawing.Size(23, 23);
            this.ItxiBtn.TabIndex = 23;
            this.ItxiBtn.UseVisualStyleBackColor = false;
            this.ItxiBtn.Click += new System.EventHandler(this.ItxiBtn_Click);
            // 
            // Salmentak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1451, 636);
            this.Controls.Add(this.ItxiBtn);
            this.Controls.Add(this.IrabaziakNumlbl);
            this.Controls.Add(this.Irabaziaklbl);
            this.Controls.Add(this.SalmentakNumlbl);
            this.Controls.Add(this.Salmentaklbl);
            this.Controls.Add(this.UrteaZnblbl);
            this.Controls.Add(this.UrtekoSalmentaklbl);
            this.Controls.Add(this.cmbUrteaSalmentak);
            this.Controls.Add(this.Urtealbl);
            this.Controls.Add(this.EstrellaPicBox);
            this.Controls.Add(this.AginteKoadrolbl);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salmentak";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.EstrellaPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErronkaDll.UserControl1 userControl1;
        private GrafikoaSalmentak.UserControl2 userControl21;
        private System.Windows.Forms.Label AginteKoadrolbl;
        private System.Windows.Forms.PictureBox EstrellaPicBox;
        private System.Windows.Forms.Label Urtealbl;
        private System.Windows.Forms.ComboBox cmbUrteaSalmentak;
        private System.Windows.Forms.Label UrtekoSalmentaklbl;
        private System.Windows.Forms.Label UrteaZnblbl;
        private System.Windows.Forms.Label Salmentaklbl;
        private System.Windows.Forms.Label SalmentakNumlbl;
        private System.Windows.Forms.Label Irabaziaklbl;
        private System.Windows.Forms.Label IrabaziakNumlbl;
        private System.Windows.Forms.Button ItxiBtn;
    }
}

