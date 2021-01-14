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
    public partial class FrmMENU : Form
    {
        public FrmMENU()
        {
            InitializeComponent();
        }

        private void btnFrmAddMateria_Click(object sender, EventArgs e)
        {
            FrmAddMateria k = new FrmAddMateria();
            k.ShowDialog();
        }

        private void btnFrmShowMaterias_Click(object sender, EventArgs e)
        {
            FrmShowMaterias k = new FrmShowMaterias();
            k.ShowDialog();
        }

        private void btnFrmBuscarMateria_Click(object sender, EventArgs e)
        {
            FrmBuscarMateria k = new FrmBuscarMateria();
            k.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFrmInformeMaterias_Click(object sender, EventArgs e)
        {
            Informes.FrmInformeMaterias k = new Informes.FrmInformeMaterias();
            k.ShowDialog();
        }
    }
}
