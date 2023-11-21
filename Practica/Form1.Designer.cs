namespace Practica
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtAsignacionDia = new TextBox();
            txtDiasLab = new TextBox();
            txtIdentificacion = new TextBox();
            btnRegistro = new Button();
            btnCalcular = new Button();
            label6 = new Label();
            txtValorTd = new TextBox();
            btnNuevo = new Button();
            btnSalir = new Button();
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 35);
            label1.Name = "label1";
            label1.Size = new Size(571, 37);
            label1.TabIndex = 0;
            label1.Text = "CALCULO DE NOMINA DEL TRABAJADOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 121);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 258);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 2;
            label3.Text = "Asignacion Salario Dia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 190);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Identificacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 344);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 4;
            label5.Text = "Dias Laborados";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(226, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtAsignacionDia
            // 
            txtAsignacionDia.Location = new Point(226, 255);
            txtAsignacionDia.Name = "txtAsignacionDia";
            txtAsignacionDia.Size = new Size(149, 27);
            txtAsignacionDia.TabIndex = 6;
            // 
            // txtDiasLab
            // 
            txtDiasLab.Location = new Point(226, 344);
            txtDiasLab.Name = "txtDiasLab";
            txtDiasLab.Size = new Size(149, 27);
            txtDiasLab.TabIndex = 7;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(226, 183);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(149, 27);
            txtIdentificacion.TabIndex = 8;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(554, 144);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(292, 66);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "Guardar el registro del empleado";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(554, 281);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(292, 66);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular Salario";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 453);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 11;
            label6.Text = "Valor Total Devengado";
            // 
            // txtValorTd
            // 
            txtValorTd.Location = new Point(496, 446);
            txtValorTd.Name = "txtValorTd";
            txtValorTd.Size = new Size(149, 27);
            txtValorTd.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(167, 518);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(122, 37);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(662, 518);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 37);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 602);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(txtValorTd);
            Controls.Add(label6);
            Controls.Add(btnCalcular);
            Controls.Add(btnRegistro);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtDiasLab);
            Controls.Add(txtAsignacionDia);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtAsignacionDia;
        private TextBox txtDiasLab;
        private TextBox txtIdentificacion;
        private Button btnRegistro;
        private Button btnCalcular;
        private Label label6;
        private TextBox txtValorTd;
        private Button btnNuevo;
        private Button btnSalir;
        private ErrorProvider error1;
    }
}