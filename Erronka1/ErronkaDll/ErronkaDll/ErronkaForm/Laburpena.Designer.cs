namespace ErronkaForm
{
    partial class Laburpena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laburpena));
            this.EstrellaPicBox = new System.Windows.Forms.PictureBox();
            this.AginteKoadrolbl = new System.Windows.Forms.Label();
            this.HilabetekoLaburpenalbl = new System.Windows.Forms.Label();
            this.cmbUrteaLaburpena = new System.Windows.Forms.ComboBox();
            this.cmbHilabeteaLaburpena = new System.Windows.Forms.ComboBox();
            this.UrteaZnblbl = new System.Windows.Forms.Label();
            this.HilabeteaHitzlbl = new System.Windows.Forms.Label();
            this.Irabaziaklbl = new System.Windows.Forms.Label();
            this.IrabaziakNumlbl = new System.Windows.Forms.Label();
            this.Salmentaklbl = new System.Windows.Forms.Label();
            this.SalmentakNumlbl = new System.Windows.Forms.Label();
            this.Gastuaklbl = new System.Windows.Forms.Label();
            this.GastuakNumlbl = new System.Windows.Forms.Label();
            this.Guztiralbl = new System.Windows.Forms.Label();
            this.GuztiraNumlbl = new System.Windows.Forms.Label();
            this.userControl11 = new ErronkaDll.UserControl1();
            this.ItxiBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EstrellaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EstrellaPicBox
            // 
            this.EstrellaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("EstrellaPicBox.Image")));
            this.EstrellaPicBox.Location = new System.Drawing.Point(22, 12);
            this.EstrellaPicBox.Name = "EstrellaPicBox";
            this.EstrellaPicBox.Size = new System.Drawing.Size(28, 27);
            this.EstrellaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EstrellaPicBox.TabIndex = 7;
            this.EstrellaPicBox.TabStop = false;
            // 
            // AginteKoadrolbl
            // 
            this.AginteKoadrolbl.AutoSize = true;
            this.AginteKoadrolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AginteKoadrolbl.Location = new System.Drawing.Point(850, 19);
            this.AginteKoadrolbl.Name = "AginteKoadrolbl";
            this.AginteKoadrolbl.Size = new System.Drawing.Size(196, 20);
            this.AginteKoadrolbl.TabIndex = 8;
            this.AginteKoadrolbl.Text = "Aginte koadroa - PhoneTic";
            // 
            // HilabetekoLaburpenalbl
            // 
            this.HilabetekoLaburpenalbl.AutoSize = true;
            this.HilabetekoLaburpenalbl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HilabetekoLaburpenalbl.Location = new System.Drawing.Point(104, 95);
            this.HilabetekoLaburpenalbl.Name = "HilabetekoLaburpenalbl";
            this.HilabetekoLaburpenalbl.Size = new System.Drawing.Size(245, 28);
            this.HilabetekoLaburpenalbl.TabIndex = 12;
            this.HilabetekoLaburpenalbl.Text = "Hilabeteko Laburpena";
            // 
            // cmbUrteaLaburpena
            // 
            this.cmbUrteaLaburpena.FormattingEnabled = true;
            this.cmbUrteaLaburpena.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.cmbUrteaLaburpena.Location = new System.Drawing.Point(950, 102);
            this.cmbUrteaLaburpena.Name = "cmbUrteaLaburpena";
            this.cmbUrteaLaburpena.Size = new System.Drawing.Size(121, 21);
            this.cmbUrteaLaburpena.TabIndex = 13;
            this.cmbUrteaLaburpena.Text = "2022";
            this.cmbUrteaLaburpena.SelectedIndexChanged += new System.EventHandler(this.cmbUrteaLaburpena_SelectedIndexChanged);
            // 
            // cmbHilabeteaLaburpena
            // 
            this.cmbHilabeteaLaburpena.FormattingEnabled = true;
            this.cmbHilabeteaLaburpena.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbHilabeteaLaburpena.Location = new System.Drawing.Point(1089, 102);
            this.cmbHilabeteaLaburpena.Name = "cmbHilabeteaLaburpena";
            this.cmbHilabeteaLaburpena.Size = new System.Drawing.Size(121, 21);
            this.cmbHilabeteaLaburpena.TabIndex = 14;
            this.cmbHilabeteaLaburpena.Text = "01";
            this.cmbHilabeteaLaburpena.SelectedIndexChanged += new System.EventHandler(this.cmbHilabeteaLaburpena_SelectedIndexChanged);
            // 
            // UrteaZnblbl
            // 
            this.UrteaZnblbl.AutoSize = true;
            this.UrteaZnblbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrteaZnblbl.Location = new System.Drawing.Point(104, 138);
            this.UrteaZnblbl.Name = "UrteaZnblbl";
            this.UrteaZnblbl.Size = new System.Drawing.Size(56, 25);
            this.UrteaZnblbl.TabIndex = 15;
            this.UrteaZnblbl.Text = "2022";
            // 
            // HilabeteaHitzlbl
            // 
            this.HilabeteaHitzlbl.AutoSize = true;
            this.HilabeteaHitzlbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HilabeteaHitzlbl.Location = new System.Drawing.Point(188, 138);
            this.HilabeteaHitzlbl.Name = "HilabeteaHitzlbl";
            this.HilabeteaHitzlbl.Size = new System.Drawing.Size(86, 25);
            this.HilabeteaHitzlbl.TabIndex = 16;
            this.HilabeteaHitzlbl.Text = "Urtarrila";
            // 
            // Irabaziaklbl
            // 
            this.Irabaziaklbl.AutoSize = true;
            this.Irabaziaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Italic);
            this.Irabaziaklbl.Location = new System.Drawing.Point(850, 153);
            this.Irabaziaklbl.Name = "Irabaziaklbl";
            this.Irabaziaklbl.Size = new System.Drawing.Size(86, 23);
            this.Irabaziaklbl.TabIndex = 20;
            this.Irabaziaklbl.Text = "Irabaziak";
            // 
            // IrabaziakNumlbl
            // 
            this.IrabaziakNumlbl.AutoSize = true;
            this.IrabaziakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold);
            this.IrabaziakNumlbl.Location = new System.Drawing.Point(850, 174);
            this.IrabaziakNumlbl.Name = "IrabaziakNumlbl";
            this.IrabaziakNumlbl.Size = new System.Drawing.Size(26, 29);
            this.IrabaziakNumlbl.TabIndex = 21;
            this.IrabaziakNumlbl.Text = "0";
            // 
            // Salmentaklbl
            // 
            this.Salmentaklbl.AutoSize = true;
            this.Salmentaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Italic);
            this.Salmentaklbl.Location = new System.Drawing.Point(850, 214);
            this.Salmentaklbl.Name = "Salmentaklbl";
            this.Salmentaklbl.Size = new System.Drawing.Size(97, 23);
            this.Salmentaklbl.TabIndex = 22;
            this.Salmentaklbl.Text = "Salmentak";
            // 
            // SalmentakNumlbl
            // 
            this.SalmentakNumlbl.AutoSize = true;
            this.SalmentakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold);
            this.SalmentakNumlbl.Location = new System.Drawing.Point(850, 235);
            this.SalmentakNumlbl.Name = "SalmentakNumlbl";
            this.SalmentakNumlbl.Size = new System.Drawing.Size(26, 29);
            this.SalmentakNumlbl.TabIndex = 23;
            this.SalmentakNumlbl.Text = "0";
            // 
            // Gastuaklbl
            // 
            this.Gastuaklbl.AutoSize = true;
            this.Gastuaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gastuaklbl.Location = new System.Drawing.Point(1008, 153);
            this.Gastuaklbl.Name = "Gastuaklbl";
            this.Gastuaklbl.Size = new System.Drawing.Size(77, 23);
            this.Gastuaklbl.TabIndex = 24;
            this.Gastuaklbl.Text = "Gastuak";
            // 
            // GastuakNumlbl
            // 
            this.GastuakNumlbl.AutoSize = true;
            this.GastuakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold);
            this.GastuakNumlbl.Location = new System.Drawing.Point(1008, 174);
            this.GastuakNumlbl.Name = "GastuakNumlbl";
            this.GastuakNumlbl.Size = new System.Drawing.Size(26, 29);
            this.GastuakNumlbl.TabIndex = 25;
            this.GastuakNumlbl.Text = "0";
            // 
            // Guztiralbl
            // 
            this.Guztiralbl.AutoSize = true;
            this.Guztiralbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Italic);
            this.Guztiralbl.Location = new System.Drawing.Point(1008, 214);
            this.Guztiralbl.Name = "Guztiralbl";
            this.Guztiralbl.Size = new System.Drawing.Size(71, 23);
            this.Guztiralbl.TabIndex = 26;
            this.Guztiralbl.Text = "Guztira";
            // 
            // GuztiraNumlbl
            // 
            this.GuztiraNumlbl.AutoSize = true;
            this.GuztiraNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold);
            this.GuztiraNumlbl.Location = new System.Drawing.Point(1008, 235);
            this.GuztiraNumlbl.Name = "GuztiraNumlbl";
            this.GuztiraNumlbl.Size = new System.Drawing.Size(26, 29);
            this.GuztiraNumlbl.TabIndex = 27;
            this.GuztiraNumlbl.Text = "0";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-2, 174);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 450);
            this.userControl11.TabIndex = 17;
            // 
            // ItxiBtn
            // 
            this.ItxiBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItxiBtn.FlatAppearance.BorderSize = 0;
            this.ItxiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItxiBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItxiBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItxiBtn.Image")));
            this.ItxiBtn.Location = new System.Drawing.Point(1422, 1);
            this.ItxiBtn.Name = "ItxiBtn";
            this.ItxiBtn.Size = new System.Drawing.Size(23, 23);
            this.ItxiBtn.TabIndex = 28;
            this.ItxiBtn.UseVisualStyleBackColor = false;
            this.ItxiBtn.Click += new System.EventHandler(this.ItxiBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(804, 317);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(366, 226);
            this.dataGridView.TabIndex = 29;
            // 
            // Laburpena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1457, 617);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ItxiBtn);
            this.Controls.Add(this.GuztiraNumlbl);
            this.Controls.Add(this.Guztiralbl);
            this.Controls.Add(this.GastuakNumlbl);
            this.Controls.Add(this.Gastuaklbl);
            this.Controls.Add(this.SalmentakNumlbl);
            this.Controls.Add(this.Salmentaklbl);
            this.Controls.Add(this.IrabaziakNumlbl);
            this.Controls.Add(this.Irabaziaklbl);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.HilabeteaHitzlbl);
            this.Controls.Add(this.UrteaZnblbl);
            this.Controls.Add(this.cmbHilabeteaLaburpena);
            this.Controls.Add(this.cmbUrteaLaburpena);
            this.Controls.Add(this.HilabetekoLaburpenalbl);
            this.Controls.Add(this.AginteKoadrolbl);
            this.Controls.Add(this.EstrellaPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laburpena";
            this.Text = "Laburpena";
            this.Load += new System.EventHandler(this.Laburpena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstrellaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EstrellaPicBox;
        private System.Windows.Forms.Label AginteKoadrolbl;
        private System.Windows.Forms.Label HilabetekoLaburpenalbl;
        private System.Windows.Forms.ComboBox cmbUrteaLaburpena;
        private System.Windows.Forms.ComboBox cmbHilabeteaLaburpena;
        private System.Windows.Forms.Label UrteaZnblbl;
        private System.Windows.Forms.Label HilabeteaHitzlbl;
        private System.Windows.Forms.Label Irabaziaklbl;
        private System.Windows.Forms.Label IrabaziakNumlbl;
        private System.Windows.Forms.Label Salmentaklbl;
        private System.Windows.Forms.Label SalmentakNumlbl;
        private System.Windows.Forms.Label Gastuaklbl;
        private System.Windows.Forms.Label GastuakNumlbl;
        private System.Windows.Forms.Label Guztiralbl;
        private System.Windows.Forms.Label GuztiraNumlbl;
        private ErronkaDll.UserControl1 userControl11;
        private System.Windows.Forms.Button ItxiBtn;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}