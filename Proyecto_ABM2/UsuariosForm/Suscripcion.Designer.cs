namespace Proyecto_ABM2.UsuariosForm
{
    partial class frmSuscripcion
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
            cmbUsuario = new ComboBox();
            btnSuscribir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbUsuario
            // 
            cmbUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(64, 77);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(270, 33);
            cmbUsuario.TabIndex = 0;
            // 
            // btnSuscribir
            // 
            btnSuscribir.Location = new Point(91, 170);
            btnSuscribir.Name = "btnSuscribir";
            btnSuscribir.Size = new Size(215, 54);
            btnSuscribir.TabIndex = 1;
            btnSuscribir.Text = "Suscribir";
            btnSuscribir.UseVisualStyleBackColor = true;
            btnSuscribir.Click += btnSuscribir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(353, 25);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el usuario que se desea suscribir";
            // 
            // frmSuscripcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 259);
            Controls.Add(label1);
            Controls.Add(btnSuscribir);
            Controls.Add(cmbUsuario);
            Name = "frmSuscripcion";
            Text = "Suscripción";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuario;
        private Button btnSuscribir;
        private Label label1;
    }
}