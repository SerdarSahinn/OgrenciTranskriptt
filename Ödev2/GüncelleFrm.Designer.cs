namespace Ödev2
{
    partial class GüncelleFrm
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
            this.txt = new System.Windows.Forms.TextBox();
            this.dersgoruntule_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iptl_btn = new System.Windows.Forms.Button();
            this.gnc_btn = new System.Windows.Forms.Button();
            this.txtnotu = new System.Windows.Forms.TextBox();
            this.txtdonem = new System.Windows.Forms.TextBox();
            this.txtdersogretmen = new System.Windows.Forms.TextBox();
            this.txtdersakts = new System.Windows.Forms.TextBox();
            this.txtderskredi = new System.Windows.Forms.TextBox();
            this.txtdersadı = new System.Windows.Forms.TextBox();
            this.txtDerskodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kodu";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(118, 129);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(125, 27);
            this.txt.TabIndex = 1;
            // 
            // dersgoruntule_btn
            // 
            this.dersgoruntule_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dersgoruntule_btn.Location = new System.Drawing.Point(38, 192);
            this.dersgoruntule_btn.Name = "dersgoruntule_btn";
            this.dersgoruntule_btn.Size = new System.Drawing.Size(161, 91);
            this.dersgoruntule_btn.TabIndex = 2;
            this.dersgoruntule_btn.Text = "Dersi Görüntüle";
            this.dersgoruntule_btn.UseVisualStyleBackColor = false;
            this.dersgoruntule_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.iptl_btn);
            this.groupBox1.Controls.Add(this.gnc_btn);
            this.groupBox1.Controls.Add(this.txtnotu);
            this.groupBox1.Controls.Add(this.txtdonem);
            this.groupBox1.Controls.Add(this.txtdersogretmen);
            this.groupBox1.Controls.Add(this.txtdersakts);
            this.groupBox1.Controls.Add(this.txtderskredi);
            this.groupBox1.Controls.Add(this.txtdersadı);
            this.groupBox1.Controls.Add(this.txtDerskodu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(249, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelleme İşlemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(601, 279);
            this.dataGridView1.TabIndex = 31;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(270, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 113);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // iptl_btn
            // 
            this.iptl_btn.BackColor = System.Drawing.Color.Red;
            this.iptl_btn.Location = new System.Drawing.Point(159, 334);
            this.iptl_btn.Name = "iptl_btn";
            this.iptl_btn.Size = new System.Drawing.Size(105, 51);
            this.iptl_btn.TabIndex = 29;
            this.iptl_btn.Text = "İPTAL";
            this.iptl_btn.UseVisualStyleBackColor = false;
            this.iptl_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // gnc_btn
            // 
            this.gnc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gnc_btn.Location = new System.Drawing.Point(31, 334);
            this.gnc_btn.Name = "gnc_btn";
            this.gnc_btn.Size = new System.Drawing.Size(94, 51);
            this.gnc_btn.TabIndex = 28;
            this.gnc_btn.Text = "GÜNCELLE";
            this.gnc_btn.UseVisualStyleBackColor = false;
            this.gnc_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnotu
            // 
            this.txtnotu.Location = new System.Drawing.Point(139, 273);
            this.txtnotu.Name = "txtnotu";
            this.txtnotu.Size = new System.Drawing.Size(125, 27);
            this.txtnotu.TabIndex = 27;
            // 
            // txtdonem
            // 
            this.txtdonem.Location = new System.Drawing.Point(139, 230);
            this.txtdonem.Name = "txtdonem";
            this.txtdonem.Size = new System.Drawing.Size(125, 27);
            this.txtdonem.TabIndex = 26;
            // 
            // txtdersogretmen
            // 
            this.txtdersogretmen.Location = new System.Drawing.Point(139, 182);
            this.txtdersogretmen.Name = "txtdersogretmen";
            this.txtdersogretmen.Size = new System.Drawing.Size(125, 27);
            this.txtdersogretmen.TabIndex = 25;
            // 
            // txtdersakts
            // 
            this.txtdersakts.Location = new System.Drawing.Point(139, 140);
            this.txtdersakts.Name = "txtdersakts";
            this.txtdersakts.Size = new System.Drawing.Size(125, 27);
            this.txtdersakts.TabIndex = 24;
            // 
            // txtderskredi
            // 
            this.txtderskredi.Location = new System.Drawing.Point(139, 102);
            this.txtderskredi.Name = "txtderskredi";
            this.txtderskredi.Size = new System.Drawing.Size(125, 27);
            this.txtderskredi.TabIndex = 23;
            // 
            // txtdersadı
            // 
            this.txtdersadı.Location = new System.Drawing.Point(139, 66);
            this.txtdersadı.Name = "txtdersadı";
            this.txtdersadı.Size = new System.Drawing.Size(125, 27);
            this.txtdersadı.TabIndex = 22;
            // 
            // txtDerskodu
            // 
            this.txtDerskodu.Location = new System.Drawing.Point(139, 26);
            this.txtDerskodu.Name = "txtDerskodu";
            this.txtDerskodu.Size = new System.Drawing.Size(125, 27);
            this.txtDerskodu.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ders Notu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ders Dönem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ders Öğretmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ders Akts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ders Kredi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ders Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ders Kodu";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(38, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Geri Dön";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GüncelleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dersgoruntule_btn);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "GüncelleFrm";
            this.Text = "GüncelleFrm";
            this.Load += new System.EventHandler(this.GüncelleFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt;
        private Button dersgoruntule_btn;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ListView listView1;
        private Button iptl_btn;
        private Button gnc_btn;
        private TextBox txtnotu;
        private TextBox txtdonem;
        private TextBox txtdersogretmen;
        private TextBox txtdersakts;
        private TextBox txtderskredi;
        private TextBox txtdersadı;
        private TextBox txtDerskodu;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Button button4;
    }
}