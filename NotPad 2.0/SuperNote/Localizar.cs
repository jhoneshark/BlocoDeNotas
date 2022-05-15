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
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();
        }

        private void BntLocalizar_Click(object sender, EventArgs e)
        {
            String busca = txtLocalizar.Text;
            String texto = ((Form1)this.Owner).noteBox.Text;

            RichTextBoxFinds regra = RichTextBoxFinds.None;
            if(ckbSensitive.Checked == true)
            {
                regra = RichTextBoxFinds.MatchCase;
            }
            if(ckbPalavraInteira.Checked == true)
            {
                regra = RichTextBoxFinds.WholeWord;
            }
            int index = 0;

            while (index < ((Form1)this.Owner).noteBox.Text.LastIndexOf(busca))
            {
                ((Form1)this.Owner).noteBox.Find(busca, index, texto.Length, regra);
                ((Form1)this.Owner).noteBox.SelectionBackColor = Color.Red;
                index = ((Form1)this.Owner).noteBox.Text.IndexOf(busca, index) + 1;
            }
            this.Close();
        }
        private void BntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
