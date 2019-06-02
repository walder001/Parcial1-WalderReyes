namespace Parcial1_WalderReyes.UI.Registro
{
    partial class rProductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExisencianumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.CostonumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.ProductoIdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.InventariotextBox4 = new System.Windows.Forms.TextBox();
            this.DescripciontextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExisencianumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ExisencianumericUpDown3
            // 
            this.ExisencianumericUpDown3.Location = new System.Drawing.Point(95, 211);
            this.ExisencianumericUpDown3.Name = "ExisencianumericUpDown3";
            this.ExisencianumericUpDown3.Size = new System.Drawing.Size(191, 20);
            this.ExisencianumericUpDown3.TabIndex = 48;
            this.ExisencianumericUpDown3.ValueChanged += new System.EventHandler(this.ExisencianumericUpDown3_ValueChanged_1);
            // 
            // CostonumericUpDown2
            // 
            this.CostonumericUpDown2.DecimalPlaces = 2;
            this.CostonumericUpDown2.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.CostonumericUpDown2.Location = new System.Drawing.Point(95, 159);
            this.CostonumericUpDown2.Name = "CostonumericUpDown2";
            this.CostonumericUpDown2.Size = new System.Drawing.Size(191, 20);
            this.CostonumericUpDown2.TabIndex = 47;
            this.CostonumericUpDown2.ValueChanged += new System.EventHandler(this.CostonumericUpDown2_ValueChanged_1);
            // 
            // ProductoIdnumericUpDown1
            // 
            this.ProductoIdnumericUpDown1.Location = new System.Drawing.Point(95, 68);
            this.ProductoIdnumericUpDown1.Name = "ProductoIdnumericUpDown1";
            this.ProductoIdnumericUpDown1.Size = new System.Drawing.Size(94, 20);
            this.ProductoIdnumericUpDown1.TabIndex = 46;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(223, 335);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(125, 41);
            this.Eliminar.TabIndex = 45;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click_1);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Red;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(55, 335);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(123, 41);
            this.Guardar.TabIndex = 44;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click_1);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(211, 66);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 43;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click_1);
            // 
            // InventariotextBox4
            // 
            this.InventariotextBox4.Location = new System.Drawing.Point(95, 257);
            this.InventariotextBox4.Name = "InventariotextBox4";
            this.InventariotextBox4.ReadOnly = true;
            this.InventariotextBox4.Size = new System.Drawing.Size(191, 20);
            this.InventariotextBox4.TabIndex = 42;
            // 
            // DescripciontextBox1
            // 
            this.DescripciontextBox1.Location = new System.Drawing.Point(95, 115);
            this.DescripciontextBox1.Name = "DescripciontextBox1";
            this.DescripciontextBox1.Size = new System.Drawing.Size(191, 20);
            this.DescripciontextBox1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "ProductoId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Registro Productos";
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 394);
            this.Controls.Add(this.ExisencianumericUpDown3);
            this.Controls.Add(this.CostonumericUpDown2);
            this.Controls.Add(this.ProductoIdnumericUpDown1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.InventariotextBox4);
            this.Controls.Add(this.DescripciontextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "rProductos";
            this.Text = "rProductos";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExisencianumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.NumericUpDown ExisencianumericUpDown3;
        private System.Windows.Forms.NumericUpDown CostonumericUpDown2;
        private System.Windows.Forms.NumericUpDown ProductoIdnumericUpDown1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox InventariotextBox4;
        private System.Windows.Forms.TextBox DescripciontextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}