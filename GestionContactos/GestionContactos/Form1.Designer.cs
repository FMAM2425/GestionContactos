namespace GestionContactos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnCon = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnCon
            // 
            this.btnAnCon.Location = new System.Drawing.Point(12, 12);
            this.btnAnCon.Name = "btnAnCon";
            this.btnAnCon.Size = new System.Drawing.Size(123, 41);
            this.btnAnCon.TabIndex = 0;
            this.btnAnCon.Text = "Añadir contacto";
            this.btnAnCon.UseVisualStyleBackColor = true;
            this.btnAnCon.Click += new System.EventHandler(this.btnAnCon_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 43);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar contacto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(12, 146);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(123, 45);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modificar telefono";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 221);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(123, 42);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Contactos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnCon;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnMostrar;
    }
}

