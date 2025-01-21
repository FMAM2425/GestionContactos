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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnCon;
    }
}

