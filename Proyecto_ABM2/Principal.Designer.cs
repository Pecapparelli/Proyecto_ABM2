namespace Proyecto_ABM2
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            editarLibrosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            pagoToolStripMenuItem = new ToolStripMenuItem();
            dgvLibros = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { materiaToolStripMenuItem, usuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem, editarLibrosToolStripMenuItem });
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(76, 29);
            materiaToolStripMenuItem.Text = "Libros";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(178, 34);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(178, 34);
            modificarToolStripMenuItem.Text = "Mostrar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // editarLibrosToolStripMenuItem
            // 
            editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            editarLibrosToolStripMenuItem.Size = new Size(178, 34);
            editarLibrosToolStripMenuItem.Text = "Editar";
            editarLibrosToolStripMenuItem.Click += mostrarLibrosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, editarToolStripMenuItem, pagoToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(96, 29);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(245, 34);
            altaToolStripMenuItem.Text = "Alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(245, 34);
            editarToolStripMenuItem.Text = "Lista de usuarios";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // pagoToolStripMenuItem
            // 
            pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            pagoToolStripMenuItem.Size = new Size(245, 34);
            pagoToolStripMenuItem.Text = "Pago";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToOrderColumns = true;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(32, 78);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.Size = new Size(817, 398);
            dgvLibros.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 592);
            Controls.Add(dgvLibros);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem pagoToolStripMenuItem;
        private DataGridView dgvLibros;
        private ToolStripMenuItem editarLibrosToolStripMenuItem;
    }
}
