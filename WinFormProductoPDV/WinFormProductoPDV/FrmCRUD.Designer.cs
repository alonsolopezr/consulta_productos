namespace WinFormProductoPDV
{
    partial class FrmCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUD));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPpal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPicBoxSave = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxDelete = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxEdit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxNuevo = new FontAwesome.Sharp.IconPictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.iconPicBoxBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPpal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panelPpal
            // 
            this.panelPpal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPpal.Controls.Add(this.panel2);
            this.panelPpal.Controls.Add(this.panel1);
            this.panelPpal.Location = new System.Drawing.Point(12, 12);
            this.panelPpal.Name = "panelPpal";
            this.panelPpal.Size = new System.Drawing.Size(1142, 638);
            this.panelPpal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGridProductos);
            this.panel2.Location = new System.Drawing.Point(15, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 212);
            this.panel2.TabIndex = 1;
            // 
            // dGridProductos
            // 
            this.dGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dGridProductos.Location = new System.Drawing.Point(3, 3);
            this.dGridProductos.Name = "dGridProductos";
            this.dGridProductos.RowTemplate.Height = 25;
            this.dGridProductos.Size = new System.Drawing.Size(1098, 426);
            this.dGridProductos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconPicBoxSave);
            this.panel1.Controls.Add(this.iconPicBoxDelete);
            this.panel1.Controls.Add(this.iconPicBoxEdit);
            this.panel1.Controls.Add(this.iconPicBoxNuevo);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.lblCodBarras);
            this.panel1.Controls.Add(this.txtCodBarras);
            this.panel1.Controls.Add(this.lblImagen);
            this.panel1.Controls.Add(this.txtImagen);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.iconPicBoxBuscar);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 380);
            this.panel1.TabIndex = 0;
            // 
            // iconPicBoxSave
            // 
            this.iconPicBoxSave.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicBoxSave.ForeColor = System.Drawing.Color.Blue;
            this.iconPicBoxSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconPicBoxSave.IconColor = System.Drawing.Color.Blue;
            this.iconPicBoxSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxSave.IconSize = 39;
            this.iconPicBoxSave.Location = new System.Drawing.Point(938, 334);
            this.iconPicBoxSave.Name = "iconPicBoxSave";
            this.iconPicBoxSave.Size = new System.Drawing.Size(39, 39);
            this.iconPicBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicBoxSave.TabIndex = 16;
            this.iconPicBoxSave.TabStop = false;
            this.iconPicBoxSave.Click += new System.EventHandler(this.iconPicBoxSave_Click);
            // 
            // iconPicBoxDelete
            // 
            this.iconPicBoxDelete.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicBoxDelete.ForeColor = System.Drawing.Color.Red;
            this.iconPicBoxDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconPicBoxDelete.IconColor = System.Drawing.Color.Red;
            this.iconPicBoxDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxDelete.IconSize = 39;
            this.iconPicBoxDelete.Location = new System.Drawing.Point(1017, 334);
            this.iconPicBoxDelete.Name = "iconPicBoxDelete";
            this.iconPicBoxDelete.Size = new System.Drawing.Size(39, 39);
            this.iconPicBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicBoxDelete.TabIndex = 15;
            this.iconPicBoxDelete.TabStop = false;
            // 
            // iconPicBoxEdit
            // 
            this.iconPicBoxEdit.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicBoxEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconPicBoxEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconPicBoxEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconPicBoxEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxEdit.IconSize = 39;
            this.iconPicBoxEdit.Location = new System.Drawing.Point(865, 334);
            this.iconPicBoxEdit.Name = "iconPicBoxEdit";
            this.iconPicBoxEdit.Size = new System.Drawing.Size(39, 39);
            this.iconPicBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicBoxEdit.TabIndex = 14;
            this.iconPicBoxEdit.TabStop = false;
            // 
            // iconPicBoxNuevo
            // 
            this.iconPicBoxNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicBoxNuevo.ForeColor = System.Drawing.Color.SeaGreen;
            this.iconPicBoxNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPicBoxNuevo.IconColor = System.Drawing.Color.SeaGreen;
            this.iconPicBoxNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxNuevo.IconSize = 39;
            this.iconPicBoxNuevo.Location = new System.Drawing.Point(780, 334);
            this.iconPicBoxNuevo.Name = "iconPicBoxNuevo";
            this.iconPicBoxNuevo.Size = new System.Drawing.Size(39, 39);
            this.iconPicBoxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicBoxNuevo.TabIndex = 13;
            this.iconPicBoxNuevo.TabStop = false;
            this.iconPicBoxNuevo.Click += new System.EventHandler(this.iconPicBoxNuevo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(692, 235);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 27);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(798, 228);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(258, 39);
            this.txtPrecio.TabIndex = 11;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodBarras.Location = new System.Drawing.Point(22, 235);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(228, 27);
            this.lblCodBarras.TabIndex = 10;
            this.lblCodBarras.Text = "Código de Barras:";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Enabled = false;
            this.txtCodBarras.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodBarras.Location = new System.Drawing.Point(270, 227);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(398, 39);
            this.txtCodBarras.TabIndex = 9;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImagen.Location = new System.Drawing.Point(21, 280);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(104, 27);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "Imagen:";
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImagen.Location = new System.Drawing.Point(269, 273);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(787, 39);
            this.txtImagen.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(22, 192);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(163, 27);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(270, 181);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(787, 39);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(21, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 27);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(269, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(787, 39);
            this.txtNombre.TabIndex = 3;
            // 
            // iconPicBoxBuscar
            // 
            this.iconPicBoxBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicBoxBuscar.ForeColor = System.Drawing.Color.Blue;
            this.iconPicBoxBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconPicBoxBuscar.IconColor = System.Drawing.Color.Blue;
            this.iconPicBoxBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxBuscar.IconSize = 39;
            this.iconPicBoxBuscar.Location = new System.Drawing.Point(1062, 51);
            this.iconPicBoxBuscar.Name = "iconPicBoxBuscar";
            this.iconPicBoxBuscar.Size = new System.Drawing.Size(39, 39);
            this.iconPicBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicBoxBuscar.TabIndex = 2;
            this.iconPicBoxBuscar.TabStop = false;
            this.iconPicBoxBuscar.Click += new System.EventHandler(this.iconPicBoxBuscar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscador.Location = new System.Drawing.Point(21, 51);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(1035, 39);
            this.txtBuscador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto a Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Código Barras";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Desc";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IMagen";
            this.Column6.Name = "Column6";
            // 
            // FrmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 662);
            this.Controls.Add(this.panelPpal);
            this.Name = "FrmCRUD";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCRUD_Load);
            this.panelPpal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Panel panelPpal;
        private Panel panel2;
        private DataGridView dGridProductos;
        private Panel panel1;
        private TextBox txtBuscador;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxBuscar;
        private TextBox txtNombre;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCodBarras;
        private TextBox txtCodBarras;
        private Label lblImagen;
        private TextBox txtImagen;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSave;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxDelete;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxEdit;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxNuevo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}