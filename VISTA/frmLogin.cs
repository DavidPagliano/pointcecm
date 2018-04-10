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

namespace VISTA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"ESCUELA=.12000903_71620\SQL_UAI;");
        }
    }
}
