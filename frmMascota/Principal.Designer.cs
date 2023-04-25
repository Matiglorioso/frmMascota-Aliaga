namespace frmMascota
{
    partial class Principal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.lstConsulta = new System.Windows.Forms.ListBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.cmbTipoAnimal2 = new System.Windows.Forms.ComboBox();
            this.lblTipoAnimal2 = new System.Windows.Forms.Label();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnCuidar = new System.Windows.Forms.Button();
            this.lblAlimentar = new System.Windows.Forms.Label();
            this.lblJugar = new System.Windows.Forms.Label();
            this.lblCuidar = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.mrcInteractua = new System.Windows.Forms.GroupBox();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.mrcInteractua.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(361, 108);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(361, 79);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "C&onsultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(361, 50);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "&Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbTipoAnimal
            // 
            this.cmbTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAnimal.FormattingEnabled = true;
            this.cmbTipoAnimal.Location = new System.Drawing.Point(90, 77);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAnimal.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(77, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de Animal";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(51, 122);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 34);
            this.txtNombre.MaxLength = 12;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(90, 119);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.lblName);
            this.mrcRegistro.Controls.Add(this.txtEdad);
            this.mrcRegistro.Controls.Add(this.cmbTipoAnimal);
            this.mrcRegistro.Controls.Add(this.txtNombre);
            this.mrcRegistro.Controls.Add(this.lblTipo);
            this.mrcRegistro.Controls.Add(this.lblEdad);
            this.mrcRegistro.Location = new System.Drawing.Point(12, 23);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(298, 164);
            this.mrcRegistro.TabIndex = 9;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registrá a tu mascota:";
            // 
            // lstConsulta
            // 
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.Location = new System.Drawing.Point(489, 36);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(272, 147);
            this.lstConsulta.TabIndex = 10;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbFoto.Location = new System.Drawing.Point(239, 32);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(248, 184);
            this.pcbFoto.TabIndex = 11;
            this.pcbFoto.TabStop = false;
            // 
            // cmbTipoAnimal2
            // 
            this.cmbTipoAnimal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAnimal2.FormattingEnabled = true;
            this.cmbTipoAnimal2.Location = new System.Drawing.Point(32, 48);
            this.cmbTipoAnimal2.Name = "cmbTipoAnimal2";
            this.cmbTipoAnimal2.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAnimal2.TabIndex = 12;
            // 
            // lblTipoAnimal2
            // 
            this.lblTipoAnimal2.AutoSize = true;
            this.lblTipoAnimal2.Location = new System.Drawing.Point(29, 32);
            this.lblTipoAnimal2.Name = "lblTipoAnimal2";
            this.lblTipoAnimal2.Size = new System.Drawing.Size(77, 13);
            this.lblTipoAnimal2.TabIndex = 9;
            this.lblTipoAnimal2.Text = "Tipo de Animal";
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(40, 94);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(75, 23);
            this.btnAlimentar.TabIndex = 13;
            this.btnAlimentar.Text = "&Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(40, 134);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 14;
            this.btnJugar.Text = "&Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnCuidar
            // 
            this.btnCuidar.Location = new System.Drawing.Point(40, 174);
            this.btnCuidar.Name = "btnCuidar";
            this.btnCuidar.Size = new System.Drawing.Size(75, 23);
            this.btnCuidar.TabIndex = 15;
            this.btnCuidar.Text = "C&uidar";
            this.btnCuidar.UseVisualStyleBackColor = true;
            this.btnCuidar.Click += new System.EventHandler(this.btnCuidar_Click);
            // 
            // lblAlimentar
            // 
            this.lblAlimentar.AutoSize = true;
            this.lblAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentar.Location = new System.Drawing.Point(149, 94);
            this.lblAlimentar.Name = "lblAlimentar";
            this.lblAlimentar.Size = new System.Drawing.Size(19, 20);
            this.lblAlimentar.TabIndex = 16;
            this.lblAlimentar.Text = "0";
            // 
            // lblJugar
            // 
            this.lblJugar.AutoSize = true;
            this.lblJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugar.Location = new System.Drawing.Point(149, 134);
            this.lblJugar.Name = "lblJugar";
            this.lblJugar.Size = new System.Drawing.Size(19, 20);
            this.lblJugar.TabIndex = 17;
            this.lblJugar.Text = "0";
            // 
            // lblCuidar
            // 
            this.lblCuidar.AutoSize = true;
            this.lblCuidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuidar.Location = new System.Drawing.Point(149, 174);
            this.lblCuidar.Name = "lblCuidar";
            this.lblCuidar.Size = new System.Drawing.Size(19, 20);
            this.lblCuidar.TabIndex = 18;
            this.lblCuidar.Text = "0";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(554, 334);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // mrcInteractua
            // 
            this.mrcInteractua.Controls.Add(this.lblTipoAnimal2);
            this.mrcInteractua.Controls.Add(this.pcbFoto);
            this.mrcInteractua.Controls.Add(this.lblCuidar);
            this.mrcInteractua.Controls.Add(this.cmbTipoAnimal2);
            this.mrcInteractua.Controls.Add(this.lblJugar);
            this.mrcInteractua.Controls.Add(this.btnAlimentar);
            this.mrcInteractua.Controls.Add(this.lblAlimentar);
            this.mrcInteractua.Controls.Add(this.btnJugar);
            this.mrcInteractua.Controls.Add(this.btnCuidar);
            this.mrcInteractua.Location = new System.Drawing.Point(12, 212);
            this.mrcInteractua.Name = "mrcInteractua";
            this.mrcInteractua.Size = new System.Drawing.Size(513, 226);
            this.mrcInteractua.TabIndex = 20;
            this.mrcInteractua.TabStop = false;
            this.mrcInteractua.Text = "¡Interactúa con tu mascota!";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mrcInteractua);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstConsulta);
            this.Controls.Add(this.mrcRegistro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Name = "Principal";
            this.Text = "Regitro de mascotas - Veterinaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.mrcInteractua.ResumeLayout(false);
            this.mrcInteractua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbTipoAnimal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.ListBox lstConsulta;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.ComboBox cmbTipoAnimal2;
        private System.Windows.Forms.Label lblTipoAnimal2;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnCuidar;
        private System.Windows.Forms.Label lblAlimentar;
        private System.Windows.Forms.Label lblJugar;
        private System.Windows.Forms.Label lblCuidar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox mrcInteractua;
    }
}

