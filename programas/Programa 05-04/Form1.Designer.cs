﻿namespace Programa05_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dupFrutas = new DomainUpDown();
            txtFruta = new TextBox();
            btnAdiccionar = new Button();
            lblMensaje = new Label();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // dupFrutas
            // 
            dupFrutas.Location = new Point(86, 236);
            dupFrutas.Name = "dupFrutas";
            dupFrutas.Size = new Size(150, 27);
            dupFrutas.TabIndex = 0;
            dupFrutas.Text = "Frutas";
            dupFrutas.SelectedItemChanged += dupFrutas_SelectedItemChanged;
            // 
            // txtFruta
            // 
            txtFruta.Location = new Point(99, 108);
            txtFruta.Name = "txtFruta";
            txtFruta.Size = new Size(125, 27);
            txtFruta.TabIndex = 1;
            // 
            // btnAdiccionar
            // 
            btnAdiccionar.Location = new Point(263, 114);
            btnAdiccionar.Name = "btnAdiccionar";
            btnAdiccionar.Size = new Size(94, 29);
            btnAdiccionar.TabIndex = 2;
            btnAdiccionar.Text = "Adiccionar";
            btnAdiccionar.UseVisualStyleBackColor = true;
            btnAdiccionar.Click += btnAdiccionar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(94, 171);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label1";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(294, 151);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 355);
            Controls.Add(btnBorrar);
            Controls.Add(lblMensaje);
            Controls.Add(btnAdiccionar);
            Controls.Add(txtFruta);
            Controls.Add(dupFrutas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown dupFrutas;
        private TextBox txtFruta;
        private Button btnAdiccionar;
        private Label lblMensaje;
        private Button btnBorrar;
    }
}
