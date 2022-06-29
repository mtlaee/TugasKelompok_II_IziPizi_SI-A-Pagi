
namespace TugasKelompok_II_IziPizi_SI_A_Pagi
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCabangID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpWaktu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKaryawanID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.btnSearchKaryawanID = new System.Windows.Forms.Button();
            this.btnSearcBooking = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteDatabase = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.mnuclose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(580, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nama            :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "CabangID      :";
            // 
            // txtCabangID
            // 
            this.txtCabangID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabangID.ForeColor = System.Drawing.Color.Black;
            this.txtCabangID.Location = new System.Drawing.Point(153, 85);
            this.txtCabangID.Name = "txtCabangID";
            this.txtCabangID.ReadOnly = true;
            this.txtCabangID.Size = new System.Drawing.Size(203, 28);
            this.txtCabangID.TabIndex = 39;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(711, 85);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(202, 28);
            this.txtNama.TabIndex = 27;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(153, 131);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(202, 28);
            this.dtpTanggal.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tanggal        :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(583, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Waktu           :";
            // 
            // dtpWaktu
            // 
            this.dtpWaktu.CustomFormat = "hh:mm:ss:tt";
            this.dtpWaktu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWaktu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWaktu.Location = new System.Drawing.Point(711, 128);
            this.dtpWaktu.Name = "dtpWaktu";
            this.dtpWaktu.ShowUpDown = true;
            this.dtpWaktu.Size = new System.Drawing.Size(202, 28);
            this.dtpWaktu.TabIndex = 31;
            this.dtpWaktu.Value = new System.DateTime(2021, 1, 15, 20, 59, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "KaryawanID  :";
            // 
            // txtKaryawanID
            // 
            this.txtKaryawanID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaryawanID.Location = new System.Drawing.Point(154, 41);
            this.txtKaryawanID.Name = "txtKaryawanID";
            this.txtKaryawanID.Size = new System.Drawing.Size(202, 28);
            this.txtKaryawanID.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "BookingID     :";
            // 
            // txtBooking
            // 
            this.txtBooking.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooking.ForeColor = System.Drawing.Color.Black;
            this.txtBooking.Location = new System.Drawing.Point(711, 41);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(202, 28);
            this.txtBooking.TabIndex = 45;
            // 
            // btnSearchKaryawanID
            // 
            this.btnSearchKaryawanID.AutoSize = true;
            this.btnSearchKaryawanID.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchKaryawanID.FlatAppearance.BorderSize = 0;
            this.btnSearchKaryawanID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearchKaryawanID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSearchKaryawanID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchKaryawanID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchKaryawanID.ForeColor = System.Drawing.Color.Red;
            this.btnSearchKaryawanID.Location = new System.Drawing.Point(373, 26);
            this.btnSearchKaryawanID.Name = "btnSearchKaryawanID";
            this.btnSearchKaryawanID.Size = new System.Drawing.Size(52, 46);
            this.btnSearchKaryawanID.TabIndex = 41;
            this.btnSearchKaryawanID.Text = "...";
            this.btnSearchKaryawanID.UseVisualStyleBackColor = false;
            this.btnSearchKaryawanID.Click += new System.EventHandler(this.btnSearchKaryawanID_Click);
            // 
            // btnSearcBooking
            // 
            this.btnSearcBooking.AutoSize = true;
            this.btnSearcBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnSearcBooking.FlatAppearance.BorderSize = 0;
            this.btnSearcBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearcBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSearcBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearcBooking.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearcBooking.ForeColor = System.Drawing.Color.Red;
            this.btnSearcBooking.Location = new System.Drawing.Point(932, 26);
            this.btnSearcBooking.Name = "btnSearcBooking";
            this.btnSearcBooking.Size = new System.Drawing.Size(52, 46);
            this.btnSearcBooking.TabIndex = 46;
            this.btnSearcBooking.Text = "...";
            this.btnSearcBooking.UseVisualStyleBackColor = false;
            this.btnSearcBooking.Click += new System.EventHandler(this.btnSearcBooking_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(19, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 1);
            this.panel4.TabIndex = 48;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuclose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.available_updates_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(290, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 56);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.AutoSize = true;
            this.btnDeleteDatabase.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteDatabase.FlatAppearance.BorderSize = 0;
            this.btnDeleteDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDeleteDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDatabase.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDatabase.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.trash_2_32;
            this.btnDeleteDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDatabase.Location = new System.Drawing.Point(509, 210);
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(196, 56);
            this.btnDeleteDatabase.TabIndex = 49;
            this.btnDeleteDatabase.Text = "Delete";
            this.btnDeleteDatabase.UseVisualStyleBackColor = false;
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.AutoSize = true;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(43, 212);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(219, 56);
            this.btnBooking.TabIndex = 32;
            this.btnBooking.Text = "Booking Now";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // mnuclose
            // 
            this.mnuclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuclose.Image = ((System.Drawing.Image)(resources.GetObject("mnuclose.Image")));
            this.mnuclose.Name = "mnuclose";
            this.mnuclose.Size = new System.Drawing.Size(34, 24);
            this.mnuclose.Click += new System.EventHandler(this.mnuclose_Click);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1049, 300);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnDeleteDatabase);
            this.Controls.Add(this.btnSearcBooking);
            this.Controls.Add(this.txtBooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKaryawanID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchKaryawanID);
            this.Controls.Add(this.txtCabangID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.dtpWaktu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchKaryawanID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearcBooking;
        private System.Windows.Forms.Button btnDeleteDatabase;
        public System.Windows.Forms.TextBox txtCabangID;
        public System.Windows.Forms.TextBox txtKaryawanID;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.DateTimePicker dtpTanggal;
        public System.Windows.Forms.DateTimePicker dtpWaktu;
        public System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuclose;
    }
}