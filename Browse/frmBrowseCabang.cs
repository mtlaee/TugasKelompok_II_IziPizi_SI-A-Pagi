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
    public partial class frmBrowseCabang : Form
    {
        public frmBrowseCabang()
        {
            InitializeComponent();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Loaddata()
        {
            ds = new DataSet();         
            query = "Select * From Cabang";           
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Cabang");
        }
        private void tampildata()
        {
            dgvData.DataSource = ds.Tables["Cabang"];
            dgvData.Columns[0].HeaderText = "Cabang ID";
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmBrowseCabang_Load(object sender, EventArgs e)
        {
            koneksi();
            Loaddata();
            tampildata();
        }

        private void btnSearchCabangID_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "Select * From Cabang Where CabangID Like '%" + txtCabangID.Text + "%'" ;
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Cabang");
            dc[0] = ds.Tables["Cabang"].Columns[0];
            ds.Tables["Cabang"].PrimaryKey = dc;
            tampildata();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loaddata();
            tampildata();
            txtCabangID.Clear();
        }
    }
}
