namespace Ödev2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekle_btn = new System.Windows.Forms.Button();
            this.güncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.listele_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.transkript_btn = new System.Windows.Forms.Button();
            this.resim_bx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim_bx)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ekle_btn.Location = new System.Drawing.Point(797, 420);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(158, 78);
            this.ekle_btn.TabIndex = 0;
            this.ekle_btn.Text = "Ders Ekle";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // güncelle_btn
            // 
            this.güncelle_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.güncelle_btn.Location = new System.Drawing.Point(795, 298);
            this.güncelle_btn.Name = "güncelle_btn";
            this.güncelle_btn.Size = new System.Drawing.Size(160, 78);
            this.güncelle_btn.TabIndex = 1;
            this.güncelle_btn.Text = "Ders Sil";
            this.güncelle_btn.UseVisualStyleBackColor = false;
            this.güncelle_btn.Click += new System.EventHandler(this.güncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sil_btn.Location = new System.Drawing.Point(794, 182);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(160, 78);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "Ders Güncelle";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // listele_btn
            // 
            this.listele_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listele_btn.Location = new System.Drawing.Point(102, 504);
            this.listele_btn.Name = "listele_btn";
            this.listele_btn.Size = new System.Drawing.Size(183, 78);
            this.listele_btn.TabIndex = 3;
            this.listele_btn.Text = "Dersleri Listele";
            this.listele_btn.UseVisualStyleBackColor = false;
            this.listele_btn.Click += new System.EventHandler(this.listele_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(780, 316);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(733, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Uygulamayı Sonlandır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transkript_btn
            // 
            this.transkript_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transkript_btn.Location = new System.Drawing.Point(393, 504);
            this.transkript_btn.Name = "transkript_btn";
            this.transkript_btn.Size = new System.Drawing.Size(169, 78);
            this.transkript_btn.TabIndex = 9;
            this.transkript_btn.Text = "Transkript";
            this.transkript_btn.UseVisualStyleBackColor = false;
            this.transkript_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // resim_bx
            // 
            this.resim_bx.Image = global::Ödev2.Properties.Resources.images;
            this.resim_bx.Location = new System.Drawing.Point(175, 12);
            this.resim_bx.Name = "resim_bx";
            this.resim_bx.Size = new System.Drawing.Size(460, 164);
            this.resim_bx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim_bx.TabIndex = 10;
            this.resim_bx.TabStop = false;
            this.resim_bx.Click += new System.EventHandler(this.resim_bx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 590);
            this.Controls.Add(this.resim_bx);
            this.Controls.Add(this.transkript_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listele_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.güncelle_btn);
            this.Controls.Add(this.ekle_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim_bx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ekle_btn;
        private Button güncelle_btn;
        private Button sil_btn;
        private Button listele_btn;
        private DataGridView dataGridView1;
        private Button button1;
        private Button transkript_btn;
        private PictureBox resim_bx;
    }
}