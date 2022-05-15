using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperNote
{
    public partial class substituir : Form
    {
        public substituir()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubstituir_Click(object sender, EventArgs e)
        {
            String busca = txtLocalizar.Text;
            String nova = txtSubstituir.Text;
            String texto = ((Form1)this.Owner).noteBox.Text;

            ((Form1)this.Owner).noteBox.Text = texto.Replace(busca, nova);

            this.Close();
        }

    }
}
