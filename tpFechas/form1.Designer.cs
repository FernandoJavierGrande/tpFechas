namespace tpFechas
{
    partial class form1
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
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.Boton_diaSig = new System.Windows.Forms.Button();
            this.label_FechaNueva = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(55, 176);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(144, 22);
            this.txt_fecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia siguente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la fecha";
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(149, 365);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 3;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // Boton_diaSig
            // 
            this.Boton_diaSig.Location = new System.Drawing.Point(349, 129);
            this.Boton_diaSig.Name = "Boton_diaSig";
            this.Boton_diaSig.Size = new System.Drawing.Size(127, 35);
            this.Boton_diaSig.TabIndex = 4;
            this.Boton_diaSig.Text = "Dia siguiente";
            this.Boton_diaSig.UseVisualStyleBackColor = true;
            this.Boton_diaSig.Click += new System.EventHandler(this.Boton_diaSig_Click);
            // 
            // label_FechaNueva
            // 
            this.label_FechaNueva.AutoSize = true;
            this.label_FechaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaNueva.Location = new System.Drawing.Point(224, 221);
            this.label_FechaNueva.Name = "label_FechaNueva";
            this.label_FechaNueva.Size = new System.Drawing.Size(0, 29);
            this.label_FechaNueva.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "dd/mm/aaaa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formato:";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_FechaNueva);
            this.Controls.Add(this.Boton_diaSig);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha);
            this.Name = "form1";
            this.Text = "Fechas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Button Boton_diaSig;
        private System.Windows.Forms.Label label_FechaNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

