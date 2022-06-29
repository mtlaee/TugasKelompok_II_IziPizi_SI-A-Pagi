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
    public partial class frmBrowsePelanggan : Form
    {
        public frmBrowsePelanggan()
        {
            InitializeComponent();
        }

        frmPelanggan pelanggan;
        public frmBrowsePelanggan(frmPelanggan pelanggan)
        {
            InitializeComponent();
            this.pelanggan = pelanggan;
        }
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataColumn[] dc = new DataColumn[2];

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
            query = "Select * From Pelanggan WHERE CabangID ='" + lblCabangID.Text+"'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
        }
        private void tampildata()
        {
            dgvData.DataSource = ds.Tables["Pelanggan"];
            dgvData.Columns[0].HeaderText = "Cabang ID";
            dgvData.Columns[1].HeaderText = "Pelanggan ID";
            dgvData.Columns[2].HeaderText = "Nama";
            dgvData.Columns[3].HeaderText = "Phone";       
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmBrowsePelanggan_Load(object sender, EventArgs e)
        {
            koneksi();
            lblCabangID.Text = pelanggan.lblCabangID.Text;
            loaddata();
            tampildata();
            
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            pelanggan.txtPelangganID.Text = dgvData[1, baris].Value.ToString();
            pelanggan.txtNama.Text = dgvData[2, baris].Value.ToString();
            pelanggan.txtNotelp.Text = dgvData[3, baris].Value.ToString();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "Select * From Pelanggan WHERE CabangID ='" + lblCabangID.Text + "' AND PelangganID like '%" +txtPelangganID.Text+"%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            dc[1] = ds.Tables["Pelanggan"].Columns[1];
            ds.Tables["Pelanggan"].PrimaryKey = dc;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            tampildata();
            txtPelangganID.Clear();
            txtPelangganID.Focus();
        }
    }
}
