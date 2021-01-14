using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForm.Informes
{
    public partial class FrmInformeMaterias : Form
    {
        public FrmInformeMaterias()
        {
            InitializeComponent();
        }

        private void FrmInformeMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMaterias.Estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.dsMaterias.Estudiantes);

            this.reportViewer1.RefreshReport();
        }
    }
}
