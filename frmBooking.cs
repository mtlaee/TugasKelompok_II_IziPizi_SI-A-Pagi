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
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }

        BarberB barber;
        public frmBooking(BarberB barber)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmBooking_Load(object sender, EventArgs e)
        {
            koneksi();
            txtCabangID.Text = barber.lblUser.Text;
            txtKaryawanID.Focus();
            txtCabangID.ReadOnly = true;
            txtBooking.MaxLength = 3;
            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.CustomFormat = "dd MMMM yyyy";
            dtpWaktu.Value = DateTime.Now;
            dtpWaktu.Format = DateTimePickerFormat.Custom;
            dtpWaktu.CustomFormat = "hh:mm";       
        }
        private void btnSearchKaryawanID_Click(object sender, EventArgs e)
        {
            Browse.frmBrowseKaryawan karyawan = new Browse.frmBrowseKaryawan(this);
            karyawan.Tag = this;
            karyawan.ShowDialog();
        }
        private void loaddataboking()
        {
            ds = new DataSet();
            query = "Select * From Booking";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Booking");
            dc[0] = ds.Tables["Booking"].Columns[0];
            dc[1] = ds.Tables["Booking"].Columns[1];
            ds.Tables["Booking"].PrimaryKey = dc;
        }

        private void updatebooking()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Booking"]);
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            string[] cari = {txtCabangID.Text, txtBooking.Text};
            loaddataboking();
            dr = ds.Tables["Booking"].Rows.Find(cari);
            if(dr == null) //data belum ada
            {
                if (!string.IsNullOrWhiteSpace(txtCabangID.Text) && !string.IsNullOrWhiteSpace(txtKaryawanID.Text) && !string.IsNullOrWhiteSpace(txtNama.Text))
                {
                    dr = ds.Tables["Booking"].NewRow();
                    dr[0] = txtCabangID.Text;
                    dr[1] = txtBooking.Text;
                    dr[2] = txtNama.Text;
                    dr[3] = txtKaryawanID.Text;
                    dr[4] = dtpTanggal.Value;
                    dr[5] = dtpWaktu.Value;
                    ds.Tables["Booking"].Rows.Add(dr);
                    updatebooking();
                    MessageBox.Show("Booking ID " + txtBooking.Text + " Berhasil Ditambahkan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Tidak Boleh Kosong ", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else 
            {
                MessageBox.Show("Booking ID " + txtBooking.Text + " Data Sudah Ada", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearcBooking_Click(object sender, EventArgs e)
        {
            Browse.frmbrowseBooking booking = new Browse.frmbrowseBooking(this);
            booking.ShowDialog();
        }
        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            string[] cari = { txtCabangID.Text, txtBooking.Text };
            loaddataboking();
            dr = ds.Tables["Booking"].Rows.Find(cari);
            if (dr!=null)
            {
                    dr.Delete();
                    updatebooking();
                    MessageBox.Show("Booking ID " + txtBooking.Text + " Berhasil diDelete.", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Booking ID " + txtBooking.Text + " Data Belum Ada.", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] cari = { txtCabangID.Text, txtBooking.Text };
            loaddataboking();
            dr = ds.Tables["Booking"].Rows.Find(cari);
            if (dr != null) //data sudah ada
            {
                if (!string.IsNullOrWhiteSpace(txtCabangID.Text) && !string.IsNullOrWhiteSpace(txtKaryawanID.Text) && !string.IsNullOrWhiteSpace(txtNama.Text))
                {
                    dr[2] = txtNama.Text;
                    dr[3] = txtKaryawanID.Text;
                    dr[4] = dtpTanggal.Value;
                    dr[5] = dtpWaktu.Value;
                    updatebooking();
                    MessageBox.Show("Booking ID " + txtBooking.Text + " Berhasil Diupdate.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Tidak Boleh Kosong ", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                   
            }
            else
            {
                MessageBox.Show("Booking ID " + txtBooking.Text + " Data Belum ada.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
