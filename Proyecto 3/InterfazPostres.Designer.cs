namespace Proyecto_3
{
    partial class InterfazPostres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListIngredientes = new System.Windows.Forms.ListBox();
            this.buttonMostrarIngredientes = new System.Windows.Forms.Button();
            this.buttonAltaPostre = new System.Windows.Forms.Button();
            this.buttonBajaPostre = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxPostres = new System.Windows.Forms.ComboBox();
            this.comboBoxIngredientes = new System.Windows.Forms.ComboBox();
            this.buttonInsertarIngredientes = new System.Windows.Forms.Button();
            this.buttonEliminarIngredientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 79);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_3.Properties.Resources._186150;
            this.pictureBox1.Location = new System.Drawing.Point(482, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postres ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(21, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 218);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListIngredientes);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            // 
            // ListIngredientes
            // 
            this.ListIngredientes.Enabled = false;
            this.ListIngredientes.FormattingEnabled = true;
            this.ListIngredientes.Location = new System.Drawing.Point(6, 19);
            this.ListIngredientes.Name = "ListIngredientes";
            this.ListIngredientes.Size = new System.Drawing.Size(554, 173);
            this.ListIngredientes.TabIndex = 13;
            this.ListIngredientes.SelectedIndexChanged += new System.EventHandler(this.ListIngredientes_SelectedIndexChanged);
            // 
            // buttonMostrarIngredientes
            // 
            this.buttonMostrarIngredientes.BackColor = System.Drawing.Color.Pink;
            this.buttonMostrarIngredientes.Location = new System.Drawing.Point(650, 219);
            this.buttonMostrarIngredientes.Name = "buttonMostrarIngredientes";
            this.buttonMostrarIngredientes.Size = new System.Drawing.Size(117, 52);
            this.buttonMostrarIngredientes.TabIndex = 2;
            this.buttonMostrarIngredientes.Text = "Mostrar ingredientes";
            this.buttonMostrarIngredientes.UseVisualStyleBackColor = false;
            this.buttonMostrarIngredientes.Click += new System.EventHandler(this.buttonMostrarIngredientes_Click);
            // 
            // buttonAltaPostre
            // 
            this.buttonAltaPostre.BackColor = System.Drawing.Color.Pink;
            this.buttonAltaPostre.Location = new System.Drawing.Point(650, 103);
            this.buttonAltaPostre.Name = "buttonAltaPostre";
            this.buttonAltaPostre.Size = new System.Drawing.Size(117, 52);
            this.buttonAltaPostre.TabIndex = 4;
            this.buttonAltaPostre.Text = "Dar de alta un postre";
            this.buttonAltaPostre.UseVisualStyleBackColor = false;
            this.buttonAltaPostre.Click += new System.EventHandler(this.buttonAltaPostre_Click);
            // 
            // buttonBajaPostre
            // 
            this.buttonBajaPostre.BackColor = System.Drawing.Color.Pink;
            this.buttonBajaPostre.Location = new System.Drawing.Point(650, 161);
            this.buttonBajaPostre.Name = "buttonBajaPostre";
            this.buttonBajaPostre.Size = new System.Drawing.Size(117, 52);
            this.buttonBajaPostre.TabIndex = 5;
            this.buttonBajaPostre.Text = "Dar de baja un postre";
            this.buttonBajaPostre.UseVisualStyleBackColor = false;
            this.buttonBajaPostre.Click += new System.EventHandler(this.buttonBajaPostre_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSalir.Location = new System.Drawing.Point(650, 393);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(117, 52);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxPostres
            // 
            this.comboBoxPostres.FormattingEnabled = true;
            this.comboBoxPostres.Location = new System.Drawing.Point(135, 110);
            this.comboBoxPostres.Name = "comboBoxPostres";
            this.comboBoxPostres.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPostres.TabIndex = 0;
            this.comboBoxPostres.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostres_SelectedIndexChanged);
            // 
            // comboBoxIngredientes
            // 
            this.comboBoxIngredientes.FormattingEnabled = true;
            this.comboBoxIngredientes.Location = new System.Drawing.Point(135, 149);
            this.comboBoxIngredientes.Name = "comboBoxIngredientes";
            this.comboBoxIngredientes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIngredientes.TabIndex = 11;
            this.comboBoxIngredientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxIngredientes_SelectedIndexChanged);
            // 
            // buttonInsertarIngredientes
            // 
            this.buttonInsertarIngredientes.BackColor = System.Drawing.Color.Pink;
            this.buttonInsertarIngredientes.Location = new System.Drawing.Point(650, 277);
            this.buttonInsertarIngredientes.Name = "buttonInsertarIngredientes";
            this.buttonInsertarIngredientes.Size = new System.Drawing.Size(117, 52);
            this.buttonInsertarIngredientes.TabIndex = 3;
            this.buttonInsertarIngredientes.Text = "Insertar ingredientes";
            this.buttonInsertarIngredientes.UseVisualStyleBackColor = false;
            this.buttonInsertarIngredientes.Click += new System.EventHandler(this.buttonInsertarIngredientes_Click);
            // 
            // buttonEliminarIngredientes
            // 
            this.buttonEliminarIngredientes.BackColor = System.Drawing.Color.Pink;
            this.buttonEliminarIngredientes.Location = new System.Drawing.Point(650, 335);
            this.buttonEliminarIngredientes.Name = "buttonEliminarIngredientes";
            this.buttonEliminarIngredientes.Size = new System.Drawing.Size(117, 52);
            this.buttonEliminarIngredientes.TabIndex = 12;
            this.buttonEliminarIngredientes.Text = "Eliminar ingredientes";
            this.buttonEliminarIngredientes.UseVisualStyleBackColor = false;
            this.buttonEliminarIngredientes.Click += new System.EventHandler(this.buttonEliminarIngredientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seleccione el postre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingredientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Agregar nuevo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // InterfazPostres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEliminarIngredientes);
            this.Controls.Add(this.comboBoxIngredientes);
            this.Controls.Add(this.comboBoxPostres);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBajaPostre);
            this.Controls.Add(this.buttonAltaPostre);
            this.Controls.Add(this.buttonInsertarIngredientes);
            this.Controls.Add(this.buttonMostrarIngredientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InterfazPostres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMostrarIngredientes;
        private System.Windows.Forms.Button buttonAltaPostre;
        private System.Windows.Forms.Button buttonBajaPostre;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPostres;
        private System.Windows.Forms.ComboBox comboBoxIngredientes;
        private System.Windows.Forms.Button buttonInsertarIngredientes;
        private System.Windows.Forms.Button buttonEliminarIngredientes;
        private System.Windows.Forms.ListBox ListIngredientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

