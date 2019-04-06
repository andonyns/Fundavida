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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.entradaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDeLibros);
            this.Name = "Form1";
            this.Text = "Text1";
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
    }
}

