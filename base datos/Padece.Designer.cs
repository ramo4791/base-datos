namespace base_datos
{
    partial class Padece
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
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_enfermedad = new System.Windows.Forms.ComboBox();
            this.cb_paciente = new System.Windows.Forms.ComboBox();
            this.dt_fechae = new System.Windows.Forms.DateTimePicker();
            this.lb_code = new System.Windows.Forms.Label();
            this.lb_paciente = new System.Windows.Forms.Label();
            this.lb_fechae = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(248, 358);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 25;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Visible = false;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(628, 388);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(88, 29);
            this.bt_salir.TabIndex = 24;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(419, 388);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 23;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(248, 388);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 22;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(61, 388);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 21;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 226);
            this.dataGridView1.TabIndex = 20;
            // 
            // cb_enfermedad
            // 
            this.cb_enfermedad.FormattingEnabled = true;
            this.cb_enfermedad.Location = new System.Drawing.Point(320, 309);
            this.cb_enfermedad.Name = "cb_enfermedad";
            this.cb_enfermedad.Size = new System.Drawing.Size(121, 21);
            this.cb_enfermedad.TabIndex = 26;
            this.cb_enfermedad.SelectedValueChanged += new System.EventHandler(this.cb_enfermedad_SelectedValueChanged);
            // 
            // cb_paciente
            // 
            this.cb_paciente.FormattingEnabled = true;
            this.cb_paciente.Location = new System.Drawing.Point(46, 305);
            this.cb_paciente.Name = "cb_paciente";
            this.cb_paciente.Size = new System.Drawing.Size(121, 21);
            this.cb_paciente.TabIndex = 27;
            this.cb_paciente.SelectedValueChanged += new System.EventHandler(this.cb_paciente_SelectedValueChanged);
            // 
            // dt_fechae
            // 
            this.dt_fechae.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechae.Location = new System.Drawing.Point(538, 305);
            this.dt_fechae.Name = "dt_fechae";
            this.dt_fechae.Size = new System.Drawing.Size(119, 20);
            this.dt_fechae.TabIndex = 28;
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Location = new System.Drawing.Point(346, 290);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(64, 13);
            this.lb_code.TabIndex = 29;
            this.lb_code.Text = "Enfermedad";
            // 
            // lb_paciente
            // 
            this.lb_paciente.AutoSize = true;
            this.lb_paciente.Location = new System.Drawing.Point(87, 290);
            this.lb_paciente.Name = "lb_paciente";
            this.lb_paciente.Size = new System.Drawing.Size(49, 13);
            this.lb_paciente.TabIndex = 30;
            this.lb_paciente.Text = "Paciente";
            // 
            // lb_fechae
            // 
            this.lb_fechae.AutoSize = true;
            this.lb_fechae.Location = new System.Drawing.Point(535, 290);
            this.lb_fechae.Name = "lb_fechae";
            this.lb_fechae.Size = new System.Drawing.Size(97, 13);
            this.lb_fechae.TabIndex = 31;
            this.lb_fechae.Text = "Fecha Enfermedad";
            // 
            // Padece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lb_fechae);
            this.Controls.Add(this.lb_paciente);
            this.Controls.Add(this.lb_code);
            this.Controls.Add(this.dt_fechae);
            this.Controls.Add(this.cb_paciente);
            this.Controls.Add(this.cb_enfermedad);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Padece";
            this.Text = "Padece";
            this.Load += new System.EventHandler(this.Padece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_enfermedad;
        private System.Windows.Forms.ComboBox cb_paciente;
        private System.Windows.Forms.DateTimePicker dt_fechae;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.Label lb_paciente;
        private System.Windows.Forms.Label lb_fechae;
    }
}