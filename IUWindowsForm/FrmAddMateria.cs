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
    public partial class FrmAddMateria : Form
    {
        public FrmAddMateria()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProyecMaterias.Materias matter= new ProyecMaterias.Materias();

            matter.IDMateria= this.txtID.Text;
            matter.NameMateria = this.txtName.Text;
            matter.Nivel = int.Parse(this.cmbLevel.Text);
            matter.Carrera = this.cmbCarrera.Text;


            int x = ProyecMaterias.DaoMateria.create(matter);

            if (x > 0)
                MessageBox.Show("Se agrego correctamente...");
            else
                MessageBox.Show("No se pudo agregar el registro..");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
