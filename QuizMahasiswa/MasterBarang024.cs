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

namespace QuizMahasiswa
{
    public partial class MasterBarang024 : Form
    {
        SqlConnection con = new SqlConnection("Integrated Security= true; Initial Catalog=Barang; server=.");
        public MasterBarang024()
        {
            InitializeComponent();
        }

        private void MasterBarang024_Load(object sender, EventArgs e)
        {
            tampil();
            
        }

        private void tampil()
        {
            // TODO: This line of code loads data into the 'barangDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.barangDataSet.tbl_barang);

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)),0) +1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string nama = txtNamaBarang.Text;
            int harga = int.Parse(txtHarga.Text);
            int stock = int.Parse(txtStock.Text);
            int namasupplier = int.Parse(cbSupplier.Text);
            var data = new tbl_barang
            {
                id_barang = ID,
                nama_barang = nama,
                harga = harga,
                stock = stock,
                nama_supplier = namasupplier
            };

            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtID.Clear();
            txtHarga.Clear();
            txtNamaBarang.Clear();
            txtStock.Clear();
            cbSupplier.SelectedIndex = -1;
            tampil();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtHarga.Clear();
            txtNamaBarang.Clear();
            txtStock.Clear();
            cbSupplier.SelectedIndex = -1;
            tampil();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
