namespace SuperNote
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarComBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebraAutimaticaDeLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoClaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoClaroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modoEscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.modoClaroToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.NovoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salvarComoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarComoToolStripMenuItem.Image")));
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.SalvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sairToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem1.Image")));
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.selecionarTudoToolStripMenuItem,
            this.toolStripSeparator3,
            this.buscarComBingToolStripMenuItem,
            this.horaDataToolStripMenuItem,
            this.localizarToolStripMenuItem,
            this.substituirToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.desfazerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("desfazerToolStripMenuItem.Image")));
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.DesfazerToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.colarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripMenuItem.Image")));
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.ColarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cortarToolStripMenuItem.Text = "Recortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.CortarToolStripMenuItem_Click);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.selecionarTudoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selecionarTudoToolStripMenuItem.Image")));
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar Tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.SelecionarTudoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // buscarComBingToolStripMenuItem
            // 
            this.buscarComBingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buscarComBingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarComBingToolStripMenuItem.Image")));
            this.buscarComBingToolStripMenuItem.Name = "buscarComBingToolStripMenuItem";
            this.buscarComBingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.buscarComBingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buscarComBingToolStripMenuItem.Text = "Buscar com Bing";
            this.buscarComBingToolStripMenuItem.Click += new System.EventHandler(this.BuscarComBingToolStripMenuItem_Click);
            // 
            // horaDataToolStripMenuItem
            // 
            this.horaDataToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.horaDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horaDataToolStripMenuItem.Image")));
            this.horaDataToolStripMenuItem.Name = "horaDataToolStripMenuItem";
            this.horaDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.horaDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.horaDataToolStripMenuItem.Text = "Hora/Data";
            this.horaDataToolStripMenuItem.Click += new System.EventHandler(this.HoraDataToolStripMenuItem_Click);
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.localizarToolStripMenuItem.Text = "Localizar";
            this.localizarToolStripMenuItem.Click += new System.EventHandler(this.LocalizarToolStripMenuItem_Click);
            // 
            // substituirToolStripMenuItem
            // 
            this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            this.substituirToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.substituirToolStripMenuItem.Text = "Substituir";
            this.substituirToolStripMenuItem.Click += new System.EventHandler(this.SubstituirToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.quebraAutimaticaDeLinhaToolStripMenuItem});
            this.formatarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "&Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fonteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fonteToolStripMenuItem.Image")));
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.FonteToolStripMenuItem_Click);
            // 
            // quebraAutimaticaDeLinhaToolStripMenuItem
            // 
            this.quebraAutimaticaDeLinhaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.quebraAutimaticaDeLinhaToolStripMenuItem.Name = "quebraAutimaticaDeLinhaToolStripMenuItem";
            this.quebraAutimaticaDeLinhaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.quebraAutimaticaDeLinhaToolStripMenuItem.Text = "Quebra autimatica de linha";
            this.quebraAutimaticaDeLinhaToolStripMenuItem.Click += new System.EventHandler(this.QuebraAutimaticaDeLinhaToolStripMenuItem_Click);
            // 
            // modoClaroToolStripMenuItem
            // 
            this.modoClaroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoClaroToolStripMenuItem1,
            this.modoEscuroToolStripMenuItem});
            this.modoClaroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modoClaroToolStripMenuItem.Name = "modoClaroToolStripMenuItem";
            this.modoClaroToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.modoClaroToolStripMenuItem.Text = "&Tema";
            // 
            // modoClaroToolStripMenuItem1
            // 
            this.modoClaroToolStripMenuItem1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.modoClaroToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modoClaroToolStripMenuItem1.Image")));
            this.modoClaroToolStripMenuItem1.Name = "modoClaroToolStripMenuItem1";
            this.modoClaroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modoClaroToolStripMenuItem1.Text = "Modo Claro";
            this.modoClaroToolStripMenuItem1.Click += new System.EventHandler(this.ModoClaroToolStripMenuItem1_Click);
            // 
            // modoEscuroToolStripMenuItem
            // 
            this.modoEscuroToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.modoEscuroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modoEscuroToolStripMenuItem.Image")));
            this.modoEscuroToolStripMenuItem.Name = "modoEscuroToolStripMenuItem";
            this.modoEscuroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modoEscuroToolStripMenuItem.Text = "Modo Escuro";
            this.modoEscuroToolStripMenuItem.Click += new System.EventHandler(this.modoEscuroToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.Color.Black;
            this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBox.ForeColor = System.Drawing.Color.White;
            this.noteBox.Location = new System.Drawing.Point(0, 24);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(732, 426);
            this.noteBox.TabIndex = 1;
            this.noteBox.Text = "";
            this.noteBox.TextChanged += new System.EventHandler(this.NoteBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem horaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem modoClaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoClaroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modoEscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarComBingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
        public System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.ToolStripMenuItem quebraAutimaticaDeLinhaToolStripMenuItem;
    }
}

