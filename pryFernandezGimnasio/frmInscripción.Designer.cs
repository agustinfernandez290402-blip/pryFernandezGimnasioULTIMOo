namespace pryFernandezGimnasio
{
    partial class frmInscripción
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripción));
            groupBoxDatosPersonales = new GroupBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            gropuBoxPlan = new GroupBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            lblMeses = new Label();
            lblTurno = new Label();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            lblPlan = new Label();
            cboPago = new GroupBox();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            Clientes = new ListBox();
            btnConsultar = new Button();
            groupBoxDatosPersonales.SuspendLayout();
            gropuBoxPlan.SuspendLayout();
            cboPago.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDatosPersonales
            // 
            groupBoxDatosPersonales.Controls.Add(txtApellido);
            groupBoxDatosPersonales.Controls.Add(lblApellido);
            groupBoxDatosPersonales.Controls.Add(chkEstudiante);
            groupBoxDatosPersonales.Controls.Add(txtEdad);
            groupBoxDatosPersonales.Controls.Add(txtNombre);
            groupBoxDatosPersonales.Controls.Add(lblEdad);
            groupBoxDatosPersonales.Controls.Add(lblNombre);
            groupBoxDatosPersonales.Location = new Point(25, 12);
            groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            groupBoxDatosPersonales.Size = new Size(443, 153);
            groupBoxDatosPersonales.TabIndex = 0;
            groupBoxDatosPersonales.TabStop = false;
            groupBoxDatosPersonales.Text = "Datos Personales";
            groupBoxDatosPersonales.Enter += groupBox1_Enter;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(315, 45);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(118, 27);
            txtApellido.TabIndex = 8;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(239, 49);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(239, 92);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(100, 24);
            chkEstudiante.TabIndex = 6;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(101, 89);
            txtEdad.MaxLength = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(118, 27);
            txtEdad.TabIndex = 4;
            txtEdad.TextChanged += txtNombre_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 27);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(39, 92);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // gropuBoxPlan
            // 
            gropuBoxPlan.Controls.Add(chkCasillero);
            gropuBoxPlan.Controls.Add(txtMeses);
            gropuBoxPlan.Controls.Add(lblMeses);
            gropuBoxPlan.Controls.Add(lblTurno);
            gropuBoxPlan.Controls.Add(cboTurno);
            gropuBoxPlan.Controls.Add(cboPlan);
            gropuBoxPlan.Controls.Add(lblPlan);
            gropuBoxPlan.Location = new Point(25, 171);
            gropuBoxPlan.Name = "gropuBoxPlan";
            gropuBoxPlan.Size = new Size(443, 145);
            gropuBoxPlan.TabIndex = 1;
            gropuBoxPlan.TabStop = false;
            gropuBoxPlan.Text = "Plan";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(239, 93);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(182, 24);
            chkCasillero.TabIndex = 6;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(101, 91);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(118, 27);
            txtMeses.TabIndex = 5;
            txtMeses.TextChanged += txtNombre_TextChanged;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(39, 96);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(36, 20);
            lblMeses.TabIndex = 4;
            lblMeses.Text = "Mes";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(239, 43);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(47, 20);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana ", "Tarde", "Noche " });
            cboTurno.Location = new Point(315, 37);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(118, 28);
            cboTurno.TabIndex = 2;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(101, 37);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(118, 28);
            cboPlan.TabIndex = 2;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(32, 40);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // cboPago
            // 
            cboPago.Controls.Add(lblCuotas);
            cboPago.Controls.Add(cboCuotas);
            cboPago.Controls.Add(rbtTarjeta);
            cboPago.Controls.Add(rbtEfectivo);
            cboPago.Location = new Point(25, 323);
            cboPago.Name = "cboPago";
            cboPago.Size = new Size(443, 107);
            cboPago.TabIndex = 2;
            cboPago.TabStop = false;
            cboPago.Text = "Forma de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(239, 49);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(54, 20);
            lblCuotas.TabIndex = 4;
            lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1  ", "3", "6 " });
            cboCuotas.Location = new Point(323, 45);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(110, 28);
            cboCuotas.TabIndex = 2;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(128, 47);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(74, 24);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(18, 47);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(83, 24);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(267, 440);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(375, 440);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Clientes
            // 
            Clientes.FormattingEnabled = true;
            Clientes.HorizontalScrollbar = true;
            Clientes.Location = new Point(487, 24);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(379, 264);
            Clientes.TabIndex = 5;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(512, 319);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmInscripción
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 484);
            Controls.Add(btnConsultar);
            Controls.Add(Clientes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cboPago);
            Controls.Add(gropuBoxPlan);
            Controls.Add(groupBoxDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInscripción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción ";
            Load += frmInscripción_Load;
            groupBoxDatosPersonales.ResumeLayout(false);
            groupBoxDatosPersonales.PerformLayout();
            gropuBoxPlan.ResumeLayout(false);
            gropuBoxPlan.PerformLayout();
            cboPago.ResumeLayout(false);
            cboPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDatosPersonales;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private CheckBox chkEstudiante;
        private GroupBox gropuBoxPlan;
        private ComboBox cboPlan;
        private Label lblPlan;
        private ComboBox cboCuotas;
        private ComboBox cboTurno;
        private CheckBox chkCasillero;
        private TextBox txtMeses;
        private Label lblMeses;
        private Label lblTurno;
        private GroupBox cboPago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Label lblCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private ListBox Clientes;
        private Button btnConsultar;
    }
}
