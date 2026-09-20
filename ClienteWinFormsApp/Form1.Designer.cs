namespace ClienteWinFormsApp
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
            dgvEstudiantes = new DataGridView();
            btnCargar = new Button();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatricula = new TextBox();
            txtCarrera = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            label7 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(12, 319);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(858, 216);
            dgvEstudiantes.TabIndex = 0;
            dgvEstudiantes.CellContentClick += dgvEstudiantes_CellContentClick;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(12, 532);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(119, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar estudiantes";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textNombre_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(18, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(72, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 51);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(353, 46);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(341, 75);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 112);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 112);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 80);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 13;
            label6.Text = "Carrera:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(146, 106);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(105, 23);
            dtpFechaNacimiento.TabIndex = 14;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(392, 106);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(106, 23);
            dtpFechaIngreso.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 137);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 16;
            label7.Tag = "";
            label7.Text = "Correo:";
            label7.Click += label7_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(341, 134);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(80, 134);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 137);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 19;
            label8.Text = "Teléfono:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 585);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCarrera);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(btnCargar);
            Controls.Add(dgvEstudiantes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstudiantes;
        private Button btnCargar;
        private TextBox txtNombre;
        private Button btnGuardar;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMatricula;
        private TextBox txtCarrera;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private Label label7;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label8;
    }
}
