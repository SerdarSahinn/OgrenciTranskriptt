namespace Ödev2
{
    partial class TranskriptFrm
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
            this.Transkrit_BTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snc_txt = new System.Windows.Forms.TextBox();
            this.kredi_lbl = new System.Windows.Forms.Label();
            this.krdsnc_txt = new System.Windows.Forms.TextBox();
            this.geri__BTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donem3_txt = new System.Windows.Forms.TextBox();
            this.donem2_txt = new System.Windows.Forms.TextBox();
            this.donem1_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transkrit_BTN
            // 
            this.Transkrit_BTN.BackColor = System.Drawing.Color.Lime;
            this.Transkrit_BTN.Location = new System.Drawing.Point(-4, 183);
            this.Transkrit_BTN.Name = "Transkrit_BTN";
            this.Transkrit_BTN.Size = new System.Drawing.Size(157, 74);
            this.Transkrit_BTN.TabIndex = 0;
            this.Transkrit_BTN.Text = "Transkripti Görüntüle";
            this.Transkrit_BTN.UseVisualStyleBackColor = false;
            this.Transkrit_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(668, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // snc_txt
            // 
            this.snc_txt.Location = new System.Drawing.Point(509, 455);
            this.snc_txt.Name = "snc_txt";
            this.snc_txt.Size = new System.Drawing.Size(125, 27);
            this.snc_txt.TabIndex = 12;
            this.snc_txt.TextChanged += new System.EventHandler(this.snc_txt_TextChanged);
            // 
            // kredi_lbl
            // 
            this.kredi_lbl.AutoSize = true;
            this.kredi_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kredi_lbl.Location = new System.Drawing.Point(360, 405);
            this.kredi_lbl.Name = "kredi_lbl";
            this.kredi_lbl.Size = new System.Drawing.Size(122, 25);
            this.kredi_lbl.TabIndex = 13;
            this.kredi_lbl.Text = "Toplam Kredi";
            // 
            // krdsnc_txt
            // 
            this.krdsnc_txt.Location = new System.Drawing.Point(509, 403);
            this.krdsnc_txt.Name = "krdsnc_txt";
            this.krdsnc_txt.Size = new System.Drawing.Size(125, 27);
            this.krdsnc_txt.TabIndex = 14;
            // 
            // geri__BTN
            // 
            this.geri__BTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.geri__BTN.Location = new System.Drawing.Point(12, 455);
            this.geri__BTN.Name = "geri__BTN";
            this.geri__BTN.Size = new System.Drawing.Size(94, 29);
            this.geri__BTN.TabIndex = 15;
            this.geri__BTN.Text = "Geri Dön";
            this.geri__BTN.UseVisualStyleBackColor = false;
            this.geri__BTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.krdsnc_txt);
            this.groupBox1.Controls.Add(this.snc_txt);
            this.groupBox1.Controls.Add(this.kredi_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.donem1_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.donem3_txt);
            this.groupBox1.Controls.Add(this.donem2_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(213, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 567);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transkript";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(337, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Genel Not Ortalamsı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dönem Ortalamaları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "2022/1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "2021/2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "2021/1";
            // 
            // donem3_txt
            // 
            this.donem3_txt.Location = new System.Drawing.Point(81, 531);
            this.donem3_txt.Name = "donem3_txt";
            this.donem3_txt.Size = new System.Drawing.Size(125, 27);
            this.donem3_txt.TabIndex = 19;
            // 
            // donem2_txt
            // 
            this.donem2_txt.Location = new System.Drawing.Point(175, 459);
            this.donem2_txt.Name = "donem2_txt";
            this.donem2_txt.Size = new System.Drawing.Size(125, 27);
            this.donem2_txt.TabIndex = 18;
            // 
            // donem1_txt
            // 
            this.donem1_txt.Location = new System.Drawing.Point(15, 459);
            this.donem1_txt.Name = "donem1_txt";
            this.donem1_txt.Size = new System.Drawing.Size(125, 27);
            this.donem1_txt.TabIndex = 17;
            // 
            // TranskriptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.geri__BTN);
            this.Controls.Add(this.Transkrit_BTN);
            this.Name = "TranskriptFrm";
            this.Text = "TranskriptFrm";
            this.Load += new System.EventHandler(this.TranskriptFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Transkrit_BTN;
        private DataGridView dataGridView1;
        private TextBox snc_txt;
        private Label kredi_lbl;
        private TextBox krdsnc_txt;
        private Button geri__BTN;
        private GroupBox groupBox1;
        private TextBox donem3_txt;
        private TextBox donem2_txt;
        private TextBox donem1_txt;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}