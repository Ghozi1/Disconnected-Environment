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

namespace Disconnected_Environment
{
    public partial class DataStatusMahasiswa : Form
    {
        private string stringConnection = "data source= OUZI\\GHOZI;" + "database = act6; User ID = sa; Password = ghozi123";
        private SqlConnection koneksi;

        public DataStatusMahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            cbxnama.Enabled = false;
            cbxstatus.Enabled = false;
            cbxthmasuk.Enabled = false;
            cbxnama.SelectedIndex = -1;
            cbxstatus.SelectedIndex = -1;
            cbxthmasuk.SelectedIndex = -1;
            txtNIM.Visible = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
            btnadd.Enabled = true;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.status_mahasiswa";
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cbxthmasuk.Enabled = true;
            cbxnama.Enabled = true;
            cbxstatus.Enabled = true;
            txtNIM.Visible = true;
            cbthmasuk_Click();
            cbNama_Click();
            btnclear.Enabled = true;
            btnsave.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string nim = txtNIM.Text;
            string statusMahasiswa = cbxstatus.Text;
            string tahunMasuk = cbxthmasuk.Text;
            int count = 0;
            string tempKodeStatus = "";
            string kodeStatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.status_mahasiswa";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodeStatus = "1";
            }
            else
            {
                string queryString = "select Max(id_status) from dbo.status_mahasiswa";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalKodeStatusInt = totalStatusMahasiswa + 1;
                kodeStatus = Convert.ToString(finalKodeStatusInt);
            }
            string querystring = "insert into dbo.status_mahasiswa (id_status, nim " +
                "status_mahasiswa, tahun_masuk)" + " values(@ids, @NIM, @sm, @tm)";
            SqlCommand cmd = new SqlCommand(querystring, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ids", kodeStatus));
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("sm", statusMahasiswa));
            cmd.Parameters.Add(new SqlParameter("tm", tahunMasuk));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }
        private void DataStatusMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void cbNama_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string str = "select nama_mahasiswa from dbo.Mahasiswa where" +
                "not EXIST(select id_status from dbo.status_mahasiswa where" +
                "status_mahasiswa.nim = mahasiswa.nim";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxnama.DisplayMember = "nama_mahasiswa";
            cbxnama.ValueMember = "NIM";
            cbxnama.DataSource = ds.Tables[0];
        }

        private void cbthmasuk_Click(object sender, EventArgs e)
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    cbxthmasuk.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    cbxthmasuk.Items.Add(l.ToString());
                }
            }
        }
    }
}
