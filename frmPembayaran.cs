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
    public partial class frmPembayaran : Form
    {
        public frmPembayaran()
        {
            InitializeComponent();
        }

        frmPelanggan pelanggan;
        public frmPembayaran(frmPelanggan pelanggan)
        {
            InitializeComponent();
            this.pelanggan = pelanggan;
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds,dscristalreport;
        DataColumn[] dc = new DataColumn[1];
        DataRow dr;
        SqlCommandBuilder cb;

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

        private void frmPembayaran_Load(object sender, EventArgs e)
        {
            koneksi();
            lblCabangID.Text = pelanggan.lblCabangID.Text;
            txtPelangganID.ReadOnly = true;
            txtNama.ReadOnly = true;
            txtNotelp.ReadOnly = true;
            txtPelangganID.Text = pelanggan.txtPelangganID.Text;
            txtNama.Text = pelanggan.txtNama.Text;
            txtNotelp.Text = pelanggan.txtNotelp.Text;
            txtKode.MaxLength = 4;
            txtKaryawan.MaxLength = 5;
            txtPaketID.MaxLength = 6;
            loaddatalogistic();
        }

        private void loaddata()
        {
            ds = new DataSet();
            query = "Select * From Pembayaran";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pembayaran");
            dc[0] = ds.Tables["Pembayaran"].Columns[0];
            ds.Tables["Pembayaran"].PrimaryKey = dc;
        }

        private void loaddatalogistic()
        {
            dscristalreport = new DataSet();
            query = "Select * From Pembayaran WHERE KodePembayaran ='"+txtKode.Text+"'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dscristalreport, "Pembayaran");
        }
        private void updatedata()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pembayaran"]);           
        }

        private void btnSearchKode_Click(object sender, EventArgs e)
        {
            Browse.frmBrowsePembayaran pembayaran = new Browse.frmBrowsePembayaran(this);
            pembayaran.ShowDialog();
        }

        private void btnSearchKaryawanID_Click(object sender, EventArgs e)
        {
            Browse.frmBrowseKaryawan karyawan = new Browse.frmBrowseKaryawan(this);
            karyawan.Tag = this;
            karyawan.ShowDialog();
        }

        private void btnSearchPaketID_Click(object sender, EventArgs e)
        {
            Browse.frmBrowsePaket paket = new Browse.frmBrowsePaket(this);
            paket.ShowDialog();
        }

        private void bersih()
        {
            txtKode.Clear();
            txtKaryawan.Clear();
            dtpTanggal.Value = DateTime.Today;
            txtPaketID.Clear();
            lblTotal.Text = "";
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            loaddata();
            dr = ds.Tables["Pembayaran"].Rows.Find(txtKode.Text);
            if(dr == null)
            {
                if (!string.IsNullOrEmpty(txtKode.Text) && !string.IsNullOrWhiteSpace(txtKaryawan.Text) && !string.IsNullOrWhiteSpace(txtPaketID.Text))
                {
                    dr = ds.Tables["Pembayaran"].NewRow();
                    dr[0] = txtKode.Text;
                    dr[1] = txtPaketID.Text;
                    dr[2] = lblCabangID.Text;
                    dr[3] = txtPelangganID.Text;
                    dr[4] = txtNama.Text;
                    dr[5] = txtKaryawan.Text;
                    dr[6] = lblTotal.Text;
                    dr[7] = dtpTanggal.Value;
                    ds.Tables["Pembayaran"].Rows.Add(dr);
                    updatedata();
                    MessageBox.Show("Kode Pembayaran " + txtKode.Text + " Berhasil Ditambahkan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                }
                else
                {
                    MessageBox.Show( "Sebagian Data Kosong.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bersih();
                }
            }
            else
            {
                MessageBox.Show("Kode Pembayaran " + txtKode.Text + " Data Sudah Ada.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bersih();
            }

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKode.Text) && !string.IsNullOrWhiteSpace(txtKaryawan.Text) && !string.IsNullOrWhiteSpace(txtPaketID.Text))
            {
                Report.crFakturPembayaran cr = new Report.crFakturPembayaran();
                Report.frmViewr viewr = new Report.frmViewr();
                loaddatalogistic();
                cr.SetDataSource(dscristalreport);
                viewr.crystalReportViewer1.ReportSource = cr;
                viewr.WindowState = FormWindowState.Maximized;
                viewr.Show();
            }
            else
            {
                MessageBox.Show("Sebagian Data Kosong.", "Faktur Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bersih();
            }
                
        }

        private void mnuclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            loaddata();
            dr = ds.Tables["Pembayaran"].Rows.Find(txtKode.Text);
            if (dr != null)
            {
                dr[1] = txtPaketID.Text;
                dr[2] = lblCabangID.Text;
                dr[3] = txtPelangganID.Text;
                dr[4] = txtNama.Text;
                dr[5] = txtKaryawan.Text;
                dr[6] = lblTotal.Text;
                dr[7] = dtpTanggal.Value;
                updatedata();
                MessageBox.Show("Kode Pembayaran " + txtKode.Text + " BerhasiL Update.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
            }
            else
            {
                MessageBox.Show("Kode Pembayaran " + txtKode.Text + " Tidak Ada.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bersih();
            }
        }
    }
}
