namespace Veterinaria
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbpgs_mascotas = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_agregarM = new System.Windows.Forms.Button();
            this.cbox_dueño = new System.Windows.Forms.ComboBox();
            this.txt_razaM = new System.Windows.Forms.TextBox();
            this.txt_edadM = new System.Windows.Forms.TextBox();
            this.txt_nombreM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.nombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpg_dueños = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.txtbox_telefono = new System.Windows.Forms.TextBox();
            this.txtbox_correo = new System.Windows.Forms.TextBox();
            this.txtbox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDueños = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tbpgs_mascotas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.tbpg_dueños.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueños)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbpgs_mascotas
            // 
            this.tbpgs_mascotas.Controls.Add(this.groupBox3);
            this.tbpgs_mascotas.Controls.Add(this.groupBox2);
            this.tbpgs_mascotas.Controls.Add(this.dgvMascotas);
            this.tbpgs_mascotas.Location = new System.Drawing.Point(4, 29);
            this.tbpgs_mascotas.Name = "tbpgs_mascotas";
            this.tbpgs_mascotas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgs_mascotas.Size = new System.Drawing.Size(968, 492);
            this.tbpgs_mascotas.TabIndex = 1;
            this.tbpgs_mascotas.Text = "Mascotas";
            this.tbpgs_mascotas.UseVisualStyleBackColor = true;
            this.tbpgs_mascotas.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_buscar);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(591, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 233);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(6, 121);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(351, 36);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(281, 27);
            this.textBox4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_agregarM);
            this.groupBox2.Controls.Add(this.cbox_dueño);
            this.groupBox2.Controls.Add(this.txt_razaM);
            this.groupBox2.Controls.Add(this.txt_edadM);
            this.groupBox2.Controls.Add(this.txt_nombreM);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(591, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar";
            // 
            // btn_agregarM
            // 
            this.btn_agregarM.Location = new System.Drawing.Point(6, 185);
            this.btn_agregarM.Name = "btn_agregarM";
            this.btn_agregarM.Size = new System.Drawing.Size(351, 36);
            this.btn_agregarM.TabIndex = 2;
            this.btn_agregarM.Text = "Agregar";
            this.btn_agregarM.UseVisualStyleBackColor = true;
            this.btn_agregarM.Click += new System.EventHandler(this.btn_agregarM_Click);
            // 
            // cbox_dueño
            // 
            this.cbox_dueño.FormattingEnabled = true;
            this.cbox_dueño.Location = new System.Drawing.Point(76, 146);
            this.cbox_dueño.Name = "cbox_dueño";
            this.cbox_dueño.Size = new System.Drawing.Size(204, 28);
            this.cbox_dueño.TabIndex = 7;
            // 
            // txt_razaM
            // 
            this.txt_razaM.Location = new System.Drawing.Point(76, 109);
            this.txt_razaM.Name = "txt_razaM";
            this.txt_razaM.Size = new System.Drawing.Size(281, 27);
            this.txt_razaM.TabIndex = 6;
            // 
            // txt_edadM
            // 
            this.txt_edadM.Location = new System.Drawing.Point(76, 76);
            this.txt_edadM.Name = "txt_edadM";
            this.txt_edadM.Size = new System.Drawing.Size(281, 27);
            this.txt_edadM.TabIndex = 5;
            // 
            // txt_nombreM
            // 
            this.txt_nombreM.Location = new System.Drawing.Point(76, 43);
            this.txt_nombreM.Name = "txt_nombreM";
            this.txt_nombreM.Size = new System.Drawing.Size(281, 27);
            this.txt_nombreM.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dueño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.AllowUserToAddRows = false;
            this.dgvMascotas.AllowUserToDeleteRows = false;
            this.dgvMascotas.AllowUserToResizeColumns = false;
            this.dgvMascotas.AllowUserToResizeRows = false;
            this.dgvMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreM,
            this.edad,
            this.raza,
            this.dueño});
            this.dgvMascotas.Location = new System.Drawing.Point(6, 10);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 29;
            this.dgvMascotas.Size = new System.Drawing.Size(567, 476);
            this.dgvMascotas.TabIndex = 1;
            // 
            // nombreM
            // 
            this.nombreM.HeaderText = "Nombre";
            this.nombreM.MinimumWidth = 6;
            this.nombreM.Name = "nombreM";
            this.nombreM.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.HeaderText = "Raza";
            this.raza.MinimumWidth = 6;
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // dueño
            // 
            this.dueño.HeaderText = "Dueño";
            this.dueño.MinimumWidth = 6;
            this.dueño.Name = "dueño";
            this.dueño.ReadOnly = true;
            // 
            // tbpg_dueños
            // 
            this.tbpg_dueños.Controls.Add(this.groupBox1);
            this.tbpg_dueños.Controls.Add(this.dgvDueños);
            this.tbpg_dueños.Location = new System.Drawing.Point(4, 29);
            this.tbpg_dueños.Name = "tbpg_dueños";
            this.tbpg_dueños.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_dueños.Size = new System.Drawing.Size(968, 492);
            this.tbpg_dueños.TabIndex = 0;
            this.tbpg_dueños.Text = "Dueños";
            this.tbpg_dueños.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.txtbox_telefono);
            this.groupBox1.Controls.Add(this.txtbox_correo);
            this.groupBox1.Controls.Add(this.txtbox_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(593, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Dueño";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(11, 201);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(341, 44);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // txtbox_telefono
            // 
            this.txtbox_telefono.Location = new System.Drawing.Point(84, 143);
            this.txtbox_telefono.Name = "txtbox_telefono";
            this.txtbox_telefono.Size = new System.Drawing.Size(268, 27);
            this.txtbox_telefono.TabIndex = 7;
            this.txtbox_telefono.TextChanged += new System.EventHandler(this.txtbox_telefono_TextChanged);
            this.txtbox_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_telefono_KeyPress);
            // 
            // txtbox_correo
            // 
            this.txtbox_correo.Location = new System.Drawing.Point(84, 98);
            this.txtbox_correo.Name = "txtbox_correo";
            this.txtbox_correo.Size = new System.Drawing.Size(268, 27);
            this.txtbox_correo.TabIndex = 6;
            // 
            // txtbox_nombre
            // 
            this.txtbox_nombre.Location = new System.Drawing.Point(84, 50);
            this.txtbox_nombre.Name = "txtbox_nombre";
            this.txtbox_nombre.Size = new System.Drawing.Size(268, 27);
            this.txtbox_nombre.TabIndex = 5;
            this.txtbox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_nombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // dgvDueños
            // 
            this.dgvDueños.AllowUserToAddRows = false;
            this.dgvDueños.AllowUserToDeleteRows = false;
            this.dgvDueños.AllowUserToResizeColumns = false;
            this.dgvDueños.AllowUserToResizeRows = false;
            this.dgvDueños.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.direccion,
            this.telefono});
            this.dgvDueños.Location = new System.Drawing.Point(6, 6);
            this.dgvDueños.Name = "dgvDueños";
            this.dgvDueños.ReadOnly = true;
            this.dgvDueños.RowHeadersWidth = 51;
            this.dgvDueños.RowTemplate.Height = 29;
            this.dgvDueños.Size = new System.Drawing.Size(567, 476);
            this.dgvDueños.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Correo";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tbpg_dueños);
            this.tabcontrol.Controls.Add(this.tbpgs_mascotas);
            this.tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(976, 525);
            this.tabcontrol.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.tabcontrol);
            this.Name = "Form1";
            this.Text = "Veterinaria";
            this.tbpgs_mascotas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.tbpg_dueños.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueños)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabPage tbpgs_mascotas;
        private TabPage tbpg_dueños;
        private TabControl tabcontrol;
        private DataGridView dgvDueños;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private GroupBox groupBox1;
        private Button Agregar;
        private TextBox txtbox_telefono;
        private TextBox txtbox_correo;
        private TextBox txtbox_nombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btn_buscar;
        private TextBox textBox4;
        private Label label8;
        private GroupBox groupBox2;
        private Button btn_agregarM;
        private ComboBox cbox_dueño;
        private TextBox txt_razaM;
        private TextBox txt_edadM;
        private TextBox txt_nombreM;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dgvMascotas;
        private DataGridViewTextBoxColumn nombreM;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn raza;
        private DataGridViewTextBoxColumn dueño;
    }
}