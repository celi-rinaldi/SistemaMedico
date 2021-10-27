
namespace WindowsMedicos
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
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNroMatricula = new System.Windows.Forms.TextBox();
            this.cbTraerPorEspecialidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(413, 62);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(145, 21);
            this.cbEspecialidad.TabIndex = 0;
            this.cbEspecialidad.Text = "Especialidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro Matricula:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(265, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNroMatricula
            // 
            this.txtNroMatricula.Location = new System.Drawing.Point(468, 105);
            this.txtNroMatricula.Name = "txtNroMatricula";
            this.txtNroMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtNroMatricula.TabIndex = 6;
            // 
            // cbTraerPorEspecialidad
            // 
            this.cbTraerPorEspecialidad.FormattingEnabled = true;
            this.cbTraerPorEspecialidad.Location = new System.Drawing.Point(437, 167);
            this.cbTraerPorEspecialidad.Name = "cbTraerPorEspecialidad";
            this.cbTraerPorEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbTraerPorEspecialidad.TabIndex = 7;
            this.cbTraerPorEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbTraerPorEspecialidad_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Traer por especialidad:";
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMedicos.Location = new System.Drawing.Point(0, 205);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(852, 270);
            this.gridMedicos.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(591, 62);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 42);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(591, 136);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(126, 34);
            this.btnRefrescar.TabIndex = 11;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 475);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTraerPorEspecialidad);
            this.Controls.Add(this.txtNroMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbEspecialidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroMatricula;
        private System.Windows.Forms.ComboBox cbTraerPorEspecialidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRefrescar;
    }
}

