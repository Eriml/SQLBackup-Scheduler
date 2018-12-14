namespace SQLBackup_Scheduler
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Lunes = new System.Windows.Forms.CheckBox();
            this.Martes = new System.Windows.Forms.CheckBox();
            this.Miercoles = new System.Windows.Forms.CheckBox();
            this.Jueves = new System.Windows.Forms.CheckBox();
            this.Viernes = new System.Windows.Forms.CheckBox();
            this.Sabado = new System.Windows.Forms.CheckBox();
            this.Domingo = new System.Windows.Forms.CheckBox();
            this.Todos = new System.Windows.Forms.CheckBox();
            this.Mensual = new System.Windows.Forms.CheckBox();
            this.Instancia = new System.Windows.Forms.TextBox();
            this.BackUpFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Programar = new System.Windows.Forms.Button();
            this.Hora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClaveCompu = new System.Windows.Forms.TextBox();
            this.UsuarioCompu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lunes
            // 
            this.Lunes.AutoSize = true;
            this.Lunes.Checked = true;
            this.Lunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lunes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunes.Location = new System.Drawing.Point(53, 184);
            this.Lunes.Name = "Lunes";
            this.Lunes.Size = new System.Drawing.Size(31, 18);
            this.Lunes.TabIndex = 0;
            this.Lunes.Text = "L";
            this.Lunes.UseVisualStyleBackColor = true;
            this.Lunes.CheckedChanged += new System.EventHandler(this.Lunes_CheckedChanged);
            // 
            // Martes
            // 
            this.Martes.AutoSize = true;
            this.Martes.Checked = true;
            this.Martes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Martes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Martes.Location = new System.Drawing.Point(91, 184);
            this.Martes.Name = "Martes";
            this.Martes.Size = new System.Drawing.Size(36, 18);
            this.Martes.TabIndex = 1;
            this.Martes.Text = "M";
            this.Martes.UseVisualStyleBackColor = true;
            this.Martes.CheckedChanged += new System.EventHandler(this.Martes_CheckedChanged);
            // 
            // Miercoles
            // 
            this.Miercoles.AutoSize = true;
            this.Miercoles.Checked = true;
            this.Miercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Miercoles.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Miercoles.Location = new System.Drawing.Point(132, 184);
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Size = new System.Drawing.Size(36, 18);
            this.Miercoles.TabIndex = 2;
            this.Miercoles.Text = "M";
            this.Miercoles.UseVisualStyleBackColor = true;
            this.Miercoles.CheckedChanged += new System.EventHandler(this.Miercoles_CheckedChanged);
            // 
            // Jueves
            // 
            this.Jueves.AutoSize = true;
            this.Jueves.Checked = true;
            this.Jueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Jueves.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jueves.Location = new System.Drawing.Point(173, 184);
            this.Jueves.Name = "Jueves";
            this.Jueves.Size = new System.Drawing.Size(30, 18);
            this.Jueves.TabIndex = 3;
            this.Jueves.Text = "J";
            this.Jueves.UseVisualStyleBackColor = true;
            this.Jueves.CheckedChanged += new System.EventHandler(this.Jueves_CheckedChanged);
            // 
            // Viernes
            // 
            this.Viernes.AutoSize = true;
            this.Viernes.Checked = true;
            this.Viernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Viernes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viernes.Location = new System.Drawing.Point(214, 184);
            this.Viernes.Name = "Viernes";
            this.Viernes.Size = new System.Drawing.Size(33, 18);
            this.Viernes.TabIndex = 4;
            this.Viernes.Text = "V";
            this.Viernes.UseVisualStyleBackColor = true;
            this.Viernes.CheckedChanged += new System.EventHandler(this.Viernes_CheckedChanged);
            // 
            // Sabado
            // 
            this.Sabado.AutoSize = true;
            this.Sabado.Checked = true;
            this.Sabado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sabado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sabado.Location = new System.Drawing.Point(255, 184);
            this.Sabado.Name = "Sabado";
            this.Sabado.Size = new System.Drawing.Size(32, 18);
            this.Sabado.TabIndex = 5;
            this.Sabado.Text = "S";
            this.Sabado.UseVisualStyleBackColor = true;
            this.Sabado.CheckedChanged += new System.EventHandler(this.Sabado_CheckedChanged);
            // 
            // Domingo
            // 
            this.Domingo.AutoSize = true;
            this.Domingo.Checked = true;
            this.Domingo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Domingo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Domingo.Location = new System.Drawing.Point(296, 184);
            this.Domingo.Name = "Domingo";
            this.Domingo.Size = new System.Drawing.Size(34, 18);
            this.Domingo.TabIndex = 6;
            this.Domingo.Text = "D";
            this.Domingo.UseVisualStyleBackColor = true;
            this.Domingo.CheckedChanged += new System.EventHandler(this.Domingo_CheckedChanged);
            // 
            // Todos
            // 
            this.Todos.AutoSize = true;
            this.Todos.Checked = true;
            this.Todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Todos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todos.Location = new System.Drawing.Point(336, 184);
            this.Todos.Name = "Todos";
            this.Todos.Size = new System.Drawing.Size(58, 18);
            this.Todos.TabIndex = 7;
            this.Todos.Text = "Todos";
            this.Todos.UseVisualStyleBackColor = true;
            this.Todos.CheckedChanged += new System.EventHandler(this.Todos_CheckedChanged);
            this.Todos.Click += new System.EventHandler(this.Todos_Click);
            // 
            // Mensual
            // 
            this.Mensual.AutoSize = true;
            this.Mensual.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensual.Location = new System.Drawing.Point(263, 208);
            this.Mensual.Name = "Mensual";
            this.Mensual.Size = new System.Drawing.Size(129, 18);
            this.Mensual.TabIndex = 8;
            this.Mensual.Text = "Respaldo Mensual";
            this.Mensual.UseVisualStyleBackColor = true;
            // 
            // Instancia
            // 
            this.Instancia.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instancia.Location = new System.Drawing.Point(101, 43);
            this.Instancia.Name = "Instancia";
            this.Instancia.Size = new System.Drawing.Size(210, 22);
            this.Instancia.TabIndex = 9;
            this.Instancia.Text = "SERVIDOR\\AVATTIA";
            // 
            // BackUpFolder
            // 
            this.BackUpFolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUpFolder.Location = new System.Drawing.Point(101, 131);
            this.BackUpFolder.Name = "BackUpFolder";
            this.BackUpFolder.Size = new System.Drawing.Size(210, 22);
            this.BackUpFolder.TabIndex = 10;
            this.BackUpFolder.Text = "C:\\Respaldos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Instancia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Locación";
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(187, 69);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(124, 22);
            this.Usuario.TabIndex = 17;
            this.Usuario.Text = "sa";
            // 
            // Contra
            // 
            this.Contra.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra.Location = new System.Drawing.Point(187, 95);
            this.Contra.Name = "Contra";
            this.Contra.PasswordChar = '*';
            this.Contra.Size = new System.Drawing.Size(124, 22);
            this.Contra.TabIndex = 18;
            this.Contra.Text = "aitva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contraseña";
            // 
            // Programar
            // 
            this.Programar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programar.Location = new System.Drawing.Point(282, 315);
            this.Programar.Name = "Programar";
            this.Programar.Size = new System.Drawing.Size(124, 29);
            this.Programar.TabIndex = 21;
            this.Programar.Text = "Aceptar";
            this.Programar.UseVisualStyleBackColor = true;
            this.Programar.Click += new System.EventHandler(this.Programar_Click);
            // 
            // Hora
            // 
            this.Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora.Location = new System.Drawing.Point(305, 232);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(87, 20);
            this.Hora.TabIndex = 22;
            this.Hora.Value = new System.DateTime(2018, 9, 18, 0, 30, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Usuario";
            // 
            // ClaveCompu
            // 
            this.ClaveCompu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveCompu.Location = new System.Drawing.Point(111, 319);
            this.ClaveCompu.Name = "ClaveCompu";
            this.ClaveCompu.PasswordChar = '*';
            this.ClaveCompu.Size = new System.Drawing.Size(124, 22);
            this.ClaveCompu.TabIndex = 25;
            this.ClaveCompu.Text = "contrasena";
            // 
            // UsuarioCompu
            // 
            this.UsuarioCompu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCompu.Location = new System.Drawing.Point(111, 293);
            this.UsuarioCompu.Name = "UsuarioCompu";
            this.UsuarioCompu.Size = new System.Drawing.Size(124, 22);
            this.UsuarioCompu.TabIndex = 24;
            this.UsuarioCompu.Text = "SERVIDOR\\Admin";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 357);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClaveCompu);
            this.Controls.Add(this.UsuarioCompu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Programar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackUpFolder);
            this.Controls.Add(this.Instancia);
            this.Controls.Add(this.Mensual);
            this.Controls.Add(this.Todos);
            this.Controls.Add(this.Domingo);
            this.Controls.Add(this.Sabado);
            this.Controls.Add(this.Viernes);
            this.Controls.Add(this.Jueves);
            this.Controls.Add(this.Miercoles);
            this.Controls.Add(this.Martes);
            this.Controls.Add(this.Lunes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Programador de Respaldos SQL Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Lunes;
        private System.Windows.Forms.CheckBox Martes;
        private System.Windows.Forms.CheckBox Miercoles;
        private System.Windows.Forms.CheckBox Jueves;
        private System.Windows.Forms.CheckBox Viernes;
        private System.Windows.Forms.CheckBox Sabado;
        private System.Windows.Forms.CheckBox Domingo;
        private System.Windows.Forms.CheckBox Todos;
        private System.Windows.Forms.CheckBox Mensual;
        private System.Windows.Forms.TextBox Instancia;
        private System.Windows.Forms.TextBox BackUpFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Programar;
        private System.Windows.Forms.DateTimePicker Hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClaveCompu;
        private System.Windows.Forms.TextBox UsuarioCompu;
    }
}

