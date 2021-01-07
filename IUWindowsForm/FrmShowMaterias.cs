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
            this.cargarGrid();
        }

        private void cargarGrid()
        {
            this.dtShowList.DataSource = ProyecMaterias.DaoMateria.getAll();
        }

        private void dtShowList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar si se hizo clic en el link eliminar
            if (this.dtShowList.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                //MessageBox.Show("clic Eliminar");
                //recuperar la cedula de la fila actual
                int fila = e.RowIndex;
                String IDMateria = dtShowList["IDMateria", fila].Value.ToString();
                String NameMateria = dtShowList["NameMateria", fila].Value.ToString();
                //MessageBox.Show("cedula actual: " + cedula);



                DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar la materia " + NameMateria + "?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;// ABANDONDAR
                }

                int x = ProyecMaterias.DaoMateria.eliminar(IDMateria);

                if (x > 0)
                {
                    this.cargarGrid();
                    MessageBox.Show("Registro borrado con exito!!");
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el registro");
                }
            }
            else if (this.dtShowList.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                // MessageBox.Show("clic actualizar");
                int fila = e.RowIndex;
                String IDMateria = dtShowList["IDMateria", fila].Value.ToString();

                //open formulario actualizar
                FrmActualizar frm1 = new FrmActualizar(IDMateria);
                frm1.ShowDialog();

            }
        }
    }
}
