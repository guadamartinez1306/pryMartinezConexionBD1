namespace pryMartinezConexionBD1
{
    partial class frmModificarConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarConsultar));
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnModificarCodigo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioCod = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPrecioCod = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtDescripcionNom = new System.Windows.Forms.MaskedTextBox();
            this.txtDescripcionCod = new System.Windows.Forms.MaskedTextBox();
            this.lblDescripcionCod = new System.Windows.Forms.Label();
            this.lblDescripcionNom = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightSalmon;
            this.btnVolver.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 31);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblDescripcionNom);
            this.groupBox2.Controls.Add(this.txtDescripcionNom);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblPrecio);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(590, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 253);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Producto por Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 30);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNombre_MaskInputRejected);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(200, 104);
            this.txtPrecio.Mask = "999999999";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 30);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPrecio_MaskInputRejected);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(24, 107);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 23);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "$";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificar.Location = new System.Drawing.Point(200, 200);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(189, 37);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgvProductos);
            this.groupBox3.Controls.Add(this.btnListar);
            this.groupBox3.Location = new System.Drawing.Point(34, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 530);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar Productos";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnListar.Location = new System.Drawing.Point(276, 477);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(189, 37);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(48, 55);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(417, 322);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 604);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión Productos";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.lblDescripcionCod);
            this.groupBox4.Controls.Add(this.txtDescripcionCod);
            this.groupBox4.Controls.Add(this.btnModificarCodigo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblPrecioCod);
            this.groupBox4.Controls.Add(this.lblCodigo);
            this.groupBox4.Controls.Add(this.txtPrecioCod);
            this.groupBox4.Controls.Add(this.txtCodigo);
            this.groupBox4.Location = new System.Drawing.Point(590, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 253);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modificar Producto por Código";
            // 
            // btnModificarCodigo
            // 
            this.btnModificarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCodigo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificarCodigo.Location = new System.Drawing.Point(200, 200);
            this.btnModificarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarCodigo.Name = "btnModificarCodigo";
            this.btnModificarCodigo.Size = new System.Drawing.Size(189, 37);
            this.btnModificarCodigo.TabIndex = 13;
            this.btnModificarCodigo.Text = "MODIFICAR";
            this.btnModificarCodigo.UseVisualStyleBackColor = false;
            this.btnModificarCodigo.Click += new System.EventHandler(this.btnModificarCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "$";
            // 
            // lblPrecioCod
            // 
            this.lblPrecioCod.AutoSize = true;
            this.lblPrecioCod.Location = new System.Drawing.Point(24, 107);
            this.lblPrecioCod.Name = "lblPrecioCod";
            this.lblPrecioCod.Size = new System.Drawing.Size(61, 23);
            this.lblPrecioCod.TabIndex = 10;
            this.lblPrecioCod.Text = "Precio:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 23);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // txtPrecioCod
            // 
            this.txtPrecioCod.Location = new System.Drawing.Point(200, 104);
            this.txtPrecioCod.Mask = "999999999";
            this.txtPrecioCod.Name = "txtPrecioCod";
            this.txtPrecioCod.Size = new System.Drawing.Size(100, 30);
            this.txtPrecioCod.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(200, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 30);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcionNom
            // 
            this.txtDescripcionNom.Location = new System.Drawing.Point(200, 152);
            this.txtDescripcionNom.Name = "txtDescripcionNom";
            this.txtDescripcionNom.Size = new System.Drawing.Size(189, 30);
            this.txtDescripcionNom.TabIndex = 14;
            // 
            // txtDescripcionCod
            // 
            this.txtDescripcionCod.Location = new System.Drawing.Point(200, 152);
            this.txtDescripcionCod.Name = "txtDescripcionCod";
            this.txtDescripcionCod.Size = new System.Drawing.Size(189, 30);
            this.txtDescripcionCod.TabIndex = 14;
            // 
            // lblDescripcionCod
            // 
            this.lblDescripcionCod.AutoSize = true;
            this.lblDescripcionCod.Location = new System.Drawing.Point(24, 155);
            this.lblDescripcionCod.Name = "lblDescripcionCod";
            this.lblDescripcionCod.Size = new System.Drawing.Size(102, 23);
            this.lblDescripcionCod.TabIndex = 15;
            this.lblDescripcionCod.Text = "Descripción:";
            // 
            // lblDescripcionNom
            // 
            this.lblDescripcionNom.AutoSize = true;
            this.lblDescripcionNom.Location = new System.Drawing.Point(24, 155);
            this.lblDescripcionNom.Name = "lblDescripcionNom";
            this.lblDescripcionNom.Size = new System.Drawing.Size(102, 23);
            this.lblDescripcionNom.TabIndex = 16;
            this.lblDescripcionNom.Text = "Descripción:";
            // 
            // frmModificarConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryMartinezConexionBD1.Properties.Resources.background_compressed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 715);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarConsultar";
            this.Text = "Consultar y Modificar Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnModificarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioCod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox txtPrecioCod;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtDescripcionNom;
        private System.Windows.Forms.Label lblDescripcionCod;
        private System.Windows.Forms.MaskedTextBox txtDescripcionCod;
        private System.Windows.Forms.Label lblDescripcionNom;
    }
}