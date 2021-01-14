using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms
{
    public partial class Actualizar : Form
    {
        public Actualizar(string codMaterias)
        {
            InitializeComponent();
            this.mCodMaterias = codMaterias;

        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("El codigo es :" + this.mCodMateria);
            this.txtCodigo.Text = mCodMateria;
            ProyectoMaterias.Materias p = new ProyectoMaterias.Materias();

            p = ProyectoMaterias.MateriasDAO.GetPersona(mCodMateria);

            //cargar datos en los cuadros de texto
            this.txtCodigo.Text = p.codMaterias;
            this.txtNombre.Text = p.nombreMateria;
            this.cmbNivel.Text = p.nivel.ToString();
            this.cmbCarrera.Text = p.carrera;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
