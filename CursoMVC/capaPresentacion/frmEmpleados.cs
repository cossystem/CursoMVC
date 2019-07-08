using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmEmpleados : Form
    {
        EntEmpleados objEntidad = new EntEmpleados();
        NegEmpleados objNegocio = new NegEmpleados();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            ListarEmpleados();

        }
        void ListarEmpleados()
        {
            DataTable dt = objNegocio.Listado();
            dataGridView1.DataSource = dt;

        }


    }
}
