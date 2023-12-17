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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            mostrarTodoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editarLibrosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exportartxtToolStripMenuItem = new ToolStripMenuItem();
            exportarXMLToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosPagoToolStripMenuItem = new ToolStripMenuItem();
            todosLosUsuariosToolStripMenuItem = new ToolStripMenuItem();
            pagoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            suscribirToolStripMenuItem = new ToolStripMenuItem();
            prestamoToolStripMenuItem = new ToolStripMenuItem();
            prestamoYDevoluciónToolStripMenuItem = new ToolStripMenuItem();
            dgvLibros = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { materiaToolStripMenuItem, usuariosToolStripMenuItem, prestamoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1118, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem, editarLibrosToolStripMenuItem, toolStripSeparator2, exportartxtToolStripMenuItem, exportarXMLToolStripMenuItem });
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(76, 29);
            materiaToolStripMenuItem.Text = "Libros";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(220, 34);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarTodoToolStripMenuItem, toolStripSeparator1 });
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(220, 34);
            modificarToolStripMenuItem.Text = "Mostrar";
            // 
            // mostrarTodoToolStripMenuItem
            // 
            mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            mostrarTodoToolStripMenuItem.Size = new Size(220, 34);
            mostrarTodoToolStripMenuItem.Text = "Mostrar todo";
            mostrarTodoToolStripMenuItem.Click += mostrarTodoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(217, 6);
            // 
            // editarLibrosToolStripMenuItem
            // 
            editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            editarLibrosToolStripMenuItem.Size = new Size(220, 34);
            editarLibrosToolStripMenuItem.Text = "Editar";
            editarLibrosToolStripMenuItem.Click += mostrarLibrosToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(217, 6);
            // 
            // exportartxtToolStripMenuItem
            // 
            exportartxtToolStripMenuItem.Name = "exportartxtToolStripMenuItem";
            exportartxtToolStripMenuItem.Size = new Size(220, 34);
            exportartxtToolStripMenuItem.Text = "Exportar .txt";
            exportartxtToolStripMenuItem.Click += exportartxtToolStripMenuItem_Click;
            // 
            // exportarXMLToolStripMenuItem
            // 
            exportarXMLToolStripMenuItem.Name = "exportarXMLToolStripMenuItem";
            exportarXMLToolStripMenuItem.Size = new Size(220, 34);
            exportarXMLToolStripMenuItem.Text = "Exportar XML";
            exportarXMLToolStripMenuItem.Click += exportarXMLToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, editarToolStripMenuItem, pagoToolStripMenuItem, toolStripSeparator3, suscribirToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(96, 29);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(270, 34);
            altaToolStripMenuItem.Text = "Alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem1, usuariosPagoToolStripMenuItem, todosLosUsuariosToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(270, 34);
            editarToolStripMenuItem.Text = "Lista de usuarios";
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(270, 34);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // usuariosPagoToolStripMenuItem
            // 
            usuariosPagoToolStripMenuItem.Name = "usuariosPagoToolStripMenuItem";
            usuariosPagoToolStripMenuItem.Size = new Size(270, 34);
            usuariosPagoToolStripMenuItem.Text = "Usuarios pago";
            usuariosPagoToolStripMenuItem.Click += usuariosPagoToolStripMenuItem_Click;
            // 
            // todosLosUsuariosToolStripMenuItem
            // 
            todosLosUsuariosToolStripMenuItem.Name = "todosLosUsuariosToolStripMenuItem";
            todosLosUsuariosToolStripMenuItem.Size = new Size(270, 34);
            todosLosUsuariosToolStripMenuItem.Text = "Todos los usuarios";
            // 
            // pagoToolStripMenuItem
            // 
            pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            pagoToolStripMenuItem.Size = new Size(270, 34);
            pagoToolStripMenuItem.Text = " Editar";
            pagoToolStripMenuItem.Click += pagoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(267, 6);
            // 
            // suscribirToolStripMenuItem
            // 
            suscribirToolStripMenuItem.Name = "suscribirToolStripMenuItem";
            suscribirToolStripMenuItem.Size = new Size(270, 34);
            suscribirToolStripMenuItem.Text = "Suscribir";
            suscribirToolStripMenuItem.Click += suscribirToolStripMenuItem_Click;
            // 
            // prestamoToolStripMenuItem
            // 
            prestamoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prestamoYDevoluciónToolStripMenuItem });
            prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            prestamoToolStripMenuItem.Size = new Size(103, 29);
            prestamoToolStripMenuItem.Text = "Prestamo";
            // 
            // prestamoYDevoluciónToolStripMenuItem
            // 
            prestamoYDevoluciónToolStripMenuItem.Name = "prestamoYDevoluciónToolStripMenuItem";
            prestamoYDevoluciónToolStripMenuItem.Size = new Size(295, 34);
            prestamoYDevoluciónToolStripMenuItem.Text = "Prestamo y devolución";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToOrderColumns = true;
            dgvLibros.BackgroundColor = Color.Lavender;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.GridColor = SystemColors.Desktop;
            dgvLibros.Location = new Point(32, 78);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.Size = new Size(1055, 400);
            dgvLibros.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.istockphoto_1279696698_612x612;
            ClientSize = new Size(1118, 644);
            Controls.Add(dgvLibros);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem mostrarTodoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exportartxtToolStripMenuItem;
        private ToolStripMenuItem exportarXMLToolStripMenuItem;
        private ToolStripMenuItem prestamoToolStripMenuItem;
        private ToolStripMenuItem prestamoYDevoluciónToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem suscribirToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem usuariosPagoToolStripMenuItem;
        private ToolStripMenuItem todosLosUsuariosToolStripMenuItem;
    }
}
