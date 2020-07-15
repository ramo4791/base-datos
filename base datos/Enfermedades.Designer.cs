namespace base_datos
{
    partial class Enfermedades
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
            this.components = new System.ComponentModel.Container();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_sistema = new System.Windows.Forms.TextBox();
            this.lab_codigo = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_sistema = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(628, 441);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(88, 29);
            this.bt_salir.TabIndex = 9;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(419, 441);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 8;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(248, 441);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 7;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(61, 441);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 6;
            this.bt_agregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.bt_agregar, "Ingresar datos en cuadros de texto");
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(103, 329);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(120, 20);
            this.tb_codigo.TabIndex = 10;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(379, 329);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(115, 20);
            this.tb_nombre.TabIndex = 11;
            // 
            // tb_sistema
            // 
            this.tb_sistema.Location = new System.Drawing.Point(604, 329);
            this.tb_sistema.Name = "tb_sistema";
            this.tb_sistema.Size = new System.Drawing.Size(112, 20);
            this.tb_sistema.TabIndex = 12;
            // 
            // lab_codigo
            // 
            this.lab_codigo.AutoSize = true;
            this.lab_codigo.Location = new System.Drawing.Point(152, 303);
            this.lab_codigo.Name = "lab_codigo";
            this.lab_codigo.Size = new System.Drawing.Size(40, 13);
            this.lab_codigo.TabIndex = 13;
            this.lab_codigo.Text = "Codigo";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(416, 303);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 14;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_sistema
            // 
            this.lb_sistema.AutoSize = true;
            this.lb_sistema.Location = new System.Drawing.Point(625, 303);
            this.lb_sistema.Name = "lb_sistema";
            this.lb_sistema.Size = new System.Drawing.Size(44, 13);
            this.lb_sistema.TabIndex = 15;
            this.lb_sistema.Text = "Sistema";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.lb_sistema);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lab_codigo);
            this.Controls.Add(this.tb_sistema);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Enfermedades";
            this.Text = "Enfermedades";
            this.Load += new System.EventHandler(this.Enfermedades_Load);
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
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_sistema;
        private System.Windows.Forms.Label lab_codigo;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_sistema;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}