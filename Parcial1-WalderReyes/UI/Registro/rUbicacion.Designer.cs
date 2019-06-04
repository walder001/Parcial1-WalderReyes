namespace Parcial1_WalderReyes.UI.Registro
{
    partial class rUbicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox1 = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // IdnumericUpDown1
            // 
            this.IdnumericUpDown1.Location = new System.Drawing.Point(101, 14);
            this.IdnumericUpDown1.Name = "IdnumericUpDown1";
            this.IdnumericUpDown1.Size = new System.Drawing.Size(128, 20);
            this.IdnumericUpDown1.TabIndex = 2;
            // 
            // DescripciontextBox1
            // 
            this.DescripciontextBox1.Location = new System.Drawing.Point(101, 63);
            this.DescripciontextBox1.Name = "DescripciontextBox1";
            this.DescripciontextBox1.Size = new System.Drawing.Size(227, 20);
            this.DescripciontextBox1.TabIndex = 3;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(248, 14);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(24, 107);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 5;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(141, 107);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(248, 107);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // rUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 161);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.DescripciontextBox1);
            this.Controls.Add(this.IdnumericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rUbicacion";
            this.Text = "rUbicacion";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown1;
        private System.Windows.Forms.TextBox DescripciontextBox1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}