namespace Ödev2
{
    partial class SilFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sil_txt = new System.Windows.Forms.TextBox();
            this.goster_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iptal_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kodu";
            // 
            // sil_txt
            // 
            this.sil_txt.Location = new System.Drawing.Point(87, 86);
            this.sil_txt.Name = "sil_txt";
            this.sil_txt.Size = new System.Drawing.Size(125, 27);
            this.sil_txt.TabIndex = 1;
            // 
            // goster_btn
            // 
            this.goster_btn.Location = new System.Drawing.Point(47, 152);
            this.goster_btn.Name = "goster_btn";
            this.goster_btn.Size = new System.Drawing.Size(159, 61);
            this.goster_btn.TabIndex = 2;
            this.goster_btn.Text = " Dersi Göster";
            this.goster_btn.UseVisualStyleBackColor = true;
            this.goster_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.iptal_btn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.sil_btn);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 473);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silme İşlemi";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 100);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // iptal_btn
            // 
            this.iptal_btn.BackColor = System.Drawing.Color.Red;
            this.iptal_btn.Location = new System.Drawing.Point(450, 132);
            this.iptal_btn.Name = "iptal_btn";
            this.iptal_btn.Size = new System.Drawing.Size(94, 48);
            this.iptal_btn.TabIndex = 3;
            this.iptal_btn.Text = "İPTAL";
            this.iptal_btn.UseVisualStyleBackColor = false;
            this.iptal_btn.Click += new System.EventHandler(this.iptal_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(664, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.Lime;
            this.sil_btn.Location = new System.Drawing.Point(80, 132);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(94, 48);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.geri_btn.Location = new System.Drawing.Point(32, 456);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(94, 29);
            this.geri_btn.TabIndex = 4;
            this.geri_btn.Text = "Geri Dön";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // SilFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 511);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goster_btn);
            this.Controls.Add(this.sil_txt);
            this.Controls.Add(this.label1);
            this.Name = "SilFrm";
            this.Text = "SilFrm";
            this.Load += new System.EventHandler(this.SilFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox sil_txt;
        private Button goster_btn;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ListView listView1;
        private Button iptal_btn;
        private Button sil_btn;
        private Button geri_btn;
    }
}