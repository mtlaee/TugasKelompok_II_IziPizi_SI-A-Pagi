using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TugasKelompok_II_IziPizi_SI_A_Pagi
{
    public partial class BarberB : Form
    {
        public BarberB()
        {
            InitializeComponent();
        }

        frmBarber barbershop;
        public BarberB(frmBarber barbershop)
        {
            InitializeComponent();
            this.barbershop = barbershop;
        }


        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet dskaryawan,dspelanggan,dspaket,dscabang,dsbooking,dslaporanpembayaran;

        private void koneksi()
        {
            try
            {
                constr = "Data Source = localhost\\TAUFIKAKBAR; Initial Catalog = BarbershopAndi; Integrated Security = true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loaddatakaryawan()
        {
            dskaryawan = new DataSet();
            query = "Select * from Karyawan Where CabangID ='" + lblUser.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dskaryawan, "Karyawan");
        }

        private void loaddatapelanggan()
        {
            dspelanggan = new DataSet();
            query = "Select * from Pelanggan Where CabangID ='" + lblUser.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dspelanggan, "Pelanggan");
        }

        private void loaddatapaket()
        {
            dspaket = new DataSet();
            query = "Select * from PaketLayanan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dspaket, "PaketLayanan");
        }

        private void loaddatacabang()
        {
            dscabang = new DataSet();
            query = "Select * FROM Cabang";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dscabang, "Cabang");
        }

        private void boking()
        {
            dsbooking = new DataSet();
            query = "Select * FROM Booking where CabangID ='" + lblUser.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsbooking, "Booking"); 
        }

        private void laporanbayar()
        {
            dslaporanpembayaran = new DataSet();
            query = "Select * FROM Pembayaran where CabangID ='" + lblUser.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dslaporanpembayaran, "Pembayaran");
        }

        private void BarberB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlMain.Show();
            lblWaktu.Text = DateTime.Now.ToString("hh:mm:ss");
            timWaktu.Interval = 1000;
            timWaktu.Enabled = true;
            koneksi();
            loaddatacabang();
            lblUser.Text = barbershop.txtUsername.Text;
            this.IsMdiContainer = true;
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3                  
                    client.BackColor = Color.Black;
                    // 4#
                    break;
                }
            }
            pnlLaporan.Hide();
            loaddatakaryawan();
            loaddatapelanggan();
            boking();
            laporanbayar();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking booking = new frmBooking(this);
            booking.MdiParent = this;
            booking.Show();
            pnlLaporan.Hide();
            pnlMain.Hide();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            pnlMain.Show();
        }     
        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            frmPelanggan pelanggan = new frmPelanggan(this);
            pelanggan.MdiParent = this;
            pelanggan.Show();
            pnlLaporan.Hide();
            pnlMain.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            pnlLaporan.Show();
        }
        private void btnLaporanKaryawan_Click(object sender, EventArgs e)
        {
            Report.crInformasiKaryawan cr = new Report.crInformasiKaryawan();
            Report.frmViewr viewr = new Report.frmViewr();
            loaddatakaryawan();
            cr.SetDataSource(dskaryawan);
            viewr.crystalReportViewer1.ReportSource = cr;
            viewr.WindowState = FormWindowState.Maximized;
            viewr.Show();
            pnlLaporan.Hide();
        }

        private void BarberB_FormClosing(object sender, FormClosingEventArgs e)
        {
            barbershop.Show();
            barbershop.txtUsername.Clear();
            barbershop.txtPassword.Clear();
            barbershop.txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barbershop.Show();
            barbershop.txtUsername.Clear();
            barbershop.txtPassword.Clear();
            barbershop.txtUsername.Focus();
            this.Close();        
        }

        private void timWaktu_Tick(object sender, EventArgs e)
        {
            lblWaktu.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnLaporanPembayaran_Click(object sender, EventArgs e)
        {
            Report.crLaporanPembayaran cr = new Report.crLaporanPembayaran();
            Report.frmViewr viewr = new Report.frmViewr();
            laporanbayar();
            cr.SetDataSource(dslaporanpembayaran);
            viewr.crystalReportViewer1.ReportSource = cr;
            viewr.WindowState = FormWindowState.Maximized;
            viewr.Show();
            pnlLaporan.Hide();
        }

        private void btnInfoBooking_Click(object sender, EventArgs e)
        {
            Report.crLaporanBooking cr = new Report.crLaporanBooking();
            Report.frmViewr viewr = new Report.frmViewr();
            boking();
            cr.SetDataSource(dsbooking);
            viewr.crystalReportViewer1.ReportSource = cr;
            viewr.WindowState = FormWindowState.Maximized;
            viewr.Show();
            pnlLaporan.Hide();
        }

        private void btnCabang_Click(object sender, EventArgs e)
        {
            Report.crInformasiCabang cr = new Report.crInformasiCabang();
            Report.frmViewr viewr = new Report.frmViewr();
            loaddatacabang();
            cr.SetDataSource(dscabang);
            viewr.crystalReportViewer1.ReportSource = cr;
            viewr.WindowState = FormWindowState.Maximized;
            viewr.Show();
            pnlLaporan.Hide();
        }

        private void btnDaftarPaketLayanan_Click(object sender, EventArgs e)
        {
            Report.crDaftarPakerLayanan cr = new Report.crDaftarPakerLayanan();
            Report.frmViewr viewr = new Report.frmViewr();
            loaddatapaket();
            cr.SetDataSource(dspaket);
            viewr.crystalReportViewer1.ReportSource = cr;
            viewr.WindowState = FormWindowState.Maximized;
            viewr.Show();
            pnlLaporan.Hide();
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            Report.crInformasiPelanggan cr = new Report.crInformasiPelanggan();
            Report.frmViewr viewr = new Report.frmViewr();
            loaddatapelanggan();
            cr.SetDataSource(dspelanggan);
            viewr.crystalReportViewer1.ReportSource = cr;
            viewr.WindowState = FormWindowState.Maximized;
            viewr.Show();
            pnlLaporan.Hide();
        }
    }
}
