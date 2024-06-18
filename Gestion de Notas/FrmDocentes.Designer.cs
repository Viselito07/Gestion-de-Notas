namespace Gestion_de_Notas
{
    partial class FrmDocentes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_gestionDocente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechNac = new System.Windows.Forms.DateTimePicker();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_modificarD = new System.Windows.Forms.Button();
            this.btn_eliminarD = new System.Windows.Forms.Button();
            this.btn_guardarD = new System.Windows.Forms.Button();
            this.txt_telefonoD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Especialidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_direccionD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellidosD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombreD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nidD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoDocente = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_buscarD = new System.Windows.Forms.Button();
            this.lbl_listaDocente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.lbl_gestionDocente);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1251, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_gestionDocente
            // 
            this.lbl_gestionDocente.AutoSize = true;
            this.lbl_gestionDocente.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestionDocente.Location = new System.Drawing.Point(556, 18);
            this.lbl_gestionDocente.Name = "lbl_gestionDocente";
            this.lbl_gestionDocente.Size = new System.Drawing.Size(213, 32);
            this.lbl_gestionDocente.TabIndex = 0;
            this.lbl_gestionDocente.Text = "Gestion Docentes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Controls.Add(this.dtpFechNac);
            this.groupBox2.Controls.Add(this.btn_cerrar);
            this.groupBox2.Controls.Add(this.btn_modificarD);
            this.groupBox2.Controls.Add(this.btn_eliminarD);
            this.groupBox2.Controls.Add(this.btn_guardarD);
            this.groupBox2.Controls.Add(this.txt_telefonoD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Especialidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_direccionD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_apellidosD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_nombreD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_nidD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblInfoDocente);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(2, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 548);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtpFechNac
            // 
            this.dtpFechNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechNac.Location = new System.Drawing.Point(24, 450);
            this.dtpFechNac.Name = "dtpFechNac";
            this.dtpFechNac.Size = new System.Drawing.Size(139, 22);
            this.dtpFechNac.TabIndex = 4;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = global::Gestion_de_Notas.Properties.Resources.cerrar;
            this.btn_cerrar.Location = new System.Drawing.Point(283, 489);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(65, 31);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_modificarD
            // 
            this.btn_modificarD.Image = global::Gestion_de_Notas.Properties.Resources.update;
            this.btn_modificarD.Location = new System.Drawing.Point(197, 489);
            this.btn_modificarD.Name = "btn_modificarD";
            this.btn_modificarD.Size = new System.Drawing.Size(65, 31);
            this.btn_modificarD.TabIndex = 10;
            this.btn_modificarD.UseVisualStyleBackColor = true;
            this.btn_modificarD.Click += new System.EventHandler(this.btn_modificarD_Click);
            // 
            // btn_eliminarD
            // 
            this.btn_eliminarD.Image = global::Gestion_de_Notas.Properties.Resources.eliminar;
            this.btn_eliminarD.Location = new System.Drawing.Point(110, 489);
            this.btn_eliminarD.Name = "btn_eliminarD";
            this.btn_eliminarD.Size = new System.Drawing.Size(65, 31);
            this.btn_eliminarD.TabIndex = 9;
            this.btn_eliminarD.UseVisualStyleBackColor = true;
            this.btn_eliminarD.Click += new System.EventHandler(this.btn_eliminarD_Click);
            // 
            // btn_guardarD
            // 
            this.btn_guardarD.Image = global::Gestion_de_Notas.Properties.Resources.agregar;
            this.btn_guardarD.Location = new System.Drawing.Point(25, 489);
            this.btn_guardarD.Name = "btn_guardarD";
            this.btn_guardarD.Size = new System.Drawing.Size(65, 31);
            this.btn_guardarD.TabIndex = 8;
            this.btn_guardarD.UseVisualStyleBackColor = true;
            this.btn_guardarD.Click += new System.EventHandler(this.btn_guardarD_Click);
            // 
            // txt_telefonoD
            // 
            this.txt_telefonoD.Location = new System.Drawing.Point(188, 379);
            this.txt_telefonoD.Multiline = true;
            this.txt_telefonoD.Name = "txt_telefonoD";
            this.txt_telefonoD.Size = new System.Drawing.Size(139, 25);
            this.txt_telefonoD.TabIndex = 7;
            this.txt_telefonoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefono";
            // 
            // txt_Especialidad
            // 
            this.txt_Especialidad.Location = new System.Drawing.Point(189, 308);
            this.txt_Especialidad.Multiline = true;
            this.txt_Especialidad.Name = "txt_Especialidad";
            this.txt_Especialidad.Size = new System.Drawing.Size(139, 25);
            this.txt_Especialidad.TabIndex = 6;
            this.txt_Especialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Especialidad";
            // 
            // txt_direccionD
            // 
            this.txt_direccionD.Location = new System.Drawing.Point(190, 238);
            this.txt_direccionD.Multiline = true;
            this.txt_direccionD.Name = "txt_direccionD";
            this.txt_direccionD.Size = new System.Drawing.Size(139, 25);
            this.txt_direccionD.TabIndex = 5;
            this.txt_direccionD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // txt_apellidosD
            // 
            this.txt_apellidosD.Location = new System.Drawing.Point(24, 379);
            this.txt_apellidosD.Multiline = true;
            this.txt_apellidosD.Name = "txt_apellidosD";
            this.txt_apellidosD.Size = new System.Drawing.Size(139, 25);
            this.txt_apellidosD.TabIndex = 3;
            this.txt_apellidosD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos";
            // 
            // txt_nombreD
            // 
            this.txt_nombreD.Location = new System.Drawing.Point(24, 308);
            this.txt_nombreD.Multiline = true;
            this.txt_nombreD.Name = "txt_nombreD";
            this.txt_nombreD.Size = new System.Drawing.Size(139, 25);
            this.txt_nombreD.TabIndex = 2;
            this.txt_nombreD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            // 
            // txt_nidD
            // 
            this.txt_nidD.Location = new System.Drawing.Point(24, 238);
            this.txt_nidD.Multiline = true;
            this.txt_nidD.Name = "txt_nidD";
            this.txt_nidD.Size = new System.Drawing.Size(139, 25);
            this.txt_nidD.TabIndex = 1;
            this.txt_nidD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NID";
            // 
            // lblInfoDocente
            // 
            this.lblInfoDocente.AutoSize = true;
            this.lblInfoDocente.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDocente.Location = new System.Drawing.Point(69, 18);
            this.lblInfoDocente.Name = "lblInfoDocente";
            this.lblInfoDocente.Size = new System.Drawing.Size(223, 23);
            this.lblInfoDocente.TabIndex = 1;
            this.lblInfoDocente.Text = "Informacion Del Docente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(73, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 144);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_de_Notas.Properties.Resources.Docenteicon;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox3.Controls.Add(this.btn_buscarD);
            this.groupBox3.Controls.Add(this.lbl_listaDocente);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(387, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 548);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_buscarD
            // 
            this.btn_buscarD.Location = new System.Drawing.Point(94, 489);
            this.btn_buscarD.Name = "btn_buscarD";
            this.btn_buscarD.Size = new System.Drawing.Size(65, 31);
            this.btn_buscarD.TabIndex = 12;
            this.btn_buscarD.Text = "Buscar";
            this.btn_buscarD.UseVisualStyleBackColor = true;
            this.btn_buscarD.Click += new System.EventHandler(this.btn_buscarD_Click);
            // 
            // lbl_listaDocente
            // 
            this.lbl_listaDocente.AutoSize = true;
            this.lbl_listaDocente.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listaDocente.Location = new System.Drawing.Point(309, 18);
            this.lbl_listaDocente.Name = "lbl_listaDocente";
            this.lbl_listaDocente.Size = new System.Drawing.Size(161, 23);
            this.lbl_listaDocente.TabIndex = 1;
            this.lbl_listaDocente.Text = "Lista De Docentes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmDocentes
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDocentes";
            this.Text = "FrmDocentes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_gestionDocente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfoDocente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_listaDocente;
        private System.Windows.Forms.TextBox txt_nidD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellidosD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombreD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefonoD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Especialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_direccionD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_modificarD;
        private System.Windows.Forms.Button btn_eliminarD;
        private System.Windows.Forms.Button btn_guardarD;
        private System.Windows.Forms.DateTimePicker dtpFechNac;
        private System.Windows.Forms.Button btn_buscarD;
    }
}