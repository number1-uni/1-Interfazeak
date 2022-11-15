namespace ErronkaForm
{
    partial class Erosketak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Erosketak));
            this.EstrellaPicBox = new System.Windows.Forms.PictureBox();
            this.AginteKoadrolbl = new System.Windows.Forms.Label();
            this.Urtealbl = new System.Windows.Forms.Label();
            this.cmbUrteaErosketak = new System.Windows.Forms.ComboBox();
            this.UrtekoErosketaklbl = new System.Windows.Forms.Label();
            this.UrteaZnblbl = new System.Windows.Forms.Label();
            this.userControl21 = new GrafikoaSalmentak.UserControl2();
            this.Erosketaklbl = new System.Windows.Forms.Label();
            this.ErosketakNumlbl = new System.Windows.Forms.Label();
            this.Gastuaklbl = new System.Windows.Forms.Label();
            this.GastuakNumlbl = new System.Windows.Forms.Label();
            this.userControl1 = new ErronkaDll.UserControl1();
            this.ItxiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstrellaPicBox)).BeginInit();
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
            // Urtealbl
            // 
            this.Urtealbl.AutoSize = true;
            this.Urtealbl.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urtealbl.Location = new System.Drawing.Point(891, 100);
            this.Urtealbl.Name = "Urtealbl";
            this.Urtealbl.Size = new System.Drawing.Size(51, 16);
            this.Urtealbl.TabIndex = 9;
            this.Urtealbl.Text = "URTEA: ";
            // 
            // cmbUrteaErosketak
            // 
            this.cmbUrteaErosketak.FormattingEnabled = true;
            this.cmbUrteaErosketak.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.cmbUrteaErosketak.Location = new System.Drawing.Point(948, 95);
            this.cmbUrteaErosketak.Name = "cmbUrteaErosketak";
            this.cmbUrteaErosketak.Size = new System.Drawing.Size(121, 21);
            this.cmbUrteaErosketak.TabIndex = 10;
            this.cmbUrteaErosketak.Text = "2022";
            this.cmbUrteaErosketak.SelectedIndexChanged += new System.EventHandler(this.cmbUrteaErosketak_SelectedIndexChanged);
            // 
            // UrtekoErosketaklbl
            // 
            this.UrtekoErosketaklbl.AutoSize = true;
            this.UrtekoErosketaklbl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrtekoErosketaklbl.Location = new System.Drawing.Point(104, 95);
            this.UrtekoErosketaklbl.Name = "UrtekoErosketaklbl";
            this.UrtekoErosketaklbl.Size = new System.Drawing.Size(195, 28);
            this.UrtekoErosketaklbl.TabIndex = 11;
            this.UrtekoErosketaklbl.Text = "Urteko Erosketak";
            // 
            // UrteaZnblbl
            // 
            this.UrteaZnblbl.AutoSize = true;
            this.UrteaZnblbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrteaZnblbl.Location = new System.Drawing.Point(104, 132);
            this.UrteaZnblbl.Name = "UrteaZnblbl";
            this.UrteaZnblbl.Size = new System.Drawing.Size(56, 25);
            this.UrteaZnblbl.TabIndex = 12;
            this.UrteaZnblbl.Text = "2022";
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(684, 160);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(770, 465);
            this.userControl21.TabIndex = 14;
            // 
            // Erosketaklbl
            // 
            this.Erosketaklbl.AutoSize = true;
            this.Erosketaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erosketaklbl.Location = new System.Drawing.Point(890, 119);
            this.Erosketaklbl.Name = "Erosketaklbl";
            this.Erosketaklbl.Size = new System.Drawing.Size(77, 21);
            this.Erosketaklbl.TabIndex = 18;
            this.Erosketaklbl.Text = "Erosketak";
            // 
            // ErosketakNumlbl
            // 
            this.ErosketakNumlbl.AutoSize = true;
            this.ErosketakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErosketakNumlbl.Location = new System.Drawing.Point(890, 140);
            this.ErosketakNumlbl.Name = "ErosketakNumlbl";
            this.ErosketakNumlbl.Size = new System.Drawing.Size(19, 21);
            this.ErosketakNumlbl.TabIndex = 19;
            this.ErosketakNumlbl.Text = "0";
            // 
            // Gastuaklbl
            // 
            this.Gastuaklbl.AutoSize = true;
            this.Gastuaklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gastuaklbl.Location = new System.Drawing.Point(756, 119);
            this.Gastuaklbl.Name = "Gastuaklbl";
            this.Gastuaklbl.Size = new System.Drawing.Size(66, 21);
            this.Gastuaklbl.TabIndex = 20;
            this.Gastuaklbl.Text = "Gastuak";
            // 
            // GastuakNumlbl
            // 
            this.GastuakNumlbl.AutoSize = true;
            this.GastuakNumlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GastuakNumlbl.Location = new System.Drawing.Point(758, 140);
            this.GastuakNumlbl.Name = "GastuakNumlbl";
            this.GastuakNumlbl.Size = new System.Drawing.Size(19, 21);
            this.GastuakNumlbl.TabIndex = 21;
            this.GastuakNumlbl.Text = "0";
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(70, 160);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(682, 455);
            this.userControl1.TabIndex = 13;
            // 
            // ItxiBtn
            // 
            this.ItxiBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItxiBtn.FlatAppearance.BorderSize = 0;
            this.ItxiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItxiBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItxiBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItxiBtn.Image")));
            this.ItxiBtn.Location = new System.Drawing.Point(1416, 0);
            this.ItxiBtn.Name = "ItxiBtn";
            this.ItxiBtn.Size = new System.Drawing.Size(23, 23);
            this.ItxiBtn.TabIndex = 22;
            this.ItxiBtn.UseVisualStyleBackColor = false;
            this.ItxiBtn.Click += new System.EventHandler(this.ItxiBtn_Click);
            // 
            // Erosketak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1451, 636);
            this.Controls.Add(this.ItxiBtn);
            this.Controls.Add(this.GastuakNumlbl);
            this.Controls.Add(this.Gastuaklbl);
            this.Controls.Add(this.ErosketakNumlbl);
            this.Controls.Add(this.Erosketaklbl);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.UrteaZnblbl);
            this.Controls.Add(this.UrtekoErosketaklbl);
            this.Controls.Add(this.cmbUrteaErosketak);
            this.Controls.Add(this.Urtealbl);
            this.Controls.Add(this.AginteKoadrolbl);
            this.Controls.Add(this.EstrellaPicBox);
            this.Name = "Erosketak";
            this.Text = "Erosketak";
            this.Load += new System.EventHandler(this.Erosketak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstrellaPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EstrellaPicBox;
        private System.Windows.Forms.Label AginteKoadrolbl;
        private System.Windows.Forms.Label Urtealbl;
        private System.Windows.Forms.ComboBox cmbUrteaErosketak;
        private System.Windows.Forms.Label UrtekoErosketaklbl;
        private System.Windows.Forms.Label UrteaZnblbl;
        private ErronkaDll.UserControl1 userControl1;
        private GrafikoaSalmentak.UserControl2 userControl21;
        private System.Windows.Forms.Label Erosketaklbl;
        private System.Windows.Forms.Label ErosketakNumlbl;
        private System.Windows.Forms.Label Gastuaklbl;
        private System.Windows.Forms.Label GastuakNumlbl;
        private System.Windows.Forms.Button ItxiBtn;
    }
}