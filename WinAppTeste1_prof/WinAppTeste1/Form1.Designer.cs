﻿namespace WinAppTeste1
{
    partial class frmPrincipal
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.cmdArquivo = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(27, 140);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(277, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(27, 44);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(562, 90);
            this.txtSaida.TabIndex = 1;
            // 
            // cmdArquivo
            // 
            this.cmdArquivo.Location = new System.Drawing.Point(27, 170);
            this.cmdArquivo.Name = "cmdArquivo";
            this.cmdArquivo.Size = new System.Drawing.Size(277, 23);
            this.cmdArquivo.TabIndex = 2;
            this.cmdArquivo.Text = "&Processar Arquivo";
            this.cmdArquivo.UseVisualStyleBackColor = true;
            this.cmdArquivo.Click += new System.EventHandler(this.cmdArquivo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(27, 200);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(277, 23);
            this.cmdSalvar.TabIndex = 3;
            this.cmdSalvar.Text = "&Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdProfessor
            // 
            this.cmdProfessor.Location = new System.Drawing.Point(312, 140);
            this.cmdProfessor.Name = "cmdProfessor";
            this.cmdProfessor.Size = new System.Drawing.Size(277, 23);
            this.cmdProfessor.TabIndex = 4;
            this.cmdProfessor.Text = "&Teste Professor";
            this.cmdProfessor.UseVisualStyleBackColor = true;
            this.cmdProfessor.Click += new System.EventHandler(this.cmdProfessor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 291);
            this.Controls.Add(this.cmdProfessor);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdArquivo);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.cmdOK);
            this.Name = "frmPrincipal";
            this.Text = "Teste de Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button cmdArquivo;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdProfessor;
    }
}

