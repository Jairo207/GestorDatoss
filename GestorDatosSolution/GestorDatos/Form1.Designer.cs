namespace GestorDatos
{
    partial class Form1
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegNombre = new System.Windows.Forms.Label();
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.lblRegEdad = new System.Windows.Forms.Label();
            this.txtRegEdad = new System.Windows.Forms.TextBox();
            this.lblRegNota1 = new System.Windows.Forms.Label();
            this.lblRegNota2 = new System.Windows.Forms.Label();
            this.lblRegNota3 = new System.Windows.Forms.Label();
            this.txtRegNota1 = new System.Windows.Forms.TextBox();
            this.txtRegNota2 = new System.Windows.Forms.TextBox();
            this.txtRegNota3 = new System.Windows.Forms.TextBox();
            this.rbRegMasculino = new System.Windows.Forms.RadioButton();
            this.rbRegFemenino = new System.Windows.Forms.RadioButton();
            this.chkRegDeportes = new System.Windows.Forms.CheckBox();
            this.chkRegMusica = new System.Windows.Forms.CheckBox();
            this.chkRegArte = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbEstado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(9, 39);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(593, 158);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(23, 10);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar CSV";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(143, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar CSV";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar CSV";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(421, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 221);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(62, 247);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(62, 278);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(59, 316);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(10, 13);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "-";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(59, 351);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(10, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "-";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(215, 221);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(111, 23);
            this.btnAdjuntar.TabIndex = 10;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Text = "Seleccionar Adjunto";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(215, 250);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(111, 24);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar Correo";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(205, 297);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(407, 95);
            this.lstLog.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Promedio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbEstado);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.chkRegArte);
            this.groupBox1.Controls.Add(this.chkRegMusica);
            this.groupBox1.Controls.Add(this.chkRegDeportes);
            this.groupBox1.Controls.Add(this.rbRegFemenino);
            this.groupBox1.Controls.Add(this.rbRegMasculino);
            this.groupBox1.Controls.Add(this.txtRegNota3);
            this.groupBox1.Controls.Add(this.txtRegNota2);
            this.groupBox1.Controls.Add(this.txtRegNota1);
            this.groupBox1.Controls.Add(this.lblRegNota3);
            this.groupBox1.Controls.Add(this.lblRegNota2);
            this.groupBox1.Controls.Add(this.lblRegNota1);
            this.groupBox1.Controls.Add(this.txtRegEdad);
            this.groupBox1.Controls.Add(this.lblRegEdad);
            this.groupBox1.Controls.Add(this.txtRegNombre);
            this.groupBox1.Controls.Add(this.lblRegNombre);
            this.groupBox1.Location = new System.Drawing.Point(643, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 353);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Estudiantes";
            // 
            // lblRegNombre
            // 
            this.lblRegNombre.AutoSize = true;
            this.lblRegNombre.Location = new System.Drawing.Point(7, 23);
            this.lblRegNombre.Name = "lblRegNombre";
            this.lblRegNombre.Size = new System.Drawing.Size(47, 13);
            this.lblRegNombre.TabIndex = 0;
            this.lblRegNombre.Text = "Nombre:";
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.Location = new System.Drawing.Point(60, 16);
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(100, 20);
            this.txtRegNombre.TabIndex = 1;
            // 
            // lblRegEdad
            // 
            this.lblRegEdad.AutoSize = true;
            this.lblRegEdad.Location = new System.Drawing.Point(12, 47);
            this.lblRegEdad.Name = "lblRegEdad";
            this.lblRegEdad.Size = new System.Drawing.Size(35, 13);
            this.lblRegEdad.TabIndex = 2;
            this.lblRegEdad.Text = "Edad:";
            // 
            // txtRegEdad
            // 
            this.txtRegEdad.Location = new System.Drawing.Point(60, 44);
            this.txtRegEdad.Name = "txtRegEdad";
            this.txtRegEdad.Size = new System.Drawing.Size(100, 20);
            this.txtRegEdad.TabIndex = 3;
            // 
            // lblRegNota1
            // 
            this.lblRegNota1.AutoSize = true;
            this.lblRegNota1.Location = new System.Drawing.Point(12, 73);
            this.lblRegNota1.Name = "lblRegNota1";
            this.lblRegNota1.Size = new System.Drawing.Size(42, 13);
            this.lblRegNota1.TabIndex = 4;
            this.lblRegNota1.Text = "Nota 1:";
            // 
            // lblRegNota2
            // 
            this.lblRegNota2.AutoSize = true;
            this.lblRegNota2.Location = new System.Drawing.Point(12, 99);
            this.lblRegNota2.Name = "lblRegNota2";
            this.lblRegNota2.Size = new System.Drawing.Size(42, 13);
            this.lblRegNota2.TabIndex = 5;
            this.lblRegNota2.Text = "Nota 2:";
            // 
            // lblRegNota3
            // 
            this.lblRegNota3.AutoSize = true;
            this.lblRegNota3.Location = new System.Drawing.Point(12, 125);
            this.lblRegNota3.Name = "lblRegNota3";
            this.lblRegNota3.Size = new System.Drawing.Size(42, 13);
            this.lblRegNota3.TabIndex = 6;
            this.lblRegNota3.Text = "Nota 3:";
            // 
            // txtRegNota1
            // 
            this.txtRegNota1.Location = new System.Drawing.Point(60, 70);
            this.txtRegNota1.Name = "txtRegNota1";
            this.txtRegNota1.Size = new System.Drawing.Size(100, 20);
            this.txtRegNota1.TabIndex = 7;
            // 
            // txtRegNota2
            // 
            this.txtRegNota2.Location = new System.Drawing.Point(60, 96);
            this.txtRegNota2.Name = "txtRegNota2";
            this.txtRegNota2.Size = new System.Drawing.Size(100, 20);
            this.txtRegNota2.TabIndex = 8;
            // 
            // txtRegNota3
            // 
            this.txtRegNota3.Location = new System.Drawing.Point(60, 122);
            this.txtRegNota3.Name = "txtRegNota3";
            this.txtRegNota3.Size = new System.Drawing.Size(100, 20);
            this.txtRegNota3.TabIndex = 9;
            // 
            // rbRegMasculino
            // 
            this.rbRegMasculino.AutoSize = true;
            this.rbRegMasculino.Location = new System.Drawing.Point(6, 157);
            this.rbRegMasculino.Name = "rbRegMasculino";
            this.rbRegMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbRegMasculino.TabIndex = 10;
            this.rbRegMasculino.TabStop = true;
            this.rbRegMasculino.Text = "Masculino";
            this.rbRegMasculino.UseVisualStyleBackColor = true;
            // 
            // rbRegFemenino
            // 
            this.rbRegFemenino.AutoSize = true;
            this.rbRegFemenino.Location = new System.Drawing.Point(97, 157);
            this.rbRegFemenino.Name = "rbRegFemenino";
            this.rbRegFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbRegFemenino.TabIndex = 11;
            this.rbRegFemenino.TabStop = true;
            this.rbRegFemenino.Text = "Femenino";
            this.rbRegFemenino.UseVisualStyleBackColor = true;
            // 
            // chkRegDeportes
            // 
            this.chkRegDeportes.AutoSize = true;
            this.chkRegDeportes.Location = new System.Drawing.Point(6, 188);
            this.chkRegDeportes.Name = "chkRegDeportes";
            this.chkRegDeportes.Size = new System.Drawing.Size(69, 17);
            this.chkRegDeportes.TabIndex = 12;
            this.chkRegDeportes.Text = "Deportes";
            this.chkRegDeportes.UseVisualStyleBackColor = true;
            // 
            // chkRegMusica
            // 
            this.chkRegMusica.AutoSize = true;
            this.chkRegMusica.Location = new System.Drawing.Point(82, 187);
            this.chkRegMusica.Name = "chkRegMusica";
            this.chkRegMusica.Size = new System.Drawing.Size(60, 17);
            this.chkRegMusica.TabIndex = 13;
            this.chkRegMusica.Text = "Musica";
            this.chkRegMusica.UseVisualStyleBackColor = true;
            // 
            // chkRegArte
            // 
            this.chkRegArte.AutoSize = true;
            this.chkRegArte.Location = new System.Drawing.Point(148, 188);
            this.chkRegArte.Name = "chkRegArte";
            this.chkRegArte.Size = new System.Drawing.Size(45, 17);
            this.chkRegArte.TabIndex = 14;
            this.chkRegArte.Text = "Arte";
            this.chkRegArte.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(67, 232);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pbEstado
            // 
            this.pbEstado.Location = new System.Drawing.Point(60, 286);
            this.pbEstado.Name = "pbEstado";
            this.pbEstado.Size = new System.Drawing.Size(100, 50);
            this.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstado.TabIndex = 20;
            this.pbEstado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRegNombre;
        private System.Windows.Forms.Label lblRegNota1;
        private System.Windows.Forms.TextBox txtRegEdad;
        private System.Windows.Forms.Label lblRegEdad;
        private System.Windows.Forms.TextBox txtRegNombre;
        private System.Windows.Forms.CheckBox chkRegMusica;
        private System.Windows.Forms.CheckBox chkRegDeportes;
        private System.Windows.Forms.RadioButton rbRegFemenino;
        private System.Windows.Forms.RadioButton rbRegMasculino;
        private System.Windows.Forms.TextBox txtRegNota3;
        private System.Windows.Forms.TextBox txtRegNota2;
        private System.Windows.Forms.TextBox txtRegNota1;
        private System.Windows.Forms.Label lblRegNota3;
        private System.Windows.Forms.Label lblRegNota2;
        private System.Windows.Forms.CheckBox chkRegArte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pbEstado;
    }
}

