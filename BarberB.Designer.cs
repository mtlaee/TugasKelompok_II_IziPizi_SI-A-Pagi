
namespace TugasKelompok_II_IziPizi_SI_A_Pagi
{
    partial class BarberB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarberB));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLaporan = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.timWaktu = new System.Windows.Forms.Timer(this.components);
            this.pnlgariKiri = new System.Windows.Forms.Panel();
            this.pnlgarisAtas = new System.Windows.Forms.Panel();
            this.pnlgarisKanan = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnLaporanPembayaran = new System.Windows.Forms.Button();
            this.btnInfoBooking = new System.Windows.Forms.Button();
            this.btnCabang = new System.Windows.Forms.Button();
            this.btnDaftarPaketLayanan = new System.Windows.Forms.Button();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnLaporanKaryawan = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlLaporan.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnLaporan);
            this.pnlMenu.Controls.Add(this.btnPembayaran);
            this.pnlMenu.Controls.Add(this.btnMain);
            this.pnlMenu.Controls.Add(this.btnBooking);
            this.pnlMenu.Controls.Add(this.pnlLaporan);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(231, 797);
            this.pnlMenu.TabIndex = 4;
            // 
            // pnlLaporan
            // 
            this.pnlLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlLaporan.Controls.Add(this.btnLaporanPembayaran);
            this.pnlLaporan.Controls.Add(this.btnInfoBooking);
            this.pnlLaporan.Controls.Add(this.btnCabang);
            this.pnlLaporan.Controls.Add(this.btnDaftarPaketLayanan);
            this.pnlLaporan.Controls.Add(this.btnPelanggan);
            this.pnlLaporan.Controls.Add(this.btnLaporanKaryawan);
            this.pnlLaporan.Location = new System.Drawing.Point(3, 372);
            this.pnlLaporan.Name = "pnlLaporan";
            this.pnlLaporan.Size = new System.Drawing.Size(222, 326);
            this.pnlLaporan.TabIndex = 6;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlUser.Controls.Add(this.panel5);
            this.pnlUser.Controls.Add(this.pictureBox2);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(231, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1049, 92);
            this.pnlUser.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel5.Controls.Add(this.lblUser);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(881, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(126, 92);
            this.panel5.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(126, 92);
            this.lblUser.TabIndex = 16;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timWaktu
            // 
            this.timWaktu.Tick += new System.EventHandler(this.timWaktu_Tick);
            // 
            // pnlgariKiri
            // 
            this.pnlgariKiri.BackColor = System.Drawing.Color.Gray;
            this.pnlgariKiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlgariKiri.Location = new System.Drawing.Point(231, 92);
            this.pnlgariKiri.Name = "pnlgariKiri";
            this.pnlgariKiri.Size = new System.Drawing.Size(1, 705);
            this.pnlgariKiri.TabIndex = 9;
            // 
            // pnlgarisAtas
            // 
            this.pnlgarisAtas.BackColor = System.Drawing.Color.Silver;
            this.pnlgarisAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlgarisAtas.Location = new System.Drawing.Point(232, 92);
            this.pnlgarisAtas.Name = "pnlgarisAtas";
            this.pnlgarisAtas.Size = new System.Drawing.Size(1048, 1);
            this.pnlgarisAtas.TabIndex = 10;
            // 
            // pnlgarisKanan
            // 
            this.pnlgarisKanan.BackColor = System.Drawing.Color.Gray;
            this.pnlgarisKanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlgarisKanan.Location = new System.Drawing.Point(1279, 93);
            this.pnlgarisKanan.Name = "pnlgarisKanan";
            this.pnlgarisKanan.Size = new System.Drawing.Size(1, 704);
            this.pnlgarisKanan.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.reviewer_32;
            this.pictureBox2.Location = new System.Drawing.Point(1007, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.logout_32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 741);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(231, 56);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.AutoSize = true;
            this.btnLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.paper_32__1_;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(3, 310);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(225, 56);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.AutoSize = true;
            this.btnPembayaran.BackColor = System.Drawing.Color.Transparent;
            this.btnPembayaran.FlatAppearance.BorderSize = 0;
            this.btnPembayaran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPembayaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.ForeColor = System.Drawing.Color.White;
            this.btnPembayaran.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.banknotes_32;
            this.btnPembayaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPembayaran.Location = new System.Drawing.Point(-2, 229);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(231, 56);
            this.btnPembayaran.TabIndex = 3;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = false;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // btnMain
            // 
            this.btnMain.AutoSize = true;
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImage = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.IMG_20210115_182104;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Transparent;
            this.btnMain.Location = new System.Drawing.Point(0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(231, 147);
            this.btnMain.TabIndex = 2;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.AutoSize = true;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.purchase_order_32;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(0, 153);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(231, 56);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnLaporanPembayaran
            // 
            this.btnLaporanPembayaran.AutoSize = true;
            this.btnLaporanPembayaran.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporanPembayaran.FlatAppearance.BorderSize = 0;
            this.btnLaporanPembayaran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaporanPembayaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLaporanPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporanPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanPembayaran.ForeColor = System.Drawing.Color.White;
            this.btnLaporanPembayaran.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.money_24;
            this.btnLaporanPembayaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporanPembayaran.Location = new System.Drawing.Point(5, 272);
            this.btnLaporanPembayaran.Name = "btnLaporanPembayaran";
            this.btnLaporanPembayaran.Size = new System.Drawing.Size(205, 47);
            this.btnLaporanPembayaran.TabIndex = 12;
            this.btnLaporanPembayaran.Text = "Pembayaran";
            this.btnLaporanPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaporanPembayaran.UseVisualStyleBackColor = false;
            this.btnLaporanPembayaran.Click += new System.EventHandler(this.btnLaporanPembayaran_Click);
            // 
            // btnInfoBooking
            // 
            this.btnInfoBooking.AutoSize = true;
            this.btnInfoBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoBooking.FlatAppearance.BorderSize = 0;
            this.btnInfoBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfoBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnInfoBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoBooking.ForeColor = System.Drawing.Color.White;
            this.btnInfoBooking.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.purchase_order_24;
            this.btnInfoBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoBooking.Location = new System.Drawing.Point(5, 219);
            this.btnInfoBooking.Name = "btnInfoBooking";
            this.btnInfoBooking.Size = new System.Drawing.Size(205, 47);
            this.btnInfoBooking.TabIndex = 11;
            this.btnInfoBooking.Text = "Laporan Booking";
            this.btnInfoBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoBooking.UseVisualStyleBackColor = false;
            this.btnInfoBooking.Click += new System.EventHandler(this.btnInfoBooking_Click);
            // 
            // btnCabang
            // 
            this.btnCabang.AutoSize = true;
            this.btnCabang.BackColor = System.Drawing.Color.Transparent;
            this.btnCabang.FlatAppearance.BorderSize = 0;
            this.btnCabang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCabang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCabang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabang.ForeColor = System.Drawing.Color.White;
            this.btnCabang.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.barbers_pole_24;
            this.btnCabang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCabang.Location = new System.Drawing.Point(5, 166);
            this.btnCabang.Name = "btnCabang";
            this.btnCabang.Size = new System.Drawing.Size(205, 47);
            this.btnCabang.TabIndex = 10;
            this.btnCabang.Text = "Cabang";
            this.btnCabang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCabang.UseVisualStyleBackColor = false;
            this.btnCabang.Click += new System.EventHandler(this.btnCabang_Click);
            // 
            // btnDaftarPaketLayanan
            // 
            this.btnDaftarPaketLayanan.AutoSize = true;
            this.btnDaftarPaketLayanan.BackColor = System.Drawing.Color.Transparent;
            this.btnDaftarPaketLayanan.FlatAppearance.BorderSize = 0;
            this.btnDaftarPaketLayanan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDaftarPaketLayanan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDaftarPaketLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftarPaketLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarPaketLayanan.ForeColor = System.Drawing.Color.White;
            this.btnDaftarPaketLayanan.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.barber_shop_24;
            this.btnDaftarPaketLayanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaftarPaketLayanan.Location = new System.Drawing.Point(5, 12);
            this.btnDaftarPaketLayanan.Name = "btnDaftarPaketLayanan";
            this.btnDaftarPaketLayanan.Size = new System.Drawing.Size(205, 47);
            this.btnDaftarPaketLayanan.TabIndex = 9;
            this.btnDaftarPaketLayanan.Text = "Daftar Paket";
            this.btnDaftarPaketLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDaftarPaketLayanan.UseVisualStyleBackColor = false;
            this.btnDaftarPaketLayanan.Click += new System.EventHandler(this.btnDaftarPaketLayanan_Click);
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.AutoSize = true;
            this.btnPelanggan.BackColor = System.Drawing.Color.Transparent;
            this.btnPelanggan.FlatAppearance.BorderSize = 0;
            this.btnPelanggan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPelanggan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnPelanggan.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.conference_24;
            this.btnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelanggan.Location = new System.Drawing.Point(5, 113);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(205, 47);
            this.btnPelanggan.TabIndex = 8;
            this.btnPelanggan.Text = "Pelanggan";
            this.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPelanggan.UseVisualStyleBackColor = false;
            this.btnPelanggan.Click += new System.EventHandler(this.btnPelanggan_Click);
            // 
            // btnLaporanKaryawan
            // 
            this.btnLaporanKaryawan.AutoSize = true;
            this.btnLaporanKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporanKaryawan.FlatAppearance.BorderSize = 0;
            this.btnLaporanKaryawan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaporanKaryawan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLaporanKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporanKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnLaporanKaryawan.Image = global::TugasKelompok_II_IziPizi_SI_A_Pagi.Properties.Resources.group_24;
            this.btnLaporanKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporanKaryawan.Location = new System.Drawing.Point(5, 60);
            this.btnLaporanKaryawan.Name = "btnLaporanKaryawan";
            this.btnLaporanKaryawan.Size = new System.Drawing.Size(205, 47);
            this.btnLaporanKaryawan.TabIndex = 7;
            this.btnLaporanKaryawan.Text = "Karyawan";
            this.btnLaporanKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaporanKaryawan.UseVisualStyleBackColor = false;
            this.btnLaporanKaryawan.Click += new System.EventHandler(this.btnLaporanKaryawan_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.Controls.Add(this.lblWaktu);
            this.pnlMain.Controls.Add(this.picLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1280, 797);
            this.pnlMain.TabIndex = 11;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(390, 229);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(737, 361);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblWaktu
            // 
            this.lblWaktu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWaktu.BackColor = System.Drawing.Color.Transparent;
            this.lblWaktu.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.ForeColor = System.Drawing.Color.White;
            this.lblWaktu.Location = new System.Drawing.Point(645, 606);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(238, 41);
            this.lblWaktu.TabIndex = 20;
            this.lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarberB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 797);
            this.Controls.Add(this.pnlgarisKanan);
            this.Controls.Add(this.pnlgarisAtas);
            this.Controls.Add(this.pnlgariKiri);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarberB";
            this.Text = "Andi Barbershop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarberB_FormClosing);
            this.Load += new System.EventHandler(this.BarberB_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLaporan.ResumeLayout(false);
            this.pnlLaporan.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnlUser;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Timer timWaktu;
        private System.Windows.Forms.Panel pnlgariKiri;
        private System.Windows.Forms.Panel pnlgarisAtas;
        private System.Windows.Forms.Panel pnlgarisKanan;
        private System.Windows.Forms.Panel pnlLaporan;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLaporanKaryawan;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnDaftarPaketLayanan;
        private System.Windows.Forms.Button btnCabang;
        private System.Windows.Forms.Button btnInfoBooking;
        private System.Windows.Forms.Button btnLaporanPembayaran;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWaktu;
    }
}