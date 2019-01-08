namespace jorgeantonio
{
    partial class FormaReporte
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
            this.components = new System.ComponentModel.Container();
            this.FolioText = new System.Windows.Forms.TextBox();
            this.LoteText = new System.Windows.Forms.TextBox();
            this.OperadorText = new System.Windows.Forms.TextBox();
            this.TiempoText = new System.Windows.Forms.TextBox();
            this.DensidadText = new System.Windows.Forms.TextBox();
            this.ResiduoText = new System.Windows.Forms.TextBox();
            this.ViscosidadText = new System.Windows.Forms.TextBox();
            this.CtdAguaText = new System.Windows.Forms.TextBox();
            this.TurnoCombo = new System.Windows.Forms.ComboBox();
            this.EsmalteCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MolinoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridBaseDatos = new System.Windows.Forms.DataGridView();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.ModificarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.ClaveText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // FolioText
            // 
            this.FolioText.Location = new System.Drawing.Point(47, 60);
            this.FolioText.MaxLength = 8;
            this.FolioText.Name = "FolioText";
            this.FolioText.Size = new System.Drawing.Size(100, 20);
            this.FolioText.TabIndex = 0;
            this.FolioText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FolioText_KeyPress);
            // 
            // LoteText
            // 
            this.LoteText.Location = new System.Drawing.Point(643, 60);
            this.LoteText.MaxLength = 8;
            this.LoteText.Name = "LoteText";
            this.LoteText.Size = new System.Drawing.Size(145, 20);
            this.LoteText.TabIndex = 2;
            this.LoteText.TextChanged += new System.EventHandler(this.LoteText_TextChanged);
            this.LoteText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoteText_KeyPress);
            // 
            // OperadorText
            // 
            this.OperadorText.Location = new System.Drawing.Point(67, 123);
            this.OperadorText.Name = "OperadorText";
            this.OperadorText.Size = new System.Drawing.Size(303, 20);
            this.OperadorText.TabIndex = 6;
            this.OperadorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OperadorText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OperadorText_KeyPress);
            // 
            // TiempoText
            // 
            this.TiempoText.Location = new System.Drawing.Point(529, 124);
            this.TiempoText.Name = "TiempoText";
            this.TiempoText.Size = new System.Drawing.Size(61, 20);
            this.TiempoText.TabIndex = 5;
            // 
            // DensidadText
            // 
            this.DensidadText.Location = new System.Drawing.Point(654, 124);
            this.DensidadText.Name = "DensidadText";
            this.DensidadText.Size = new System.Drawing.Size(134, 20);
            this.DensidadText.TabIndex = 6;
            this.DensidadText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DensidadText_KeyPress);
            // 
            // ResiduoText
            // 
            this.ResiduoText.Location = new System.Drawing.Point(67, 181);
            this.ResiduoText.Name = "ResiduoText";
            this.ResiduoText.Size = new System.Drawing.Size(70, 20);
            this.ResiduoText.TabIndex = 7;
            this.ResiduoText.TextChanged += new System.EventHandler(this.ResiduoText_TextChanged);
            this.ResiduoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResiduoText_KeyPress);
            // 
            // ViscosidadText
            // 
            this.ViscosidadText.Location = new System.Drawing.Point(207, 181);
            this.ViscosidadText.Name = "ViscosidadText";
            this.ViscosidadText.Size = new System.Drawing.Size(72, 20);
            this.ViscosidadText.TabIndex = 8;
            this.ViscosidadText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ViscosidadText_KeyPress);
            // 
            // CtdAguaText
            // 
            this.CtdAguaText.Location = new System.Drawing.Point(383, 181);
            this.CtdAguaText.Name = "CtdAguaText";
            this.CtdAguaText.Size = new System.Drawing.Size(71, 20);
            this.CtdAguaText.TabIndex = 9;
            this.CtdAguaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CtdAguaText_KeyPress);
            // 
            // TurnoCombo
            // 
            this.TurnoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TurnoCombo.FormattingEnabled = true;
            this.TurnoCombo.Location = new System.Drawing.Point(194, 59);
            this.TurnoCombo.Name = "TurnoCombo";
            this.TurnoCombo.Size = new System.Drawing.Size(121, 21);
            this.TurnoCombo.TabIndex = 11;
            // 
            // EsmalteCombo
            // 
            this.EsmalteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EsmalteCombo.FormattingEnabled = true;
            this.EsmalteCombo.Location = new System.Drawing.Point(371, 59);
            this.EsmalteCombo.Name = "EsmalteCombo";
            this.EsmalteCombo.Size = new System.Drawing.Size(232, 21);
            this.EsmalteCombo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(153, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(321, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Esmalte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(609, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Operador";
            // 
            // MolinoCombo
            // 
            this.MolinoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MolinoCombo.FormattingEnabled = true;
            this.MolinoCombo.Location = new System.Drawing.Point(420, 123);
            this.MolinoCombo.Name = "MolinoCombo";
            this.MolinoCombo.Size = new System.Drawing.Size(55, 21);
            this.MolinoCombo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(376, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Molino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(481, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tiempo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(596, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Densidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(15, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Residuo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(143, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Viscosidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(285, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cantidad de Agua";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(460, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Fecha";
            // 
            // dataGridBaseDatos
            // 
            this.dataGridBaseDatos.AllowUserToAddRows = false;
            this.dataGridBaseDatos.AllowUserToDeleteRows = false;
            this.dataGridBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBaseDatos.Location = new System.Drawing.Point(15, 275);
            this.dataGridBaseDatos.MultiSelect = false;
            this.dataGridBaseDatos.Name = "dataGridBaseDatos";
            this.dataGridBaseDatos.ReadOnly = true;
            this.dataGridBaseDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBaseDatos.Size = new System.Drawing.Size(773, 150);
            this.dataGridBaseDatos.TabIndex = 26;
            this.dataGridBaseDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBaseDatos_CellClick);
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(15, 234);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(264, 35);
            this.AgregarBoton.TabIndex = 27;
            this.AgregarBoton.Text = "Agregar+";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // ModificarBoton
            // 
            this.ModificarBoton.Location = new System.Drawing.Point(267, 234);
            this.ModificarBoton.Name = "ModificarBoton";
            this.ModificarBoton.Size = new System.Drawing.Size(266, 35);
            this.ModificarBoton.TabIndex = 28;
            this.ModificarBoton.Text = "Modificar?";
            this.ModificarBoton.UseVisualStyleBackColor = true;
            this.ModificarBoton.Click += new System.EventHandler(this.ModificarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(532, 234);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(256, 35);
            this.EliminarBoton.TabIndex = 29;
            this.EliminarBoton.Text = "Eliminar-";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // ClaveText
            // 
            this.ClaveText.Location = new System.Drawing.Point(746, 181);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.ReadOnly = true;
            this.ClaveText.Size = new System.Drawing.Size(42, 20);
            this.ClaveText.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(706, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Clave";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(503, 181);
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Size = new System.Drawing.Size(197, 20);
            this.Fecha.TabIndex = 32;
            this.Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ClaveText);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.ModificarBoton);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.dataGridBaseDatos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MolinoCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EsmalteCombo);
            this.Controls.Add(this.TurnoCombo);
            this.Controls.Add(this.CtdAguaText);
            this.Controls.Add(this.ViscosidadText);
            this.Controls.Add(this.ResiduoText);
            this.Controls.Add(this.DensidadText);
            this.Controls.Add(this.TiempoText);
            this.Controls.Add(this.OperadorText);
            this.Controls.Add(this.LoteText);
            this.Controls.Add(this.FolioText);
            this.Name = "FormaReporte";
            this.Text = "Reporte de Esmaltes y Pastas Serigraficas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaReporte_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FormaReporte_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBaseDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolioText;
        private System.Windows.Forms.TextBox LoteText;
        private System.Windows.Forms.TextBox OperadorText;
        private System.Windows.Forms.TextBox TiempoText;
        private System.Windows.Forms.TextBox DensidadText;
        private System.Windows.Forms.TextBox ResiduoText;
        private System.Windows.Forms.TextBox ViscosidadText;
        private System.Windows.Forms.TextBox CtdAguaText;
        private System.Windows.Forms.ComboBox TurnoCombo;
        private System.Windows.Forms.ComboBox EsmalteCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MolinoCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridBaseDatos;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button ModificarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.TextBox ClaveText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.Timer timer1;
    }
}

