namespace ErronkaForm
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Salmentakbtn = new System.Windows.Forms.Button();
            this.Erosketakbtn = new System.Windows.Forms.Button();
            this.Laburpenabtn = new System.Windows.Forms.Button();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.CerrarSesionlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Salmentakbtn
            // 
            this.Salmentakbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salmentakbtn.Location = new System.Drawing.Point(94, 176);
            this.Salmentakbtn.Name = "Salmentakbtn";
            this.Salmentakbtn.Size = new System.Drawing.Size(126, 34);
            this.Salmentakbtn.TabIndex = 5;
            this.Salmentakbtn.Text = "Salmentak";
            this.Salmentakbtn.UseVisualStyleBackColor = true;
            this.Salmentakbtn.Click += new System.EventHandler(this.Salmentakbtn_Click);
            // 
            // Erosketakbtn
            // 
            this.Erosketakbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erosketakbtn.Location = new System.Drawing.Point(338, 176);
            this.Erosketakbtn.Name = "Erosketakbtn";
            this.Erosketakbtn.Size = new System.Drawing.Size(126, 34);
            this.Erosketakbtn.TabIndex = 6;
            this.Erosketakbtn.Text = "Erosketak";
            this.Erosketakbtn.UseVisualStyleBackColor = true;
            this.Erosketakbtn.Click += new System.EventHandler(this.Erosketakbtn_Click);
            // 
            // Laburpenabtn
            // 
            this.Laburpenabtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laburpenabtn.Location = new System.Drawing.Point(566, 176);
            this.Laburpenabtn.Name = "Laburpenabtn";
            this.Laburpenabtn.Size = new System.Drawing.Size(126, 34);
            this.Laburpenabtn.TabIndex = 7;
            this.Laburpenabtn.Text = "Laburpena";
            this.Laburpenabtn.UseVisualStyleBackColor = true;
            this.Laburpenabtn.Click += new System.EventHandler(this.Laburpenabtn_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.FlatAppearance.BorderSize = 0;
            this.CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("CerrarSesion.Image")));
            this.CerrarSesion.Location = new System.Drawing.Point(727, 385);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(61, 53);
            this.CerrarSesion.TabIndex = 8;
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // CerrarSesionlbl
            // 
            this.CerrarSesionlbl.AutoSize = true;
            this.CerrarSesionlbl.Location = new System.Drawing.Point(733, 428);
            this.CerrarSesionlbl.Name = "CerrarSesionlbl";
            this.CerrarSesionlbl.Size = new System.Drawing.Size(55, 13);
            this.CerrarSesionlbl.TabIndex = 9;
            this.CerrarSesionlbl.Text = "Itxi Sesioa";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CerrarSesionlbl);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.Laburpenabtn);
            this.Controls.Add(this.Erosketakbtn);
            this.Controls.Add(this.Salmentakbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Salmentakbtn;
        private System.Windows.Forms.Button Erosketakbtn;
        private System.Windows.Forms.Button Laburpenabtn;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Label CerrarSesionlbl;
    }
}