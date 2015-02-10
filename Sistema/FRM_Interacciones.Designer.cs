namespace Sistema
{
    partial class FRM_Interacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Interacciones));
            this.BRR_Superior = new System.Windows.Forms.ToolStrip();
            this.BTM_Regresar = new System.Windows.Forms.ToolStripButton();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            this.BRR_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRR_Superior
            // 
            this.BRR_Superior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTM_Regresar,
            this.BTN_Salir});
            this.BRR_Superior.Location = new System.Drawing.Point(0, 0);
            this.BRR_Superior.Name = "BRR_Superior";
            this.BRR_Superior.Size = new System.Drawing.Size(682, 25);
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
            // FRM_Interacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 520);
            this.Controls.Add(this.BRR_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Interacciones";
            this.Text = "FRM_Interacciones";
            this.BRR_Superior.ResumeLayout(false);
            this.BRR_Superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BRR_Superior;
        private System.Windows.Forms.ToolStripButton BTM_Regresar;
        private System.Windows.Forms.ToolStripButton BTN_Salir;


    }
}