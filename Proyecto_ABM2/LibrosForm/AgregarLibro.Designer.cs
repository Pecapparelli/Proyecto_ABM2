namespace Proyecto_ABM2.LibrosForm
{
    partial class frmAgregarLibro
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
            lblTitulo = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(42, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.Location = new Point(42, 143);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(68, 25);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(22, 208);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(76, 25);
            lblEditorial.TabIndex = 2;
            lblEditorial.Text = "Editorial";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(104, 70);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(246, 31);
            txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(104, 140);
            txtAutor.Name = "txtAutor";
            txtAutor.PlaceholderText = "Nombre, Apellido";
            txtAutor.Size = new Size(246, 31);
            txtAutor.TabIndex = 4;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(104, 205);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(246, 31);
            txtEditorial.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(114, 281);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(186, 48);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmAgregarLibro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 365);
            Controls.Add(btnAgregar);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblEditorial);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Name = "frmAgregarLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarLibro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private Label lblEditorial;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private Button btnAgregar;
    }
}