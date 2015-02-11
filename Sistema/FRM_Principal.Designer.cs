namespace Sistema
{
    partial class FRM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LBL_Bienvenido = new System.Windows.Forms.ToolStripLabel();
            this.LBL_Uusuario = new System.Windows.Forms.ToolStripLabel();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            this.BTN_Cerrar_Sesion = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_Reportes = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBL_Bienvenido,
            this.LBL_Uusuario,
            this.BTN_Salir,
            this.BTN_Cerrar_Sesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(531, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LBL_Bienvenido
            // 
            this.LBL_Bienvenido.Name = "LBL_Bienvenido";
            this.LBL_Bienvenido.Size = new System.Drawing.Size(66, 22);
            this.LBL_Bienvenido.Text = "Bienvenido";
            // 
            // LBL_Uusuario
            // 
            this.LBL_Uusuario.Name = "LBL_Uusuario";
            this.LBL_Uusuario.Size = new System.Drawing.Size(47, 22);
            this.LBL_Uusuario.Text = "Usuario";
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
            // BTN_Cerrar_Sesion
            // 
            this.BTN_Cerrar_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Cerrar_Sesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Cerrar_Sesion.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar_Sesion.Image")));
            this.BTN_Cerrar_Sesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Cerrar_Sesion.Name = "BTN_Cerrar_Sesion";
            this.BTN_Cerrar_Sesion.Size = new System.Drawing.Size(79, 22);
            this.BTN_Cerrar_Sesion.Text = "Cerrar sesion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Capturista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Interacciones";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BTN_Reportes
            // 
            this.BTN_Reportes.Location = new System.Drawing.Point(84, 218);
            this.BTN_Reportes.Name = "BTN_Reportes";
            this.BTN_Reportes.Size = new System.Drawing.Size(75, 23);
            this.BTN_Reportes.TabIndex = 5;
            this.BTN_Reportes.Text = "Reportes";
            this.BTN_Reportes.UseVisualStyleBackColor = true;
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 336);
            this.Controls.Add(this.BTN_Reportes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LBL_Bienvenido;
        private System.Windows.Forms.ToolStripLabel LBL_Uusuario;
        private System.Windows.Forms.ToolStripButton BTN_Salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripButton BTN_Cerrar_Sesion;
        private System.Windows.Forms.Button BTN_Reportes;
    }
}