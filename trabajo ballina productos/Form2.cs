using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_ballina_productos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void entradasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entradasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void entradasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.entradasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'postgresDataSet.entradas' Puede moverla o quitarla según sea necesario.
            this.entradasTableAdapter.Fill(this.postgresDataSet.entradas);

        }
    }
}
