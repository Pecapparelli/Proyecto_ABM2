namespace Proyecto_ABM2.UsuariosForm
{
    partial class frmAltaUsuario
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
            btnAlta = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(163, 292);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(112, 34);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(163, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(163, 214);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 31);
            txtDni.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(62, 136);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(62, 220);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 25);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI:";
            // 
            // frmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 354);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnAlta);
            Name = "frmAltaUsuario";
            Text = "Alta de usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlta;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
    }
}