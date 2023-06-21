using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Disconnected_Environment
{
    public partial class FormDataMahasiswa : Form
    {
        private string stringConnection = "data source= OUZI\\GHOZI;" + "database = act6; User ID = sa; Password = ghozi123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void txtprodi_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            txtprodi.DisplayMember = "nama_prodi";
            txtprodi.ValueMember = "id_prodi";
            txtprodi.DataSource = ds.Tables[0];

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNama.Text = "";
            txtalamat.Text = "";
            txttgl.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            txtjk.Enabled = true;
            txtalamat.Enabled = true;
            txttgl.Enabled = true;
            txtprodi.Enabled = true;
            txtprodi_Click();
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text;
            nama = txtNama.Text;
            jk = txtjk.Text;
            alamat = txtalamat.Text;
            tgl = txttgl.Value;
            prodi = txtprodi.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select id_prodi from dbo.prodi where nama_prodi = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@add", prodi));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_prodi"].ToString());
            }
            dr.Close();
            string str = "insert into dbo.Mahasiswa (nim, nama_mahasiswa, jenis_kel, alamat, tgl_lahir, id_prodi)" +
                "values(@NIM, @Nm, @Jk, @Al, @Tgll, @Idp)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("Nm", nama));
            cmd.Parameters.Add(new SqlParameter("Jk", jk));
            cmd.Parameters.Add(new SqlParameter("AL", alamat));
            cmd.Parameters.Add(new SqlParameter("Tgll", tgl));
            cmd.Parameters.Add(new SqlParameter("Idp", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        public FormDataMahasiswa()
        {
            InitializeComponent();
            string kstr = "connection_string_here";
            koneksi = new SqlConnection(kstr);
            this.bindingNavigator1.BindingSource = this.customersBindingSource;
            refreshform();
        }

        private void FormDataMahasiswa_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.nim, m.nama_mahasiswa, "+ "m.alamat, m.jenis_kelamin, m.tgl_lahir, p.nama_prodi from dbo.mahasiswa m"
                +"join dbo.prodi p on m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];  
            this.txtNIM.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nim", true));
            this.txtNama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.txtalamat.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.txtjk.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "jenis_kelamin", true));
            this.txttgl.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.txtprodi.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_prodi", true));
            koneksi.Close();
        }

        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtalamat.DataBindings.Clear();
            this.txtjk.DataBindings.Clear();
            this.txttgl.DataBindings.Clear();
            this.txtprodi.DataBindings.Clear();
        }

        private void refreshform()
        {
            txtNIM.Enabled = false;
            txtNama.Enabled = false;
            txtalamat.Enabled = false;
            txtjk.Enabled = false;
            txttgl.Enabled = false;
            txtprodi.Enabled = false;
            btnadd.Enabled = true;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            clearBinding();
            FormDataMahasiswa_Load();

        }
    }
}
