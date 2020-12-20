using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForm
{
    public partial class FrmShowMaterias : Form
    {
        public FrmShowMaterias()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.dtShowList.DataSource = ProyecMaterias.DaoMateria.getAll();
        }
    }
}
