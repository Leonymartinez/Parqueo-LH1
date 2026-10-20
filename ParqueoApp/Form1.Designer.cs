namespace ParqueoApp
{
    partial class Form1
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
            lblTitulo = new Label();
            btnVehiculos = new Button();
            btnRegistros = new Button();
            btnClientes = new Button();
            btnEspacios = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.Control;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(262, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(329, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE GESTIÓN DE PARQUEO";
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehiculos.Location = new Point(245, 127);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(130, 40);
            btnVehiculos.TabIndex = 1;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnRegistros
            // 
            btnRegistros.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistros.Location = new Point(461, 123);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(130, 40);
            btnRegistros.TabIndex = 2;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(245, 77);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(130, 40);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnEspacios
            // 
            btnEspacios.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEspacios.Location = new Point(461, 77);
            btnEspacios.Name = "btnEspacios";
            btnEspacios.Size = new Size(130, 40);
            btnEspacios.TabIndex = 4;
            btnEspacios.Text = "Espacios";
            btnEspacios.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEspacios);
            Controls.Add(btnClientes);
            Controls.Add(btnRegistros);
            Controls.Add(btnVehiculos);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Sistema de Gestión de Parqueo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVehiculos;
        private Button btnRegistros;
        private Button btnClientes;
        private Button btnEspacios;
    }
}
