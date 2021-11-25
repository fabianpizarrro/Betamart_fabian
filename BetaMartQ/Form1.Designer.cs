
namespace BetaMartQ
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btTambah = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.betafabsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betaData = new BetaMartQ.betamartdbDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.betafabsTableAdapter = new BetaMartQ.betamartdbDataSetTableAdapters.betafabsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.tbMerk = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDBarangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merekBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBarangDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.betafabsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(227, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "BetaMart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(330, 226);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(73, 20);
            this.btTambah.TabIndex = 9;
            this.btTambah.Text = "Add";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(571, 226);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 20);
            this.btReset.TabIndex = 10;
            this.btReset.Text = "Cancel";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(409, 226);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 20);
            this.btNew.TabIndex = 11;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(490, 226);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 20);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // betafabsBindingSource
            // 
            this.betafabsBindingSource.DataMember = "betafabs";
            this.betafabsBindingSource.DataSource = this.betaData;
            // 
            // betaData
            // 
            this.betaData.DataSetName = "betaData";
            this.betaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(244, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Barang";
            // 
            // betafabsTableAdapter
            // 
            this.betafabsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga Barang";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kode Barang";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Barang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Deskripsi Barang";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betafabsBindingSource, "Harga barang", true));
            this.tbHarga.Location = new System.Drawing.Point(131, 128);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(376, 20);
            this.tbHarga.TabIndex = 16;
            this.tbHarga.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betafabsBindingSource, "Deskripsi Barang", true));
            this.tbDeskripsi.Location = new System.Drawing.Point(131, 83);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(376, 39);
            this.tbDeskripsi.TabIndex = 4;
            this.tbDeskripsi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betafabsBindingSource, "Nama Barang", true));
            this.tbNama.Location = new System.Drawing.Point(131, 30);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(376, 20);
            this.tbNama.TabIndex = 2;
            this.tbNama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbId
            // 
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betafabsBindingSource, "ID Barang", true));
            this.tbId.Location = new System.Drawing.Point(131, 5);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(376, 20);
            this.tbId.TabIndex = 0;
            this.tbId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Merek Barang";
            // 
            // tbKode
            // 
            this.tbKode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betafabsBindingSource, "Kode Barang", true));
            this.tbKode.Location = new System.Drawing.Point(131, 56);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(376, 20);
            this.tbKode.TabIndex = 3;
            this.tbKode.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbMerk
            // 
            this.tbMerk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betafabsBindingSource, "Merek Barang", true));
            this.tbMerk.Location = new System.Drawing.Point(131, 152);
            this.tbMerk.Name = "tbMerk";
            this.tbMerk.Size = new System.Drawing.Size(376, 20);
            this.tbMerk.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbNama);
            this.panel1.Controls.Add(this.tbMerk);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbKode);
            this.panel1.Controls.Add(this.tbDeskripsi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(2, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 179);
            this.panel1.TabIndex = 21;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(538, 152);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.betafabsBindingSource, "Picture Barang", true));
            this.pictureBox1.Location = new System.Drawing.Point(513, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // iDBarangDataGridViewTextBoxColumn
            // 
            this.iDBarangDataGridViewTextBoxColumn.DataPropertyName = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn.Name = "iDBarangDataGridViewTextBoxColumn";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBarangDataGridViewTextBoxColumn1,
            this.namaBarangDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.deskripsiBarangDataGridViewTextBoxColumn,
            this.hargaBarangDataGridViewTextBoxColumn,
            this.merekBarangDataGridViewTextBoxColumn,
            this.pictureBarangDataGridViewImageColumn});
            this.dataGridView.DataSource = this.betafabsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 290);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(633, 243);
            this.dataGridView.TabIndex = 22;
            // 
            // iDBarangDataGridViewTextBoxColumn1
            // 
            this.iDBarangDataGridViewTextBoxColumn1.DataPropertyName = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn1.HeaderText = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn1.Name = "iDBarangDataGridViewTextBoxColumn1";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama Barang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode Barang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang";
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            // 
            // deskripsiBarangDataGridViewTextBoxColumn
            // 
            this.deskripsiBarangDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi Barang";
            this.deskripsiBarangDataGridViewTextBoxColumn.HeaderText = "Deskripsi Barang";
            this.deskripsiBarangDataGridViewTextBoxColumn.Name = "deskripsiBarangDataGridViewTextBoxColumn";
            // 
            // hargaBarangDataGridViewTextBoxColumn
            // 
            this.hargaBarangDataGridViewTextBoxColumn.DataPropertyName = "Harga barang";
            this.hargaBarangDataGridViewTextBoxColumn.HeaderText = "Harga barang";
            this.hargaBarangDataGridViewTextBoxColumn.Name = "hargaBarangDataGridViewTextBoxColumn";
            // 
            // merekBarangDataGridViewTextBoxColumn
            // 
            this.merekBarangDataGridViewTextBoxColumn.DataPropertyName = "Merek Barang";
            this.merekBarangDataGridViewTextBoxColumn.HeaderText = "Merek Barang";
            this.merekBarangDataGridViewTextBoxColumn.Name = "merekBarangDataGridViewTextBoxColumn";
            // 
            // pictureBarangDataGridViewImageColumn
            // 
            this.pictureBarangDataGridViewImageColumn.DataPropertyName = "Picture Barang";
            this.pictureBarangDataGridViewImageColumn.HeaderText = "Picture Barang";
            this.pictureBarangDataGridViewImageColumn.Name = "pictureBarangDataGridViewImageColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(658, 541);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betafabsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label6;
        private betamartdbDataSet betaData;
        private System.Windows.Forms.BindingSource betafabsBindingSource;
        private betamartdbDataSetTableAdapters.betafabsTableAdapter betafabsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.TextBox tbMerk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merekBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureBarangDataGridViewImageColumn;
    }
}

