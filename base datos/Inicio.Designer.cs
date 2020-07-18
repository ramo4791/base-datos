namespace base_datos
{
    partial class Inicio
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
            this.butt_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matenimientoDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padeceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butt_cerrar
            // 
            this.butt_cerrar.Location = new System.Drawing.Point(617, 358);
            this.butt_cerrar.Name = "butt_cerrar";
            this.butt_cerrar.Size = new System.Drawing.Size(114, 23);
            this.butt_cerrar.TabIndex = 0;
            this.butt_cerrar.Text = "Cerrar";
            this.butt_cerrar.UseVisualStyleBackColor = true;
            this.butt_cerrar.Click += new System.EventHandler(this.butt_cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matenimientoDatosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matenimientoDatosToolStripMenuItem
            // 
            this.matenimientoDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.enfermedadesToolStripMenuItem,
            this.padeceToolStripMenuItem});
            this.matenimientoDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.matenimientoDatosToolStripMenuItem.Name = "matenimientoDatosToolStripMenuItem";
            this.matenimientoDatosToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.matenimientoDatosToolStripMenuItem.Text = "Matenimiento Datos";
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.medicosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // enfermedadesToolStripMenuItem
            // 
            this.enfermedadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.enfermedadesToolStripMenuItem.Name = "enfermedadesToolStripMenuItem";
            this.enfermedadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enfermedadesToolStripMenuItem.Text = "Enfermedades";
            this.enfermedadesToolStripMenuItem.Click += new System.EventHandler(this.enfermedadesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // padeceToolStripMenuItem
            // 
            this.padeceToolStripMenuItem.Name = "padeceToolStripMenuItem";
            this.padeceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.padeceToolStripMenuItem.Text = "Padece";
            this.padeceToolStripMenuItem.Click += new System.EventHandler(this.padeceToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matenimientoDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padeceToolStripMenuItem;
    }
}