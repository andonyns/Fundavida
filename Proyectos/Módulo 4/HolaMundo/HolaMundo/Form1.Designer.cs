namespace HolaMundo
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
            this.saludo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaNombre = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.saludoConNombre = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.Location = new System.Drawing.Point(244, 9);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(305, 54);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Hola Mundo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite su nombre:";
            // 
            // entradaNombre
            // 
            this.entradaNombre.Location = new System.Drawing.Point(45, 125);
            this.entradaNombre.Name = "entradaNombre";
            this.entradaNombre.Size = new System.Drawing.Size(279, 20);
            this.entradaNombre.TabIndex = 2;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(357, 123);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 3;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // saludoConNombre
            // 
            this.saludoConNombre.AutoSize = true;
            this.saludoConNombre.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludoConNombre.Location = new System.Drawing.Point(248, 198);
            this.saludoConNombre.Name = "saludoConNombre";
            this.saludoConNombre.Size = new System.Drawing.Size(0, 54);
            this.saludoConNombre.TabIndex = 4;
            // 
            // botonCerrar
            // 
            this.botonCerrar.Location = new System.Drawing.Point(676, 405);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.botonCerrar.TabIndex = 5;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.saludoConNombre);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.entradaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saludo);
            this.Name = "Form1";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entradaNombre;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label saludoConNombre;
        private System.Windows.Forms.Button botonCerrar;
    }
}

