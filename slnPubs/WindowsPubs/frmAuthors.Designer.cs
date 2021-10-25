
namespace WindowsPubs
{
    partial class frmAuthors
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
            this.gridAuthors = new System.Windows.Forms.DataGridView();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnBuscarPorCity = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.btnCityAndState = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAuthors
            // 
            this.gridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAuthors.Location = new System.Drawing.Point(0, 201);
            this.gridAuthors.Name = "gridAuthors";
            this.gridAuthors.Size = new System.Drawing.Size(904, 295);
            this.gridAuthors.TabIndex = 0;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(132, 32);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(197, 25);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 2;
            // 
            // btnBuscarPorCity
            // 
            this.btnBuscarPorCity.Location = new System.Drawing.Point(347, 25);
            this.btnBuscarPorCity.Name = "btnBuscarPorCity";
            this.btnBuscarPorCity.Size = new System.Drawing.Size(140, 33);
            this.btnBuscarPorCity.TabIndex = 3;
            this.btnBuscarPorCity.Text = "Sort by City";
            this.btnBuscarPorCity.UseVisualStyleBackColor = true;
            this.btnBuscarPorCity.Click += new System.EventHandler(this.btnBuscarPorCity_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(197, 81);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 4;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(124, 88);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State:";
            // 
            // btnCityAndState
            // 
            this.btnCityAndState.Location = new System.Drawing.Point(347, 78);
            this.btnCityAndState.Name = "btnCityAndState";
            this.btnCityAndState.Size = new System.Drawing.Size(140, 32);
            this.btnCityAndState.TabIndex = 6;
            this.btnCityAndState.Text = "Sort by City and State";
            this.btnCityAndState.UseVisualStyleBackColor = true;
            this.btnCityAndState.Click += new System.EventHandler(this.btnCityAndState_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(533, 54);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(86, 30);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(347, 159);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbCiudad.TabIndex = 8;
            this.cbCiudad.SelectionChangeCommitted += new System.EventHandler(this.cbCiudad_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Traer por ciudades";
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnCityAndState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnBuscarPorCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.gridAuthors);
            this.Name = "frmAuthors";
            this.Text = "frmAuthors";
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAuthors;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnBuscarPorCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnCityAndState;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label1;
    }
}