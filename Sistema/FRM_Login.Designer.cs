namespace Sistema
{
    partial class FRM_Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.LBL_Contraseña = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Contraseña = new System.Windows.Forms.TextBox();
            this.PAN_Login = new System.Windows.Forms.Panel();
            this.PAN_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Location = new System.Drawing.Point(48, 141);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Entrar.TabIndex = 0;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Location = new System.Drawing.Point(157, 141);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(75, 23);
            this.BTN_Salir.TabIndex = 1;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Location = new System.Drawing.Point(45, 46);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(43, 13);
            this.LBL_Usuario.TabIndex = 2;
            this.LBL_Usuario.Text = "Usuario";
            // 
            // LBL_Contraseña
            // 
            this.LBL_Contraseña.AutoSize = true;
            this.LBL_Contraseña.Location = new System.Drawing.Point(45, 94);
            this.LBL_Contraseña.Name = "LBL_Contraseña";
            this.LBL_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.LBL_Contraseña.TabIndex = 3;
            this.LBL_Contraseña.Text = "Contraseña";
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(94, 39);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(138, 20);
            this.TXT_Usuario.TabIndex = 4;
            // 
            // TXT_Contraseña
            // 
            this.TXT_Contraseña.Location = new System.Drawing.Point(112, 87);
            this.TXT_Contraseña.Name = "TXT_Contraseña";
            this.TXT_Contraseña.PasswordChar = '*';
            this.TXT_Contraseña.Size = new System.Drawing.Size(120, 20);
            this.TXT_Contraseña.TabIndex = 5;
            // 
            // PAN_Login
            // 
            this.PAN_Login.Controls.Add(this.TXT_Contraseña);
            this.PAN_Login.Controls.Add(this.TXT_Usuario);
            this.PAN_Login.Controls.Add(this.LBL_Contraseña);
            this.PAN_Login.Controls.Add(this.LBL_Usuario);
            this.PAN_Login.Controls.Add(this.BTN_Salir);
            this.PAN_Login.Controls.Add(this.BTN_Entrar);
            this.PAN_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_Login.Location = new System.Drawing.Point(0, 0);
            this.PAN_Login.Name = "PAN_Login";
            this.PAN_Login.Size = new System.Drawing.Size(284, 192);
            this.PAN_Login.TabIndex = 6;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.PAN_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Login";
            this.Text = "Login";
            this.PAN_Login.ResumeLayout(false);
            this.PAN_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label LBL_Contraseña;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Contraseña;
        private System.Windows.Forms.Panel PAN_Login;
    }
}

