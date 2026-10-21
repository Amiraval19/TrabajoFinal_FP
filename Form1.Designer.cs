namespace TrabajoFinal_FP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvExpedientes = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboTramite = new System.Windows.Forms.ComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa de Partes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de expediente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del ciudadano :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lista de trámites:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Área asignada :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lista de expedientes :";
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.AllowUserToAddRows = false;
            this.dgvExpedientes.AllowUserToDeleteRows = false;
            this.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpedientes.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Location = new System.Drawing.Point(9, 256);
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.Size = new System.Drawing.Size(526, 182);
            this.dgvExpedientes.TabIndex = 7;
            this.dgvExpedientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpedientes_CellContentClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtCodigo.Location = new System.Drawing.Point(168, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDNI.Location = new System.Drawing.Point(378, 37);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(154, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombre.Location = new System.Drawing.Point(165, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(367, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // cboTramite
            // 
            this.cboTramite.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cboTramite.FormattingEnabled = true;
            this.cboTramite.Location = new System.Drawing.Point(125, 105);
            this.cboTramite.Name = "cboTramite";
            this.cboTramite.Size = new System.Drawing.Size(146, 21);
            this.cboTramite.TabIndex = 11;
            this.cboTramite.SelectedIndexChanged += new System.EventHandler(this.cboTramite_SelectedIndexChanged);
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtArea.Location = new System.Drawing.Point(380, 106);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(152, 20);
            this.txtArea.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistrar.Location = new System.Drawing.Point(9, 171);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 43);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscar.Location = new System.Drawing.Point(134, 171);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 43);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrdenar.Location = new System.Drawing.Point(267, 171);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(130, 43);
            this.btnOrdenar.TabIndex = 15;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(402, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 43);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha de registro :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(134, 140);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(136, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.cboTramite);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvExpedientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mesa de Partes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvExpedientes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboTramite;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}

