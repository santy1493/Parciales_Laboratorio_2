
namespace Vista
{
    partial class FormEmpleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblLegajo2 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtLegajoBuscar = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDatosEmpleado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDatosEmpleado);
            this.panel1.Controls.Add(this.dtgvEmpleados);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.lblLegajo2);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblCuil);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblLegajo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtLegajoBuscar);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtLegajo);
            this.panel1.Controls.Add(this.txtCuil);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(264, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 444);
            this.panel1.TabIndex = 6;
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.nombreApellido,
            this.cuil,
            this.usuario});
            this.dtgvEmpleados.Location = new System.Drawing.Point(15, 162);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.RowTemplate.Height = 25;
            this.dtgvEmpleados.Size = new System.Drawing.Size(738, 269);
            this.dtgvEmpleados.TabIndex = 16;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.Width = 75;
            // 
            // nombreApellido
            // 
            this.nombreApellido.HeaderText = "Apellido y Nombre";
            this.nombreApellido.Name = "nombreApellido";
            this.nombreApellido.Width = 270;
            // 
            // cuil
            // 
            this.cuil.HeaderText = "CUIL";
            this.cuil.Name = "cuil";
            this.cuil.Width = 175;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Nombre Usuario";
            this.usuario.Name = "usuario";
            this.usuario.Width = 175;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(147, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(437, 124);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(122, 27);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblLegajo2
            // 
            this.lblLegajo2.AutoSize = true;
            this.lblLegajo2.Location = new System.Drawing.Point(15, 20);
            this.lblLegajo2.Name = "lblLegajo2";
            this.lblLegajo2.Size = new System.Drawing.Size(42, 15);
            this.lblLegajo2.TabIndex = 13;
            this.lblLegajo2.Text = "Legajo";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(575, 68);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 15);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Contraseña";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(575, 20);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(32, 15);
            this.lblCuil.TabIndex = 11;
            this.lblCuil.Text = "CUIL";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(437, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 15);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Nombre Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(437, 20);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(293, 66);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 15);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(293, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtLegajoBuscar
            // 
            this.txtLegajoBuscar.Location = new System.Drawing.Point(15, 38);
            this.txtLegajoBuscar.Name = "txtLegajoBuscar";
            this.txtLegajoBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtLegajoBuscar.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(575, 84);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(115, 23);
            this.txtPass.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(437, 84);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(122, 23);
            this.txtUser.TabIndex = 4;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(293, 84);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(124, 23);
            this.txtLegajo.TabIndex = 3;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(575, 38);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(115, 23);
            this.txtCuil.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(437, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(122, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(293, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosEmpleado.Location = new System.Drawing.Point(15, 68);
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblDatosEmpleado.TabIndex = 17;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 535);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label lblLegajo2;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtLegajoBuscar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDatosEmpleado;
    }
}