namespace Proyecto_ABM2.LibrosForm
{
    partial class frmEditarLibro
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
            cmbLibros = new ComboBox();
            lblSeleccion = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            chbBaja = new CheckBox();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // cmbLibros
            // 
            cmbLibros.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLibros.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Items.AddRange(new object[] { "Inventario", "Titulo" });
            cmbLibros.Location = new Point(91, 74);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(270, 33);
            cmbLibros.TabIndex = 0;
            cmbLibros.SelectedIndexChanged += cmbLibros_SelectedIndexChanged;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(81, 46);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(289, 25);
            lblSeleccion.TabIndex = 1;
            lblSeleccion.Text = "Seleccione el libro que desea editar";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(112, 164);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(280, 31);
            txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(112, 228);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(280, 31);
            txtAutor.TabIndex = 3;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(112, 291);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(280, 31);
            txtEditorial.TabIndex = 4;
            // 
            // chbBaja
            // 
            chbBaja.AutoSize = true;
            chbBaja.Location = new Point(271, 355);
            chbBaja.Name = "chbBaja";
            chbBaja.Size = new Size(70, 29);
            chbBaja.TabIndex = 5;
            chbBaja.Text = "Baja";
            chbBaja.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(32, 164);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(60, 25);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(31, 231);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(61, 25);
            lblAutor.TabIndex = 7;
            lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(12, 291);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(80, 25);
            lblEditorial.TabIndex = 8;
            lblEditorial.Text = "Editorial:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(133, 414);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(208, 34);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmEditarLibro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 493);
            Controls.Add(btnGuardar);
            Controls.Add(lblEditorial);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(chbBaja);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblSeleccion);
            Controls.Add(cmbLibros);
            Name = "frmEditarLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarLibro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbLibros;
        private Label lblSeleccion;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private CheckBox chbBaja;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblEditorial;
        private Button btnGuardar;
    }
}