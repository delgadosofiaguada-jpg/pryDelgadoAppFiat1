namespace pryDelgadoAppFiat11
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            cmdAceptar = new Button();
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstModulo = new ComboBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            cmdCancelar = new Button();
            SuspendLayout();
            // 
            // cmdAceptar
            // 
            cmdAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAceptar.Location = new Point(338, 138);
            cmdAceptar.Margin = new Padding(3, 2, 3, 2);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(91, 32);
            cmdAceptar.TabIndex = 0;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(32, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Login Sinterpart SRL";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = SystemColors.HotTrack;
            txtUsuario.Location = new Point(129, 80);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(133, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = SystemColors.WindowText;
            txtContraseña.Location = new Point(129, 138);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(133, 23);
            txtContraseña.TabIndex = 3;
            // 
            // lstModulo
            // 
            lstModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            lstModulo.Location = new Point(129, 198);
            lstModulo.Margin = new Padding(3, 2, 3, 2);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(133, 23);
            lstModulo.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(32, 82);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(32, 138);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModulo.Location = new Point(32, 200);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(61, 20);
            lblModulo.TabIndex = 7;
            lblModulo.Text = "Módulo";
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(338, 188);
            cmdCancelar.Margin = new Padding(3, 2, 3, 2);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(91, 32);
            cmdCancelar.TabIndex = 8;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 265);
            Controls.Add(cmdCancelar);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(cmdAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAceptar;
        private Label lblTitulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private Button cmdCancelar;
    }
}
