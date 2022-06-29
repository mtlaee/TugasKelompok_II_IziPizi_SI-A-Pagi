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
    public partial class frmBrowsePaket : Form
    {
        public frmBrowsePaket()
        {
            InitializeComponent();
        }

       frmPembayaran pembayaran;
        public frmBrowsePaket(frmPembayaran pembayaran)
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
            query = "Select * From PaketLayanan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PaketLayanan");
        }

        private void tampildata()
        {
            dgvData.DataSource = ds.Tables["PaketLayanan"];
            dgvData.Columns[0].HeaderText = "Paket ID";
            dgvData.Columns[1].HeaderText = "Nama Paket";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmBrowsePaket_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            tampildata();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            pembayaran.txtPaketID.Text = dgvData[0, baris].Value.ToString();
            pembayaran.lblTotal.Text = dgvData[2, baris].Value.ToString();
            txtPaket.Text = dgvData[1, baris].Value.ToString();
            this.Close();
        }
    }
}
