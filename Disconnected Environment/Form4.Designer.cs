namespace Disconnected_Environment
{
    partial class DataStatusMahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbNama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.Label();
            this.cbthmasuk = new System.Windows.Forms.Label();
            this.cbxnama = new System.Windows.Forms.ComboBox();
            this.cbxstatus = new System.Windows.Forms.ComboBox();
            this.cbxthmasuk = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbNama
            // 
            this.cbNama.AutoSize = true;
            this.cbNama.Location = new System.Drawing.Point(203, 257);
            this.cbNama.Name = "cbNama";
            this.cbNama.Size = new System.Drawing.Size(91, 13);
            this.cbNama.TabIndex = 1;
            this.cbNama.Text = "Nama Mahasiswa";
            this.cbNama.Click += new System.EventHandler(this.cbNama_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomer Induk Mahasiswa";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(203, 311);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(93, 13);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.Text = "Status Mahasiswa";
            // 
            // cbthmasuk
            // 
            this.cbthmasuk.AutoSize = true;
            this.cbthmasuk.Location = new System.Drawing.Point(203, 342);
            this.cbthmasuk.Name = "cbthmasuk";
            this.cbthmasuk.Size = new System.Drawing.Size(73, 13);
            this.cbthmasuk.TabIndex = 4;
            this.cbthmasuk.Text = "Tahun Masuk";
            this.cbthmasuk.Click += new System.EventHandler(this.cbthmasuk_Click);
            // 
            // cbxnama
            // 
            this.cbxnama.FormattingEnabled = true;
            this.cbxnama.Location = new System.Drawing.Point(328, 254);
            this.cbxnama.Name = "cbxnama";
            this.cbxnama.Size = new System.Drawing.Size(121, 21);
            this.cbxnama.TabIndex = 5;
            // 
            // cbxstatus
            // 
            this.cbxstatus.FormattingEnabled = true;
            this.cbxstatus.Location = new System.Drawing.Point(328, 307);
            this.cbxstatus.Name = "cbxstatus";
            this.cbxstatus.Size = new System.Drawing.Size(121, 21);
            this.cbxstatus.TabIndex = 6;
            // 
            // cbxthmasuk
            // 
            this.cbxthmasuk.FormattingEnabled = true;
            this.cbxthmasuk.Location = new System.Drawing.Point(328, 339);
            this.cbxthmasuk.Name = "cbxthmasuk";
            this.cbxthmasuk.Size = new System.Drawing.Size(121, 21);
            this.cbxthmasuk.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(491, 254);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(491, 301);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(491, 337);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(610, 38);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 11;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(342, 283);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(38, 13);
            this.txtNIM.TabIndex = 12;
            this.txtNIM.Text = "txtNIM";
            // 
            // DataStatusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxthmasuk);
            this.Controls.Add(this.cbxstatus);
            this.Controls.Add(this.cbxnama);
            this.Controls.Add(this.cbthmasuk);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNama);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataStatusMahasiswa";
            this.Text = "DataStatusMahasiswa";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cbStatus;
        private System.Windows.Forms.Label cbthmasuk;
        private System.Windows.Forms.ComboBox cbxnama;
        private System.Windows.Forms.ComboBox cbxstatus;
        private System.Windows.Forms.ComboBox cbxthmasuk;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label txtNIM;
    }
}