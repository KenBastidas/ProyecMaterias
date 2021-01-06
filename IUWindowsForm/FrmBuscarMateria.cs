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
    public partial class FrmBuscarMateria : Form
    {
        public FrmBuscarMateria()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            //Evento laod: Se ejeuta la primera vez que se carga el formulario
            this.cargarComboMaterias();
        }
        private void cargarComboMaterias()
        {
            this.cmbIDMateria.DataSource = ProyecMaterias.DaoMateria.getAll();
            this.cmbIDMateria.DisplayMember = "Estudiantes";
            this.cmbIDMateria.ValueMember = "IDMateria";
        }
        private void btnBucar_Click(object sender, EventArgs e)
        {
            String IDMateria = this.cmbIDMateria.Text;

            ProyecMaterias.Materias p = new ProyecMaterias.Materias();
            p = ProyecMaterias.DaoMateria.GetMateria(IDMateria);

            //cargar datos en los cuadros de texto
            this.txtID.Text = p.IDMateria;
            this.txtName.Text = p.NameMateria;
            this.cmbLevel.Text = p.Nivel.ToString();
            this.cmbCarrera.Text = p.Carrera;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text.Length == 0)// si la cedula esta avcia
            {
                MessageBox.Show("no hay ID selecionada...");
                return; //abandonar
            }
            ProyecMaterias.Materias materia = new ProyecMaterias.Materias();
            materia.IDMateria = this.txtID.Text;
            materia.NameMateria = this.txtName.Text;
            materia.Nivel = int.Parse(this.cmbLevel.Text);
            materia.Carrera = this.cmbCarrera.Text;

            int x = ProyecMaterias.DaoMateria.actualizar(materia);
            if (x > 0)
            {
                this.cargarComboMaterias();//actulizar cuadro estudiantes
                MessageBox.Show("Registro actualizado con exito!!");
            }
            else
                MessageBox.Show("Nose pudo actualizar el registro!!!!!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea eliminar este registro?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;// ABANDONDAR
            }
            int x = ProyecMaterias.DaoMateria.eliminar(this.txtID.Text);
            if (x > 0)
            {
                this.encerar();
                this.cargarComboMaterias();
                MessageBox.Show("Registro elimiando con exito!!");
            }
            else
            {
                MessageBox.Show("No se pudo borrar el registro");
            }
        }
        private void encerar()
        {
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.cmbLevel.Text = "1";
            this.cmbCarrera.Text = "";
        }

        private void cmbIDMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
