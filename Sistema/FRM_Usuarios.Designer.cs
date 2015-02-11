namespace Sistema
{
    partial class FRM_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuarios));
            this.BRR_Superior = new System.Windows.Forms.ToolStrip();
            this.BTM_Regresar = new System.Windows.Forms.ToolStripButton();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            this.BTN_Nuevo = new System.Windows.Forms.Button();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.BRR_Busqueda = new System.Windows.Forms.ToolStrip();
            this.LBL_Buscarpor = new System.Windows.Forms.ToolStripLabel();
            this.CMB_Busqueda = new System.Windows.Forms.ToolStripComboBox();
            this.TXT_Busqueda = new System.Windows.Forms.ToolStripTextBox();
            this.BTN_Buscar = new System.Windows.Forms.ToolStripButton();
            this.LBL_Resultados = new System.Windows.Forms.ToolStripLabel();
            this.CMB_Resultados = new System.Windows.Forms.ToolStripComboBox();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.LBL_Contra = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.LBL_Ape = new System.Windows.Forms.Label();
            this.LBL_TipUsu = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Contra = new System.Windows.Forms.TextBox();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.TXT_Ape = new System.Windows.Forms.TextBox();
            this.CMB_TipUsu = new System.Windows.Forms.ComboBox();
            this.BRR_Superior.SuspendLayout();
            this.BRR_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRR_Superior
            // 
            this.BRR_Superior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTM_Regresar,
            this.BTN_Salir});
            this.BRR_Superior.Location = new System.Drawing.Point(0, 0);
            this.BRR_Superior.Name = "BRR_Superior";
            this.BRR_Superior.Size = new System.Drawing.Size(527, 25);
            this.BRR_Superior.TabIndex = 2;
            this.BRR_Superior.Text = "toolStrip1";
            // 
            // BTM_Regresar
            // 
            this.BTM_Regresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTM_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("BTM_Regresar.Image")));
            this.BTM_Regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTM_Regresar.Name = "BTM_Regresar";
            this.BTM_Regresar.Size = new System.Drawing.Size(56, 22);
            this.BTM_Regresar.Text = "Regresar";
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BTN_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Salir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salir.Image")));
            this.BTN_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(33, 22);
            this.BTN_Salir.Text = "Salir";
            // 
            // BTN_Nuevo
            // 
            this.BTN_Nuevo.Location = new System.Drawing.Point(12, 264);
            this.BTN_Nuevo.Name = "BTN_Nuevo";
            this.BTN_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.BTN_Nuevo.TabIndex = 3;
            this.BTN_Nuevo.Text = "Nuevo";
            this.BTN_Nuevo.UseVisualStyleBackColor = true;
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Location = new System.Drawing.Point(93, 264);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Editar.TabIndex = 4;
            this.BTN_Editar.Text = "Editar";
            this.BTN_Editar.UseVisualStyleBackColor = true;
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(174, 264);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Eliminar.TabIndex = 5;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(255, 264);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 6;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            // 
            // BRR_Busqueda
            // 
            this.BRR_Busqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBL_Buscarpor,
            this.CMB_Busqueda,
            this.TXT_Busqueda,
            this.BTN_Buscar,
            this.LBL_Resultados,
            this.CMB_Resultados});
            this.BRR_Busqueda.Location = new System.Drawing.Point(0, 25);
            this.BRR_Busqueda.Name = "BRR_Busqueda";
            this.BRR_Busqueda.Size = new System.Drawing.Size(527, 25);
            this.BRR_Busqueda.TabIndex = 75;
            this.BRR_Busqueda.Text = "toolStrip1";
            // 
            // LBL_Buscarpor
            // 
            this.LBL_Buscarpor.Name = "LBL_Buscarpor";
            this.LBL_Buscarpor.Size = new System.Drawing.Size(57, 24);
            this.LBL_Buscarpor.Text = "Busar por";
            // 
            // CMB_Busqueda
            // 
            this.CMB_Busqueda.Name = "CMB_Busqueda";
            this.CMB_Busqueda.Size = new System.Drawing.Size(121, 27);
            // 
            // TXT_Busqueda
            // 
            this.TXT_Busqueda.Name = "TXT_Busqueda";
            this.TXT_Busqueda.Size = new System.Drawing.Size(100, 27);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Buscar.Image")));
            this.BTN_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(46, 24);
            this.BTN_Buscar.Text = "Buscar";
            // 
            // LBL_Resultados
            // 
            this.LBL_Resultados.Name = "LBL_Resultados";
            this.LBL_Resultados.Size = new System.Drawing.Size(64, 24);
            this.LBL_Resultados.Text = "Resultados";
            // 
            // CMB_Resultados
            // 
            this.CMB_Resultados.Name = "CMB_Resultados";
            this.CMB_Resultados.Size = new System.Drawing.Size(121, 23);
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Location = new System.Drawing.Point(9, 94);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(43, 13);
            this.LBL_Usuario.TabIndex = 76;
            this.LBL_Usuario.Text = "Usuario";
            // 
            // LBL_Contra
            // 
            this.LBL_Contra.AutoSize = true;
            this.LBL_Contra.Location = new System.Drawing.Point(9, 118);
            this.LBL_Contra.Name = "LBL_Contra";
            this.LBL_Contra.Size = new System.Drawing.Size(61, 13);
            this.LBL_Contra.TabIndex = 77;
            this.LBL_Contra.Text = "Contraseña";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(12, 147);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(55, 13);
            this.LBL_Nombre.TabIndex = 78;
            this.LBL_Nombre.Text = "Nombre(s)";
            // 
            // LBL_Ape
            // 
            this.LBL_Ape.AutoSize = true;
            this.LBL_Ape.Location = new System.Drawing.Point(12, 173);
            this.LBL_Ape.Name = "LBL_Ape";
            this.LBL_Ape.Size = new System.Drawing.Size(49, 13);
            this.LBL_Ape.TabIndex = 79;
            this.LBL_Ape.Text = "Apellidos";
            // 
            // LBL_TipUsu
            // 
            this.LBL_TipUsu.AutoSize = true;
            this.LBL_TipUsu.Location = new System.Drawing.Point(12, 204);
            this.LBL_TipUsu.Name = "LBL_TipUsu";
            this.LBL_TipUsu.Size = new System.Drawing.Size(80, 13);
            this.LBL_TipUsu.TabIndex = 80;
            this.LBL_TipUsu.Text = "Tipo de usuario";
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(113, 92);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TXT_Usuario.TabIndex = 81;
            // 
            // TXT_Contra
            // 
            this.TXT_Contra.Location = new System.Drawing.Point(113, 118);
            this.TXT_Contra.Name = "TXT_Contra";
            this.TXT_Contra.Size = new System.Drawing.Size(100, 20);
            this.TXT_Contra.TabIndex = 82;
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(113, 144);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TXT_Nombre.TabIndex = 83;
            // 
            // TXT_Ape
            // 
            this.TXT_Ape.Location = new System.Drawing.Point(113, 173);
            this.TXT_Ape.Name = "TXT_Ape";
            this.TXT_Ape.Size = new System.Drawing.Size(100, 20);
            this.TXT_Ape.TabIndex = 84;
            // 
            // CMB_TipUsu
            // 
            this.CMB_TipUsu.FormattingEnabled = true;
            this.CMB_TipUsu.Location = new System.Drawing.Point(113, 204);
            this.CMB_TipUsu.Name = "CMB_TipUsu";
            this.CMB_TipUsu.Size = new System.Drawing.Size(100, 21);
            this.CMB_TipUsu.TabIndex = 85;
            // 
            // FRM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 295);
            this.Controls.Add(this.CMB_TipUsu);
            this.Controls.Add(this.TXT_Ape);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.TXT_Contra);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.LBL_TipUsu);
            this.Controls.Add(this.LBL_Ape);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.LBL_Contra);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.BRR_Busqueda);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Nuevo);
            this.Controls.Add(this.BRR_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.BRR_Superior.ResumeLayout(false);
            this.BRR_Superior.PerformLayout();
            this.BRR_Busqueda.ResumeLayout(false);
            this.BRR_Busqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BRR_Superior;
        private System.Windows.Forms.ToolStripButton BTM_Regresar;
        private System.Windows.Forms.ToolStripButton BTN_Salir;
        private System.Windows.Forms.Button BTN_Nuevo;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.ToolStrip BRR_Busqueda;
        private System.Windows.Forms.ToolStripLabel LBL_Buscarpor;
        private System.Windows.Forms.ToolStripComboBox CMB_Busqueda;
        private System.Windows.Forms.ToolStripTextBox TXT_Busqueda;
        private System.Windows.Forms.ToolStripButton BTN_Buscar;
        private System.Windows.Forms.ToolStripLabel LBL_Resultados;
        private System.Windows.Forms.ToolStripComboBox CMB_Resultados;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label LBL_Contra;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Label LBL_Ape;
        private System.Windows.Forms.Label LBL_TipUsu;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Contra;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.TextBox TXT_Ape;
        private System.Windows.Forms.ComboBox CMB_TipUsu;


    }
}