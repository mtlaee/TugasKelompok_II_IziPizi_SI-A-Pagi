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
    public partial class frmbrowseBooking : Form
    {
        public frmbrowseBooking()
        {
            InitializeComponent();
        }

        frmBooking booking;
        public frmbrowseBooking(frmBooking booking)
        {
            InitializeComponent();
            this.booking = booking;
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
            query = "Select * From Booking where CabangID ='" + lblCabangID.Text+ "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Booking");
            dc[0] = ds.Tables["Booking"].Columns[0];
            dc[1] = ds.Tables["Booking"].Columns[1];
            ds.Tables["Booking"].PrimaryKey = dc;

        }

        private void tampildata()
        {
            dgvData.DataSource = ds.Tables["Booking"];
            dgvData.Columns[0].HeaderText = "Cabang ID";
            dgvData.Columns[1].HeaderText = "Booking ID";
            dgvData.Columns[3].HeaderText = "Karyawan ID";
            dgvData.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            dgvData.Columns[5].DefaultCellStyle.Format = "hh:mm";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmbrowseBooking_Load(object sender, EventArgs e)
        {
            koneksi();
           lblCabangID.Text = booking.txtCabangID.Text;
            loaddata();
            tampildata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "Select * from Booking where CabangID ='" + lblCabangID.Text + "' AND Nama Like '%" + txtNama.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Booking");
            txtNama.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblCabangID.Text = booking.txtCabangID.Text;
            loaddata();
            tampildata();
            txtNama.Clear();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            booking.txtKaryawanID.Text = dgvData[3, baris].Value.ToString();
            booking.txtBooking.Text = dgvData[1, baris].Value.ToString();
            booking.dtpTanggal.Value = DateTime.Parse(dgvData[4, baris].Value.ToString());
            booking.dtpWaktu.Value = DateTime.Parse(dgvData[5, baris].Value.ToString());
            booking.txtNama.Text = dgvData[2, baris].Value.ToString();
            txtNama.Text = dgvData[2, baris].Value.ToString();
            this.Close();
        }
    }
}
