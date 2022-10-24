namespace PracticaStruct
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
            this.btnIngresaDatos = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstImprimeDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIngresaDatos
            // 
            this.btnIngresaDatos.Location = new System.Drawing.Point(380, 55);
            this.btnIngresaDatos.Name = "btnIngresaDatos";
            this.btnIngresaDatos.Size = new System.Drawing.Size(235, 23);
            this.btnIngresaDatos.TabIndex = 0;
            this.btnIngresaDatos.Text = "Ingresa Datos";
            this.btnIngresaDatos.UseVisualStyleBackColor = true;
            this.btnIngresaDatos.Click += new System.EventHandler(this.btnIngresaDatos_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(380, 117);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(235, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstImprimeDatos
            // 
            this.lstImprimeDatos.FormattingEnabled = true;
            this.lstImprimeDatos.Location = new System.Drawing.Point(380, 181);
            this.lstImprimeDatos.Name = "lstImprimeDatos";
            this.lstImprimeDatos.Size = new System.Drawing.Size(235, 225);
            this.lstImprimeDatos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstImprimeDatos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnIngresaDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresaDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstImprimeDatos;
    }
}

