namespace base_datos
{
    partial class Medicos
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
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_dire = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_matricula = new System.Windows.Forms.Label();
            this.lb_tel = new System.Windows.Forms.Label();
            this.lb_dire = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.bt_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(628, 409);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(88, 29);
            this.bt_salir.TabIndex = 9;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(419, 409);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 8;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(248, 409);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 7;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(61, 409);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 6;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 226);
            this.dataGridView1.TabIndex = 5;
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(72, 306);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(100, 20);
            this.tb_dni.TabIndex = 10;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(223, 306);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 11;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(373, 306);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(100, 20);
            this.tb_apellido.TabIndex = 11;
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(531, 306);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(100, 20);
            this.tb_matricula.TabIndex = 11;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(72, 352);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 20);
            this.tb_tel.TabIndex = 10;
            // 
            // tb_dire
            // 
            this.tb_dire.Location = new System.Drawing.Point(223, 352);
            this.tb_dire.Name = "tb_dire";
            this.tb_dire.Size = new System.Drawing.Size(100, 20);
            this.tb_dire.TabIndex = 11;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(373, 352);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(258, 20);
            this.tb_email.TabIndex = 11;
            // 
            // lb_dni
            // 
            this.lb_dni.AutoSize = true;
            this.lb_dni.Location = new System.Drawing.Point(90, 290);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(32, 13);
            this.lb_dni.TabIndex = 12;
            this.lb_dni.Text = "D.N.I";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(245, 290);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 13;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Location = new System.Drawing.Point(416, 290);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(44, 13);
            this.lb_apellido.TabIndex = 14;
            this.lb_apellido.Text = "Apellido";
            // 
            // lb_matricula
            // 
            this.lb_matricula.AutoSize = true;
            this.lb_matricula.Location = new System.Drawing.Point(567, 290);
            this.lb_matricula.Name = "lb_matricula";
            this.lb_matricula.Size = new System.Drawing.Size(50, 13);
            this.lb_matricula.TabIndex = 15;
            this.lb_matricula.Text = "Matricula";
            // 
            // lb_tel
            // 
            this.lb_tel.AutoSize = true;
            this.lb_tel.Location = new System.Drawing.Point(90, 330);
            this.lb_tel.Name = "lb_tel";
            this.lb_tel.Size = new System.Drawing.Size(49, 13);
            this.lb_tel.TabIndex = 16;
            this.lb_tel.Text = "Telefono";
            // 
            // lb_dire
            // 
            this.lb_dire.AutoSize = true;
            this.lb_dire.Location = new System.Drawing.Point(245, 330);
            this.lb_dire.Name = "lb_dire";
            this.lb_dire.Size = new System.Drawing.Size(52, 13);
            this.lb_dire.TabIndex = 17;
            this.lb_dire.Text = "Direccion";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(482, 330);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 18;
            this.lb_email.Text = "Email";
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(248, 379);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 19;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Visible = false;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_dire);
            this.Controls.Add(this.lb_tel);
            this.Controls.Add(this.lb_matricula);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_dire);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medicos";
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_dire;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_matricula;
        private System.Windows.Forms.Label lb_tel;
        private System.Windows.Forms.Label lb_dire;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Button bt_aceptar;
    }
}