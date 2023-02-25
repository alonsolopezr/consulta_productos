namespace WinFormProductoPDV
{
    partial class FrmUsuarios
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
            this.panelPpal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPicBoxSave = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxDelete = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxEdit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxNuevo = new FontAwesome.Sharp.IconPictureBox();
            this.lblConfirmaContra = new System.Windows.Forms.Label();
            this.txtConfirmaContra = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.iconPicBoxBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPpal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPpal
            // 
            this.panelPpal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPpal.Controls.Add(this.panel2);
            this.panelPpal.Controls.Add(this.panel1);
            this.panelPpal.Location = new System.Drawing.Point(12, 12);
            this.panelPpal.Name = "panelPpal";
            this.panelPpal.Size = new System.Drawing.Size(1142, 638);
            this.panelPpal.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGridUsuarios);
            this.panel2.Location = new System.Drawing.Point(15, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 212);
            this.panel2.TabIndex = 1;
            // 
            // dGridUsuarios
            // 
            this.dGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Correo,
            this.Column3,
            this.Column6});
            this.dGridUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dGridUsuarios.Name = "dGridUsuarios";
            this.dGridUsuarios.RowTemplate.Height = 25;
            this.dGridUsuarios.Size = new System.Drawing.Size(1098, 426);
            this.dGridUsuarios.TabIndex = 0;
            this.dGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridUsuarios_CellClick);
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
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IMagen";
            this.Column6.Name = "Column6";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconPicBoxSave);
            this.panel1.Controls.Add(this.iconPicBoxDelete);
            this.panel1.Controls.Add(this.iconPicBoxEdit);
            this.panel1.Controls.Add(this.iconPicBoxNuevo);
            this.panel1.Controls.Add(this.lblConfirmaContra);
            this.panel1.Controls.Add(this.txtConfirmaContra);
            this.panel1.Controls.Add(this.lblCodBarras);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblFoto);
            this.panel1.Controls.Add(this.txtImagen);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.iconPicBoxBuscar);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 380);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.iconPicBoxDelete.Click += new System.EventHandler(this.iconPicBoxDelete_Click);
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
            // lblConfirmaContra
            // 
            this.lblConfirmaContra.AutoSize = true;
            this.lblConfirmaContra.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmaContra.Location = new System.Drawing.Point(569, 235);
            this.lblConfirmaContra.Name = "lblConfirmaContra";
            this.lblConfirmaContra.Size = new System.Drawing.Size(223, 27);
            this.lblConfirmaContra.TabIndex = 12;
            this.lblConfirmaContra.Text = "Confirma Contra:";
            // 
            // txtConfirmaContra
            // 
            this.txtConfirmaContra.Enabled = false;
            this.txtConfirmaContra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmaContra.Location = new System.Drawing.Point(798, 228);
            this.txtConfirmaContra.Name = "txtConfirmaContra";
            this.txtConfirmaContra.PasswordChar = '*';
            this.txtConfirmaContra.Size = new System.Drawing.Size(258, 39);
            this.txtConfirmaContra.TabIndex = 11;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodBarras.Location = new System.Drawing.Point(22, 235);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(159, 27);
            this.lblCodBarras.TabIndex = 10;
            this.lblCodBarras.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(270, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '?';
            this.txtPassword.Size = new System.Drawing.Size(280, 39);
            this.txtPassword.TabIndex = 9;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoto.Location = new System.Drawing.Point(21, 280);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(78, 27);
            this.lblFoto.TabIndex = 8;
            this.lblFoto.Text = "Foto:";
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
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.Location = new System.Drawing.Point(22, 192);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(108, 27);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(270, 181);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(787, 39);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(21, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 27);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
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
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario a Buscar";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 661);
            this.Controls.Add(this.panelPpal);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panelPpal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsuarios)).EndInit();
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

        private Panel panelPpal;
        private Panel panel2;
        private DataGridView dGridUsuarios;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSave;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxDelete;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxEdit;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxNuevo;
        private Label lblConfirmaContra;
        private TextBox txtConfirmaContra;
        private Label lblCodBarras;
        private TextBox txtPassword;
        private Label lblFoto;
        private TextBox txtImagen;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblNombre;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxBuscar;
        private TextBox txtBuscador;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
    }
}