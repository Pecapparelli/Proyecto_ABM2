namespace Proyecto_ABM2.UsuariosForm
{
    partial class frmEditarUsuario
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
            components = new System.ComponentModel.Container();
            cmbUsuario = new ComboBox();
            usuariosBindingSource = new BindingSource(components);
            lblEdicion = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)usuariosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cmbUsuario
            // 
            cmbUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(52, 71);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(284, 33);
            cmbUsuario.TabIndex = 0;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            // 
            // usuariosBindingSource
            // 
            usuariosBindingSource.DataSource = typeof(Clases_biblio.Usuarios);
            // 
            // lblEdicion
            // 
            lblEdicion.AutoSize = true;
            lblEdicion.Location = new Point(49, 24);
            lblEdicion.Name = "lblEdicion";
            lblEdicion.Size = new Size(293, 25);
            lblEdicion.TabIndex = 1;
            lblEdicion.Text = "Seleccione que usuario desea editar";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(129, 241);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(235, 31);
            txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(129, 310);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(235, 31);
            txtDni.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 175);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 247);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 6;
            label1.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 316);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 7;
            label2.Text = "N° DNI:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(113, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(163, 54);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 481);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEdicion);
            Controls.Add(cmbUsuario);
            Name = "frmEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edición de usuarios";
            ((System.ComponentModel.ISupportInitialize)usuariosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuario;
        private BindingSource usuariosBindingSource;
        private Label lblEdicion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label lblNombre;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
    }
}