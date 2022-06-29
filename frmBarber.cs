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
    public partial class frmBarber : Form
    {
        public frmBarber()
        {
            InitializeComponent();
        }

        Browse.frmBrowseKaryawan karyawan;
        public frmBarber(Browse.frmBrowseKaryawan karyawan)
        {
            InitializeComponent();
            this.karyawan = karyawan;
        }

        frmBooking booking;
        public frmBarber(frmBooking booking)
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
        DataRow dr;
        DataColumn[] dc = new DataColumn[1]; //1PK

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
            query = "Select * FROM Login";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Login");
            dc[0] = ds.Tables["Login"].Columns[0];
            ds.Tables["Login"].PrimaryKey = dc;
        }
        private void frmBarber_Load(object sender, EventArgs e)
        {
            koneksi();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loaddata();
            dr = ds.Tables["Login"].Rows.Find(txtUsername.Text);
            if (dr!=null)
            {
                if(dr[1].ToString() == txtPassword.Text)
                {
                    BarberB barber = new BarberB (this);
                    barber.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Your password is incorrect.","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
               
            }
            else
            {
                MessageBox.Show("Your username is incorrect.","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
