namespace fileWritterWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.TextBox();
            this.escritor = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.TextBox();
            this.duracion = new System.Windows.Forms.TextBox();
            this.clasificacion = new System.Windows.Forms.TextBox();
            this.productora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Totil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(155, 20);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 23);
            this.titulo.TabIndex = 1;
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(155, 61);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(100, 23);
            this.director.TabIndex = 2;
            // 
            // escritor
            // 
            this.escritor.Location = new System.Drawing.Point(155, 100);
            this.escritor.Name = "escritor";
            this.escritor.Size = new System.Drawing.Size(100, 23);
            this.escritor.TabIndex = 3;
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(155, 145);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(100, 23);
            this.genero.TabIndex = 4;
            // 
            // duracion
            // 
            this.duracion.Location = new System.Drawing.Point(155, 192);
            this.duracion.Name = "duracion";
            this.duracion.Size = new System.Drawing.Size(100, 23);
            this.duracion.TabIndex = 5;
            // 
            // clasificacion
            // 
            this.clasificacion.Location = new System.Drawing.Point(155, 234);
            this.clasificacion.Name = "clasificacion";
            this.clasificacion.Size = new System.Drawing.Size(100, 23);
            this.clasificacion.TabIndex = 6;
            // 
            // productora
            // 
            this.productora.Location = new System.Drawing.Point(155, 273);
            this.productora.Name = "productora";
            this.productora.Size = new System.Drawing.Size(100, 23);
            this.productora.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Totil
            // 
            this.Totil.AutoSize = true;
            this.Totil.Location = new System.Drawing.Point(55, 28);
            this.Totil.Name = "Totil";
            this.Totil.Size = new System.Drawing.Size(37, 15);
            this.Totil.TabIndex = 9;
            this.Totil.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Escritor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Clasificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Duracion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Productora";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(78, 314);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 124);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Totil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productora);
            this.Controls.Add(this.clasificacion);
            this.Controls.Add(this.duracion);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.escritor);
            this.Controls.Add(this.director);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox titulo;
        private TextBox director;
        private TextBox escritor;
        private TextBox genero;
        private TextBox duracion;
        private TextBox clasificacion;
        private TextBox productora;
        private Button button1;
        private Label Totil;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
    }
}