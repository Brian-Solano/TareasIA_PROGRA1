
namespace TareaConversores
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
            this.cbotipoconversores = new System.Windows.Forms.ComboBox();
            this.lbltipoconversores = new System.Windows.Forms.Label();
            this.cboaconversores = new System.Windows.Forms.ComboBox();
            this.lblaconversores = new System.Windows.Forms.Label();
            this.cbodeconversores = new System.Windows.Forms.ComboBox();
            this.lbldeconversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbotipoconversores
            // 
            this.cbotipoconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipoconversores.FormattingEnabled = true;
            this.cbotipoconversores.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.cbotipoconversores.Location = new System.Drawing.Point(212, 47);
            this.cbotipoconversores.Name = "cbotipoconversores";
            this.cbotipoconversores.Size = new System.Drawing.Size(292, 33);
            this.cbotipoconversores.TabIndex = 15;
            // 
            // lbltipoconversores
            // 
            this.lbltipoconversores.AutoSize = true;
            this.lbltipoconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoconversores.Location = new System.Drawing.Point(100, 47);
            this.lbltipoconversores.Name = "lbltipoconversores";
            this.lbltipoconversores.Size = new System.Drawing.Size(71, 25);
            this.lbltipoconversores.TabIndex = 14;
            this.lbltipoconversores.Text = "TIPO:";
            // 
            // cboaconversores
            // 
            this.cboaconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboaconversores.FormattingEnabled = true;
            this.cboaconversores.Location = new System.Drawing.Point(212, 204);
            this.cboaconversores.Name = "cboaconversores";
            this.cboaconversores.Size = new System.Drawing.Size(292, 33);
            this.cboaconversores.TabIndex = 13;
            // 
            // lblaconversores
            // 
            this.lblaconversores.AutoSize = true;
            this.lblaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaconversores.Location = new System.Drawing.Point(100, 204);
            this.lblaconversores.Name = "lblaconversores";
            this.lblaconversores.Size = new System.Drawing.Size(34, 25);
            this.lblaconversores.TabIndex = 12;
            this.lblaconversores.Text = "A:";
            // 
            // cbodeconversores
            // 
            this.cbodeconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodeconversores.FormattingEnabled = true;
            this.cbodeconversores.Location = new System.Drawing.Point(212, 136);
            this.cbodeconversores.Name = "cbodeconversores";
            this.cbodeconversores.Size = new System.Drawing.Size(292, 33);
            this.cbodeconversores.TabIndex = 11;
            // 
            // lbldeconversor
            // 
            this.lbldeconversor.AutoSize = true;
            this.lbldeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeconversor.Location = new System.Drawing.Point(100, 136);
            this.lbldeconversor.Name = "lbldeconversor";
            this.lbldeconversor.Size = new System.Drawing.Size(50, 25);
            this.lbldeconversor.TabIndex = 10;
            this.lbldeconversor.Text = "DE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbotipoconversores);
            this.Controls.Add(this.lbltipoconversores);
            this.Controls.Add(this.cboaconversores);
            this.Controls.Add(this.lblaconversores);
            this.Controls.Add(this.cbodeconversores);
            this.Controls.Add(this.lbldeconversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotipoconversores;
        private System.Windows.Forms.Label lbltipoconversores;
        private System.Windows.Forms.ComboBox cboaconversores;
        private System.Windows.Forms.Label lblaconversores;
        private System.Windows.Forms.ComboBox cbodeconversores;
        private System.Windows.Forms.Label lbldeconversor;
    }
}

