namespace Biblioteca
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
            this.listaDeLibros = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.entradaCodigo = new System.Windows.Forms.TextBox();
            this.entradaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.entradaAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entradaPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.etiquetaErrores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaDeLibros
            // 
            this.listaDeLibros.Cursor = System.Windows.Forms.Cursors.Default;
            this.listaDeLibros.Location = new System.Drawing.Point(360, 28);
            this.listaDeLibros.Name = "listaDeLibros";
            this.listaDeLibros.Size = new System.Drawing.Size(428, 400);
            this.listaDeLibros.TabIndex = 0;
            this.listaDeLibros.UseCompatibleStateImageBehavior = false;
            this.listaDeLibros.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // entradaCodigo
            // 
            this.entradaCodigo.Location = new System.Drawing.Point(35, 44);
            this.entradaCodigo.Name = "entradaCodigo";
            this.entradaCodigo.Size = new System.Drawing.Size(231, 20);
            this.entradaCodigo.TabIndex = 2;
            // 
            // entradaNombre
            // 
            this.entradaNombre.Location = new System.Drawing.Point(35, 97);
            this.entradaNombre.Name = "entradaNombre";
            this.entradaNombre.Size = new System.Drawing.Size(231, 20);
            this.entradaNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(35, 231);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // entradaAutor
            // 
            this.entradaAutor.Location = new System.Drawing.Point(35, 147);
            this.entradaAutor.Name = "entradaAutor";
            this.entradaAutor.Size = new System.Drawing.Size(231, 20);
            this.entradaAutor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor";
            // 
            // entradaPrecio
            // 
            this.entradaPrecio.Location = new System.Drawing.Point(35, 195);
            this.entradaPrecio.Name = "entradaPrecio";
            this.entradaPrecio.Size = new System.Drawing.Size(231, 20);
            this.entradaPrecio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // etiquetaErrores
            // 
            this.etiquetaErrores.AutoSize = true;
            this.etiquetaErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaErrores.ForeColor = System.Drawing.Color.Red;
            this.etiquetaErrores.Location = new System.Drawing.Point(35, 354);
            this.etiquetaErrores.MaximumSize = new System.Drawing.Size(300, 300);
            this.etiquetaErrores.Name = "etiquetaErrores";
            this.etiquetaErrores.Size = new System.Drawing.Size(0, 16);
            this.etiquetaErrores.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaErrores);
            this.Controls.Add(this.entradaPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entradaAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.entradaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDeLibros);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaDeLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entradaCodigo;
        private System.Windows.Forms.TextBox entradaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox entradaAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entradaPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label etiquetaErrores;
    }
}

