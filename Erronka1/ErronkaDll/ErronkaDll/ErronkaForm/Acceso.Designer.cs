namespace ErronkaForm
{
    partial class Acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.entrar = new System.Windows.Forms.Button();
            this.erakutsi = new System.Windows.Forms.Button();
            this.ezkutatu = new System.Windows.Forms.Button();
            this.Sartu = new System.Windows.Forms.HelpProvider();
            this.Erabiltzailea = new System.Windows.Forms.HelpProvider();
            this.Pasahitza = new System.Windows.Forms.HelpProvider();
            this.PasIkus = new System.Windows.Forms.HelpProvider();
            this.PasIkusEz = new System.Windows.Forms.HelpProvider();
            this.Itxi = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 46);
            this.panel1.TabIndex = 0;
            // 
            // Cerrar
            // 
            this.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Itxi.SetHelpString(this.Cerrar, "Programa itxi egiten da");
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cerrar.Location = new System.Drawing.Point(429, 3);
            this.Cerrar.Name = "Cerrar";
            this.Itxi.SetShowHelp(this.Cerrar, true);
            this.Cerrar.Size = new System.Drawing.Size(32, 28);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erabiltzailea.SetHelpString(this.user, "Zure erabiltzailea sartu hemen");
            this.user.Location = new System.Drawing.Point(106, 237);
            this.user.Name = "user";
            this.Erabiltzailea.SetShowHelp(this.user, true);
            this.user.Size = new System.Drawing.Size(238, 28);
            this.user.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pasahitza.SetHelpString(this.password, "Zure pasahitza sartu hemen");
            this.password.Location = new System.Drawing.Point(106, 325);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.Pasahitza.SetShowHelp(this.password, true);
            this.password.Size = new System.Drawing.Size(238, 28);
            this.password.TabIndex = 3;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(102, 199);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(110, 24);
            this.userlbl.TabIndex = 4;
            this.userlbl.Text = "Erabiltzailea";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(102, 279);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(89, 24);
            this.passwordlbl.TabIndex = 5;
            this.passwordlbl.Text = "Pasahitza";
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.entrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.entrar.FlatAppearance.BorderSize = 0;
            this.entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sartu.SetHelpString(this.entrar, "Erabiltzailea eta Pasahitza sartu, menu printzipalera joateko.");
            this.entrar.Location = new System.Drawing.Point(179, 434);
            this.entrar.Name = "entrar";
            this.Sartu.SetShowHelp(this.entrar, true);
            this.entrar.Size = new System.Drawing.Size(110, 36);
            this.entrar.TabIndex = 7;
            this.entrar.Text = "Sartu";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // erakutsi
            // 
            this.PasIkus.SetHelpString(this.erakutsi, "Pasahitza ikusteko botoiari eman.");
            this.erakutsi.Image = ((System.Drawing.Image)(resources.GetObject("erakutsi.Image")));
            this.erakutsi.Location = new System.Drawing.Point(350, 325);
            this.erakutsi.Name = "erakutsi";
            this.PasIkus.SetShowHelp(this.erakutsi, true);
            this.erakutsi.Size = new System.Drawing.Size(29, 23);
            this.erakutsi.TabIndex = 8;
            this.erakutsi.UseVisualStyleBackColor = true;
            this.erakutsi.Click += new System.EventHandler(this.erakutsi_Click);
            // 
            // ezkutatu
            // 
            this.PasIkusEz.SetHelpString(this.ezkutatu, "Pasahitza ezkutatzeko klik egin.");
            this.ezkutatu.Image = ((System.Drawing.Image)(resources.GetObject("ezkutatu.Image")));
            this.ezkutatu.Location = new System.Drawing.Point(375, 325);
            this.ezkutatu.Name = "ezkutatu";
            this.PasIkusEz.SetShowHelp(this.ezkutatu, true);
            this.ezkutatu.Size = new System.Drawing.Size(28, 23);
            this.ezkutatu.TabIndex = 9;
            this.ezkutatu.UseVisualStyleBackColor = true;
            this.ezkutatu.Click += new System.EventHandler(this.ezkutatu_Click);
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 510);
            this.Controls.Add(this.ezkutatu);
            this.Controls.Add(this.erakutsi);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acceso";
            this.Text = "Acceso";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button erakutsi;
        private System.Windows.Forms.Button ezkutatu;
        private System.Windows.Forms.HelpProvider Erabiltzailea;
        private System.Windows.Forms.HelpProvider Pasahitza;
        private System.Windows.Forms.HelpProvider Sartu;
        private System.Windows.Forms.HelpProvider PasIkus;
        private System.Windows.Forms.HelpProvider PasIkusEz;
        private System.Windows.Forms.HelpProvider Itxi;
    }
}