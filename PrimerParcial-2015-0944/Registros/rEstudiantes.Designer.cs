namespace PrimerParcial_2015_0944.Registros
{
    partial class rEstudiantes
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
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estudiantesIDtextBox = new System.Windows.Forms.TextBox();
            this.nombrestextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidostextBox = new System.Windows.Forms.TextBox();
            this.matriculatextBox = new System.Windows.Forms.TextBox();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.mostrarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(39, 64);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(49, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante ID";
            // 
            // estudiantesIDtextBox
            // 
            this.estudiantesIDtextBox.Location = new System.Drawing.Point(115, 26);
            this.estudiantesIDtextBox.Name = "estudiantesIDtextBox";
            this.estudiantesIDtextBox.Size = new System.Drawing.Size(80, 20);
            this.estudiantesIDtextBox.TabIndex = 2;
            // 
            // nombrestextBox
            // 
            this.nombrestextBox.Location = new System.Drawing.Point(115, 64);
            this.nombrestextBox.Name = "nombrestextBox";
            this.nombrestextBox.Size = new System.Drawing.Size(131, 20);
            this.nombrestextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matricula";
            // 
            // apellidostextBox
            // 
            this.apellidostextBox.Location = new System.Drawing.Point(115, 96);
            this.apellidostextBox.Name = "apellidostextBox";
            this.apellidostextBox.Size = new System.Drawing.Size(131, 20);
            this.apellidostextBox.TabIndex = 6;
            // 
            // matriculatextBox
            // 
            this.matriculatextBox.Location = new System.Drawing.Point(116, 130);
            this.matriculatextBox.Name = "matriculatextBox";
            this.matriculatextBox.Size = new System.Drawing.Size(130, 20);
            this.matriculatextBox.TabIndex = 7;
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::PrimerParcial_2015_0944.Properties.Resources.Save_as_37111;
            this.guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarbutton.Location = new System.Drawing.Point(132, 177);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(63, 59);
            this.guardarbutton.TabIndex = 8;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Image = global::PrimerParcial_2015_0944.Properties.Resources.New_File_36861;
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevobutton.Location = new System.Drawing.Point(42, 177);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(68, 59);
            this.nuevobutton.TabIndex = 9;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Image = global::PrimerParcial_2015_0944.Properties.Resources.delete_remove_page_document_16678;
            this.eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarbutton.Location = new System.Drawing.Point(212, 177);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(62, 59);
            this.eliminarbutton.TabIndex = 10;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::PrimerParcial_2015_0944.Properties.Resources.preview_search_find_locate_1551;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarbutton.Location = new System.Drawing.Point(201, 22);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(73, 34);
            this.buscarbutton.TabIndex = 11;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // mostrarerrorProvider
            // 
            this.mostrarerrorProvider.ContainerControl = this;
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 270);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.matriculatextBox);
            this.Controls.Add(this.apellidostextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrestextBox);
            this.Controls.Add(this.estudiantesIDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "rEstudiantes";
            this.Text = "Registros de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox estudiantesIDtextBox;
        private System.Windows.Forms.TextBox nombrestextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidostextBox;
        private System.Windows.Forms.TextBox matriculatextBox;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.ErrorProvider mostrarerrorProvider;
    }
}