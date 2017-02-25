namespace Practicas.UI.Retgistros
{
    partial class RegistroPeliculas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaEstrenoLabel;
            System.Windows.Forms.Label label2;
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.actorComboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaEstrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            peliculaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaEstrenoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 19;
            label1.Text = "ACTOR";
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            peliculaIdLabel.Location = new System.Drawing.Point(42, 45);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(90, 17);
            peliculaIdLabel.TabIndex = 16;
            peliculaIdLabel.Text = "PELICULA ID";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            nombreLabel.Location = new System.Drawing.Point(42, 71);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(68, 17);
            nombreLabel.TabIndex = 18;
            nombreLabel.Text = "NOMBRE";
            // 
            // fechaEstrenoLabel
            // 
            fechaEstrenoLabel.AutoSize = true;
            fechaEstrenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            fechaEstrenoLabel.Location = new System.Drawing.Point(42, 98);
            fechaEstrenoLabel.Name = "fechaEstrenoLabel";
            fechaEstrenoLabel.Size = new System.Drawing.Size(124, 17);
            fechaEstrenoLabel.TabIndex = 20;
            fechaEstrenoLabel.Text = "FECHA ESTRENO";
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.actorComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(33, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 255);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPARTO";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.AllowUserToOrderColumns = true;
            this.DetalledataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(6, 53);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(498, 188);
            this.DetalledataGridView.TabIndex = 18;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Location = new System.Drawing.Point(407, 21);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(97, 23);
            this.Agregarbutton.TabIndex = 17;
            this.Agregarbutton.Text = "AGREGAR";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click_1);
            // 
            // actorComboBox
            // 
            this.actorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actorComboBox.FormattingEnabled = true;
            this.actorComboBox.Location = new System.Drawing.Point(65, 22);
            this.actorComboBox.Name = "actorComboBox";
            this.actorComboBox.Size = new System.Drawing.Size(215, 25);
            this.actorComboBox.TabIndex = 16;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Buscarbutton.Location = new System.Drawing.Point(349, 42);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 25;
            this.Buscarbutton.Text = "BUSCAR";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Eliminarbutton.Location = new System.Drawing.Point(377, 410);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(110, 23);
            this.Eliminarbutton.TabIndex = 24;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Guardarbutton.Location = new System.Drawing.Point(230, 410);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(110, 23);
            this.Guardarbutton.TabIndex = 23;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Nuevobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Nuevobutton.Location = new System.Drawing.Point(74, 410);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(110, 23);
            this.Nuevobutton.TabIndex = 22;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.peliculaIdTextBox.Location = new System.Drawing.Point(235, 45);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(94, 23);
            this.peliculaIdTextBox.TabIndex = 17;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.nombreTextBox.Location = new System.Drawing.Point(235, 71);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(249, 23);
            this.nombreTextBox.TabIndex = 19;
            // 
            // fechaEstrenoDateTimePicker
            // 
            this.fechaEstrenoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaEstrenoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaEstrenoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.fechaEstrenoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaEstrenoDateTimePicker.Location = new System.Drawing.Point(235, 97);
            this.fechaEstrenoDateTimePicker.Name = "fechaEstrenoDateTimePicker";
            this.fechaEstrenoDateTimePicker.Size = new System.Drawing.Size(249, 23);
            this.fechaEstrenoDateTimePicker.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new System.Drawing.Point(239, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 17);
            label2.TabIndex = 27;
            label2.Text = "REGISTRO";
            // 
            // RegistroPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 445);
            this.Controls.Add(label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaEstrenoLabel);
            this.Controls.Add(this.fechaEstrenoDateTimePicker);
            this.Name = "RegistroPeliculas";
            this.Text = "REGISTRO PELICULAS";
            this.Load += new System.EventHandler(this.RegistroPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox actorComboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaEstrenoDateTimePicker;
    }
}