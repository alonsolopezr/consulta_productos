namespace WinFormProductoPDV
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPpal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPicBoxBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPpal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(15, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 436);
            this.panel2.TabIndex = 1;
            // 
            // dGridProductos
            // 
            this.dGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
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
            this.panel1.Controls.Add(this.iconPicBoxBuscar);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 156);
            this.panel1.TabIndex = 0;
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
            this.iconPicBoxBuscar.Location = new System.Drawing.Point(1062, 68);
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
            this.txtBuscador.Location = new System.Drawing.Point(21, 68);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(1035, 39);
            this.txtBuscador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 28);
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
            // Column3
            // 
            this.Column3.HeaderText = "Desc";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Código Barras";
            this.Column4.Name = "Column4";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 662);
            this.Controls.Add(this.panelPpal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPpal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}