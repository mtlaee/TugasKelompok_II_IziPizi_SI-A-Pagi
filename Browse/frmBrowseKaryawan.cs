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
    public partial class frmBrowseKaryawan : Form
    {
        public frmBrowseKaryawan()
        {
            InitializeComponent();
        }

        frmBarber barber;
        public frmBrowseKaryawan(frmBarber barber)
        {
            InitializeComponent();
            this.barber = barber;
        }
        frmBooking booking;
        public frmBrowseKaryawan(frmBooking booking)
        {
            InitializeComponent();
            this.booking = booking;
        }

        frmPembayaran pembayaran;
        public frmBrowseKaryawan(frmPembayaran pembayaran)
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
        private void Loaddata()
        {
            ds = new DataSet();
            query = "Select * From Karyawan Where CabangID = '" + lblCabangID.Text + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Karyawan");
            dc[0] = ds.Tables["Karyawan"].Columns[0];
            dc[1] = ds.Tables["Karyawan"].Columns[1];
            ds.Tables["Karyawan"].PrimaryKey = dc;
        }
        private void tampildata()
        {
            dgvData.DataSource = ds.Tables["Karyawan"];
            dgvData.Columns[0].HeaderText = "Cabang ID";
            dgvData.Columns[1].HeaderText = "Karyawan ID";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmBrowseKaryawan_Load(object sender, EventArgs e)
        {        
            koneksi();
            if(this.Tag == booking)
            {
                lblCabangID.Text = booking.txtCabangID.Text;
            }
            else if (this.Tag == pembayaran)
            {
                lblCabangID.Text = pembayaran.lblCabangID.Text;
            }            
            Loaddata();
            tampildata();             
        }             
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if(this.Tag == booking)
            {
                booking.txtCabangID.Text = dgvData[0, baris].Value.ToString();
                booking.txtKaryawanID.Text = dgvData[1, baris].Value.ToString();
            }
            if(this.Tag == pembayaran)
            {
                pembayaran.txtKaryawan.Text = dgvData[1, baris].Value.ToString();
            }
            txtKaryawanID.Text = dgvData[1, baris].Value.ToString();
            this.Close();
        }
    }
}
