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
    public partial class FrmActualizar : Form
    {

        private String kIDMateria;

        public FrmActualizar(String IDMateria)
        {
            InitializeComponent();
            //el parametro IDMateria se recibe como parametro
            //en el constructor de la clase
            this.kIDMateria = IDMateria;
        }



        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            this.txtID.Text = kIDMateria;
            ProyecMaterias.Materias materia = new ProyecMaterias.Materias();

            materia = ProyecMaterias.DaoMateria.GetMateria(kIDMateria);

            this.txtID.Text = materia.IDMateria;
            this.txtName.Text = materia.NameMateria;
            this.cmbCarrera.Text = materia.Carrera;
            this.cmbLevel.Text = materia.Nivel.ToString();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            if (this.kIDMateria.Length > 0)
            {
                ProyecMaterias.Materias materia = new ProyecMaterias.Materias();

                materia.IDMateria = kIDMateria;
                materia.NameMateria = this.txtName.Text;
                materia.Carrera = this.cmbCarrera.Text;
                materia.Nivel=int.Parse(this.cmbLevel.Text);


                int x = ProyecMaterias.DaoMateria.actualizar(materia);

                if (x > 0)
                    MessageBox.Show("Registro actualizado..");
                else
                    MessageBox.Show("No se pudo actualizar el registro");
            }
        }
    }
}
