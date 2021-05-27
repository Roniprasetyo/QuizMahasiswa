using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class ProgramBarang : Form
    {
        public ProgramBarang()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            MasterBarang024 a = new MasterBarang024();
            a.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportBarang004 a = new ReportBarang004();
            a.Show();
        }
    }
}
