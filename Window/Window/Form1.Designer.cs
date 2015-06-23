namespace Window
{
    partial class Form1
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
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.Boton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(104, 59);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(76, 20);
            this.Etiqueta1.TabIndex = 0;
            this.Etiqueta1.Text = "Mensaje";
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(108, 123);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(75, 23);
            this.Boton1.TabIndex = 1;
            this.Boton1.Text = "Clicl aquí";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.Etiqueta1);
            this.Name = "Form1";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button Boton1;
    }
}

