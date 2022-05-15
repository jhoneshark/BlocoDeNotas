using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuperNote
{
    public partial class Form1 : Form
    {
        private string nomeFicheiro = String.Empty;

        private string localFicheiro = String.Empty;

        private bool textoModificado = false;

        private bool novoFicheiro = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textoModificado)
            {
                DialogResult resultado = MessageBox.Show("Deseja Salvar as Alterações?",
                    "NotePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                 if (resultado == DialogResult.Yes)
                 {
                    Guardar();
                 }
                 else if (resultado == DialogResult.Cancel)
                {
                    return;
                }
            }

            noteBox.Text = string.Empty;
            textoModificado = false;
            nomeFicheiro = string.Empty;   
            localFicheiro = string.Empty;

            this.Text = "Sem Titulo - Notepad";

        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {
            if (!novoFicheiro)
            {
                if (!textoModificado)
                {
                    this.Text = "* " + this.Text;
                }

                textoModificado = true;
            }
            else
            {
                novoFicheiro = false;
            }
        }
        private void Guardar()
        {
            if ((nomeFicheiro == string.Empty) || (localFicheiro == string.Empty))
            {
                GuardarComo();
            }
            else
            {             
                File.WriteAllText(Path.Combine(localFicheiro, nomeFicheiro), noteBox.Text, Encoding.UTF8);
                this.Text = nomeFicheiro + " - Notepad";
                textoModificado = false;
            }
        }

        private void GuardarComo()
        {
            saveFileDialog1.Title = "Guardar como";
            saveFileDialog1.Filter = "Ficheiros de texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.DefaultExt = "txt";

            saveFileDialog1.CheckPathExists = true;

            if (localFicheiro != string.Empty)
            {
                saveFileDialog1.InitialDirectory = localFicheiro;
            }

            saveFileDialog1.FileName = nomeFicheiro;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                nomeFicheiro = Path.GetFileName(saveFileDialog1.FileName);
                localFicheiro = Path.GetDirectoryName(saveFileDialog1.FileName);

                this.Text = nomeFicheiro + " - Notepad";

                File.WriteAllText(saveFileDialog1.FileName, noteBox.Text, Encoding.UTF8);

                textoModificado = false;
            }
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textoModificado)
            {
                DialogResult resultado = MessageBox.Show("O ficheiro foi modificado. Deseja gravar?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Guardar();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    return;
                }
            }

            openFileDialog1.Title = "Abrir";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nomeFicheiro = Path.GetFileName(openFileDialog1.FileName);
                localFicheiro = Path.GetDirectoryName(openFileDialog1.FileName);

                this.Text = nomeFicheiro + " - Notepad";

                textoModificado = false;
                novoFicheiro = true;
                noteBox.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
            }
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textoModificado)
            {
                DialogResult resultado = MessageBox.Show("O ficheiro foi modificado. Deseja gravar?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Guardar();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }

            e.Cancel = false;
        }

        private void FonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = noteBox.Font;
            fontDialog1.Color = noteBox.ForeColor;
            fontDialog1.ShowColor = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                noteBox.Font = fontDialog1.Font;
                noteBox.ForeColor = fontDialog1.Color;
            }
        }

        private void QuebraAutimaticaDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraAutimaticaDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutimaticaDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                noteBox.WordWrap = false;
            }
            else
            {
                quebraAutimaticaDeLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                noteBox.WordWrap = true;
            }
        }

        private void Copiar_recortar(bool recortando)
        {
            if (noteBox.Text != null)
            {
                try
                {
                    RichTextBox textBox = noteBox;
                    if (textBox != null)
                    {
                        Clipboard.SetText(textBox.SelectedText, TextDataFormat.UnicodeText);
                        if (recortando)
                        {
                            textBox.SelectedText = String.Empty;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao copiar...");
                }
            }
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar_recortar(false);
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noteBox.Text != null)
            {
                try
                {
                    RichTextBox textBox = noteBox;
                    if (textBox != null)
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if (data.GetDataPresent(DataFormats.StringFormat))
                        {
                            textBox.SelectedText = data.GetData(DataFormats.StringFormat).ToString();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao colar...");
                }
            }
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar_recortar(true);
        }

        private void HoraDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteBox.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bloco de nota feito como desafio by:Jhoneshark");
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(noteBox.Text, noteBox.Font, Brushes.Black, 100, 100);
        }

        private void ModoClaroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            noteBox.ForeColor = Color.Black;
            noteBox.BackColor = Color.White;
        }

        private void modoEscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteBox.ForeColor = Color.White;
            noteBox.BackColor = Color.Black;
        }

        private void SelecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteBox.SelectAll();
        }

        private void DesfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteBox.Undo();
        }

        private void BuscarComBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(noteBox.SelectedText != "")
            {
                String texto = noteBox.SelectedText;
                texto.Replace(' ', '+');
                System.Diagnostics.Process.Start("microsoft-edge:https//www.bing.com/search?q=" + texto);
               
            }
            else
            {
                MessageBox.Show("É necessário selecionar um tempo para pesquisar.", "Buscar com o Bing",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LocalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizar frm = new Localizar();
            frm.txtLocalizar.Text = noteBox.SelectedText;
            frm.Show(this);
        }


        private void SubstituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            substituir frm = new substituir();
            frm.txtLocalizar.Text = noteBox.SelectedText;
            frm.Show(this);
        }
    }
}
