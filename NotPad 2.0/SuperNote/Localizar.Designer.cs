namespace SuperNote
{
    partial class Localizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localizar));
            this.bntLocalizar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbSensitive = new System.Windows.Forms.CheckBox();
            this.ckbPalavraInteira = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bntLocalizar
            // 
            this.bntLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLocalizar.Location = new System.Drawing.Point(500, 21);
            this.bntLocalizar.Name = "bntLocalizar";
            this.bntLocalizar.Size = new System.Drawing.Size(116, 24);
            this.bntLocalizar.TabIndex = 0;
            this.bntLocalizar.Text = "Localizar";
            this.bntLocalizar.UseVisualStyleBackColor = true;
            this.bntLocalizar.Click += new System.EventHandler(this.BntLocalizar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(500, 51);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(116, 24);
            this.bntCancelar.TabIndex = 1;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizar.Location = new System.Drawing.Point(121, 21);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(373, 24);
            this.txtLocalizar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Localizar:";
            // 
            // ckbSensitive
            // 
            this.ckbSensitive.AutoSize = true;
            this.ckbSensitive.ForeColor = System.Drawing.Color.White;
            this.ckbSensitive.Location = new System.Drawing.Point(46, 51);
            this.ckbSensitive.Name = "ckbSensitive";
            this.ckbSensitive.Size = new System.Drawing.Size(202, 17);
            this.ckbSensitive.TabIndex = 4;
            this.ckbSensitive.Text = "Diferenciar maiúsculas de minúsculas";
            this.ckbSensitive.UseVisualStyleBackColor = true;
            // 
            // ckbPalavraInteira
            // 
            this.ckbPalavraInteira.AutoSize = true;
            this.ckbPalavraInteira.ForeColor = System.Drawing.Color.White;
            this.ckbPalavraInteira.Location = new System.Drawing.Point(46, 74);
            this.ckbPalavraInteira.Name = "ckbPalavraInteira";
            this.ckbPalavraInteira.Size = new System.Drawing.Size(135, 17);
            this.ckbPalavraInteira.TabIndex = 5;
            this.ckbPalavraInteira.Text = "Coincidir palavra interia";
            this.ckbPalavraInteira.UseVisualStyleBackColor = true;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(666, 110);
            this.Controls.Add(this.ckbPalavraInteira);
            this.Controls.Add(this.ckbSensitive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntLocalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Localizar";
            this.Text = "Localizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntLocalizar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSensitive;
        private System.Windows.Forms.CheckBox ckbPalavraInteira;
        public System.Windows.Forms.TextBox txtLocalizar;
    }
}