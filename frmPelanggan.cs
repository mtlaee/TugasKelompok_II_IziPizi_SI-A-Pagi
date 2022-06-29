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
    public partial class frmPelanggan : Form
    {
        public frmPelanggan()
        {
            InitializeComponent();
        }
        BarberB barber;
        public frmPelanggan(BarberB barber)
        {
            InitializeComponent();
            this.barber = barber;
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataColumn[] dc = new DataColumn[2];
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

        private void loaddata()
        {
            ds = new DataSet();
            query = "Select * From Pelanggan WHERE CabangID ='" + lblCabangID.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            dc[1] = ds.Tables["Pelanggan"].Columns[1];
            ds.Tables["Pelanggan"].PrimaryKey = dc;
        }

        private void updatedata()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pelanggan"]);
        }

        private void bersih()
        {
            txtPelangganID.Clear();
            txtNama.Clear();
            txtNotelp.Clear();
            txtPelangganID.Focus();
        }
        private void frmPelanggan_Load(object sender, EventArgs e)
        {
            koneksi();
            txtPelangganID.MaxLength = 3;
            lblCabangID.Text = barber.lblUser.Text;
        }

        private void btnSearchPelangganID_Click(object sender, EventArgs e)
        {
            Browse.frmBrowsePelanggan pelanggan = new Browse.frmBrowsePelanggan(this);
            pelanggan.ShowDialog();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCabangID.Text) && !string.IsNullOrWhiteSpace(txtPelangganID.Text) && !string.IsNullOrWhiteSpace(txtNama.Text) && !string.IsNullOrWhiteSpace(txtNotelp.Text))
            {
                frmPembayaran pembayaran = new frmPembayaran(this);
                pembayaran.ShowDialog();

            }
            else
            {
                MessageBox.Show("Data Tidak boleh kosong.", "Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bersih();
            }
   
        }

        private void btnSaveDataPelanggan_Click(object sender, EventArgs e)
        {
            string[] cari = {lblCabangID.Text, txtPelangganID.Text };
            loaddata();
            dr = ds.Tables["Pelanggan"].Rows.Find(cari);
            if(dr == null)
            {
                if(!string.IsNullOrEmpty(lblCabangID.Text)&&!string.IsNullOrWhiteSpace(txtPelangganID.Text) && !string.IsNullOrWhiteSpace(txtNama.Text) && !string.IsNullOrWhiteSpace(txtNotelp.Text))
                {
                    dr = ds.Tables["Pelanggan"].NewRow();
                    dr[0] = lblCabangID.Text;
                    dr[1] = txtPelangganID.Text;
                    dr[2] = txtNama.Text;
                    dr[3] = txtNotelp.Text;
                    ds.Tables["Pelanggan"].Rows.Add(dr);
                    updatedata();
                    MessageBox.Show("Pelanggan ID " + txtPelangganID.Text + " Berhasil Ditambahkan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                }
                else
                {
                    MessageBox.Show("Pelanggan ID " + txtPelangganID.Text + " Data Tidak boleh kosong.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bersih();
                }
              
            }
            else
            {
                MessageBox.Show("Pelanggan ID " + txtPelangganID.Text + " Data Sudah Ada.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] cari = { lblCabangID.Text, txtPelangganID.Text };
            loaddata();
            dr = ds.Tables["Pelanggan"].Rows.Find(cari);
            if (dr != null)
            {
                dr[2] = txtNama.Text;
                dr[3] = txtNotelp.Text;
                updatedata();
                MessageBox.Show("Pelanggan ID " + txtPelangganID.Text + " Berhasil DiUpdate.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
            }
            else
            {
                MessageBox.Show("Pelanggan ID " + txtPelangganID.Text + " Belum Ada.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bersih();
            }
        }

        private void mnuclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
