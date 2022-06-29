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

namespace TugasKelompok_II_IziPizi_SI_A_Pagi.Browse
{
    public partial class frmBrowsePembayaran : Form
    {
        public frmBrowsePembayaran()
        {
            InitializeComponent();
        }

        frmPembayaran pembayaran;
        public frmBrowsePembayaran(frmPembayaran pembayaran)
        {
            InitializeComponent();
            this.pembayaran = pembayaran;
        }
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataColumn[] dc = new DataColumn[1];
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
            query = "Select * From Pembayaran";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pembayaran");
            dc[0] = ds.Tables["Pembayaran"].Columns[0];
            ds.Tables["Pembayaran"].PrimaryKey = dc;
        }
        private void tampildata()
        {
            dgvData.DataSource = ds.Tables["Pembayaran"];
            dgvData.Columns[0].HeaderText = "Kode Pembayaran";
            dgvData.Columns[1].HeaderText = "Paket ID";
            dgvData.Columns[2].HeaderText = "Cabang ID";
            dgvData.Columns[3].HeaderText = "Pelanggan ID";
            dgvData.Columns[5].HeaderText = "Karyawan ID";
            dgvData.Columns[7].HeaderText = "Tanggal Pangkas";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmBrowsePembayaran_Load(object sender, EventArgs e)
        {
            koneksi();
            lblCabangID.Text = pembayaran.lblCabangID.Text;
            loaddata();
            tampildata();
            txtKode.MaxLength = 4;
             
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            pembayaran.txtKode.Text = dgvData[0, baris].Value.ToString();
            pembayaran.txtKaryawan.Text = dgvData[5, baris].Value.ToString();
            pembayaran.txtPaketID.Text = dgvData[1, baris].Value.ToString();
            pembayaran.lblTotal.Text = dgvData[6, baris].Value.ToString();
            pembayaran.dtpTanggal.Value =  DateTime.Parse(dgvData[7, baris].Value.ToString());
            this.Close();
        }
    }
}
