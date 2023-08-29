
namespace ejercicios
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
            this.btnconvertirconversores = new System.Windows.Forms.Button();
            this.lbldeconversor = new System.Windows.Forms.Label();
            this.cbodeconversores = new System.Windows.Forms.ComboBox();
            this.cboaconversores = new System.Windows.Forms.ComboBox();
            this.lblaconversores = new System.Windows.Forms.Label();
            this.lblrespuestasconversores = new System.Windows.Forms.Label();
            this.lblcantidadconverores = new System.Windows.Forms.Label();
            this.txtcantidadconversores = new System.Windows.Forms.TextBox();
            this.cbotipoconversores = new System.Windows.Forms.ComboBox();
            this.lbltipoconversores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconvertirconversores
            // 
            this.btnconvertirconversores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnconvertirconversores.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirconversores.ForeColor = System.Drawing.Color.Blue;
            this.btnconvertirconversores.Location = new System.Drawing.Point(563, 209);
            this.btnconvertirconversores.Name = "btnconvertirconversores";
            this.btnconvertirconversores.Size = new System.Drawing.Size(235, 75);
            this.btnconvertirconversores.TabIndex = 0;
            this.btnconvertirconversores.Text = "CONVERTIR";
            this.btnconvertirconversores.UseVisualStyleBackColor = false;
            this.btnconvertirconversores.Click += new System.EventHandler(this.btnconvertirconversores_Click);
            // 
            // lbldeconversor
            // 
            this.lbldeconversor.AutoSize = true;
            this.lbldeconversor.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeconversor.Location = new System.Drawing.Point(61, 183);
            this.lbldeconversor.Name = "lbldeconversor";
            this.lbldeconversor.Size = new System.Drawing.Size(45, 23);
            this.lbldeconversor.TabIndex = 1;
            this.lbldeconversor.Text = "DE:";
            // 
            // cbodeconversores
            // 
            this.cbodeconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodeconversores.FormattingEnabled = true;
            this.cbodeconversores.Location = new System.Drawing.Point(173, 183);
            this.cbodeconversores.Name = "cbodeconversores";
            this.cbodeconversores.Size = new System.Drawing.Size(292, 33);
            this.cbodeconversores.TabIndex = 2;
            this.cbodeconversores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboaconversores
            // 
            this.cboaconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboaconversores.FormattingEnabled = true;
            this.cboaconversores.Location = new System.Drawing.Point(173, 251);
            this.cboaconversores.Name = "cboaconversores";
            this.cboaconversores.Size = new System.Drawing.Size(292, 33);
            this.cboaconversores.TabIndex = 4;
            this.cboaconversores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblaconversores
            // 
            this.lblaconversores.AutoSize = true;
            this.lblaconversores.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaconversores.Location = new System.Drawing.Point(61, 251);
            this.lblaconversores.Name = "lblaconversores";
            this.lblaconversores.Size = new System.Drawing.Size(31, 23);
            this.lblaconversores.TabIndex = 3;
            this.lblaconversores.Text = "A:";
            this.lblaconversores.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrespuestasconversores
            // 
            this.lblrespuestasconversores.AutoSize = true;
            this.lblrespuestasconversores.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestasconversores.Location = new System.Drawing.Point(496, 151);
            this.lblrespuestasconversores.Name = "lblrespuestasconversores";
            this.lblrespuestasconversores.Size = new System.Drawing.Size(209, 36);
            this.lblrespuestasconversores.TabIndex = 5;
            this.lblrespuestasconversores.Text = "Respuesta: ?";
            this.lblrespuestasconversores.Click += new System.EventHandler(this.lblrespuestasconversores_Click);
            // 
            // lblcantidadconverores
            // 
            this.lblcantidadconverores.AutoSize = true;
            this.lblcantidadconverores.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadconverores.Location = new System.Drawing.Point(496, 94);
            this.lblcantidadconverores.Name = "lblcantidadconverores";
            this.lblcantidadconverores.Size = new System.Drawing.Size(182, 36);
            this.lblcantidadconverores.TabIndex = 6;
            this.lblcantidadconverores.Text = "Cantidad:";
            this.lblcantidadconverores.Click += new System.EventHandler(this.lblcantidadconverores_Click);
            // 
            // txtcantidadconversores
            // 
            this.txtcantidadconversores.Location = new System.Drawing.Point(684, 83);
            this.txtcantidadconversores.Multiline = true;
            this.txtcantidadconversores.Name = "txtcantidadconversores";
            this.txtcantidadconversores.Size = new System.Drawing.Size(220, 47);
            this.txtcantidadconversores.TabIndex = 7;
            this.txtcantidadconversores.TextChanged += new System.EventHandler(this.txtcantidadconversores_TextChanged);
            // 
            // cbotipoconversores
            // 
            this.cbotipoconversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipoconversores.FormattingEnabled = true;
            this.cbotipoconversores.Items.AddRange(new object[] {
            "Area"});
            this.cbotipoconversores.Location = new System.Drawing.Point(173, 94);
            this.cbotipoconversores.Name = "cbotipoconversores";
            this.cbotipoconversores.Size = new System.Drawing.Size(292, 33);
            this.cbotipoconversores.TabIndex = 9;
            this.cbotipoconversores.SelectedIndexChanged += new System.EventHandler(this.cbotipoconversores_SelectedIndexChanged);
            this.cbotipoconversores.TextChanged += new System.EventHandler(this.cbotipoconversores_TextChanged);
            // 
            // lbltipoconversores
            // 
            this.lbltipoconversores.AutoSize = true;
            this.lbltipoconversores.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoconversores.Location = new System.Drawing.Point(61, 94);
            this.lbltipoconversores.Name = "lbltipoconversores";
            this.lbltipoconversores.Size = new System.Drawing.Size(66, 23);
            this.lbltipoconversores.TabIndex = 8;
            this.lbltipoconversores.Text = "TIPO:";
            this.lbltipoconversores.Click += new System.EventHandler(this.lbltipoconversores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.cbotipoconversores);
            this.Controls.Add(this.lbltipoconversores);
            this.Controls.Add(this.txtcantidadconversores);
            this.Controls.Add(this.lblcantidadconverores);
            this.Controls.Add(this.lblrespuestasconversores);
            this.Controls.Add(this.cboaconversores);
            this.Controls.Add(this.lblaconversores);
            this.Controls.Add(this.cbodeconversores);
            this.Controls.Add(this.lbldeconversor);
            this.Controls.Add(this.btnconvertirconversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertirconversores;
        private System.Windows.Forms.Label lbldeconversor;
        private System.Windows.Forms.ComboBox cbodeconversores;
        private System.Windows.Forms.ComboBox cboaconversores;
        private System.Windows.Forms.Label lblaconversores;
        private System.Windows.Forms.Label lblrespuestasconversores;
        private System.Windows.Forms.Label lblcantidadconverores;
        private System.Windows.Forms.TextBox txtcantidadconversores;
        private System.Windows.Forms.ComboBox cbotipoconversores;
        private System.Windows.Forms.Label lbltipoconversores;
    }
}

