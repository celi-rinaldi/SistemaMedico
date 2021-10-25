
namespace WindowsPubs
{
    partial class frmPublisher
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
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.lblCity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnSortByCity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnCityStateCountry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPublisher.Location = new System.Drawing.Point(0, 173);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(1040, 318);
            this.gridPublisher.TabIndex = 0;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(104, 39);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(167, 39);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(167, 83);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 4;
            // 
            // btnSortByCity
            // 
            this.btnSortByCity.Location = new System.Drawing.Point(285, 31);
            this.btnSortByCity.Name = "btnSortByCity";
            this.btnSortByCity.Size = new System.Drawing.Size(128, 28);
            this.btnSortByCity.TabIndex = 5;
            this.btnSortByCity.Text = "Sort By City";
            this.btnSortByCity.UseVisualStyleBackColor = true;
            this.btnSortByCity.Click += new System.EventHandler(this.btnSortByCity_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sort By City and State";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(458, 31);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 34);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnCityStateCountry
            // 
            this.btnCityStateCountry.Location = new System.Drawing.Point(445, 86);
            this.btnCityStateCountry.Name = "btnCityStateCountry";
            this.btnCityStateCountry.Size = new System.Drawing.Size(160, 28);
            this.btnCityStateCountry.TabIndex = 8;
            this.btnCityStateCountry.Text = "Sort by City, State and Country";
            this.btnCityStateCountry.UseVisualStyleBackColor = true;
            this.btnCityStateCountry.Click += new System.EventHandler(this.btnCityStateCountry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(167, 128);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 10;
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCityStateCountry);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSortByCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.gridPublisher);
            this.Name = "frmPublisher";
            this.Text = "frmPublisher";
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnSortByCity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnCityStateCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountry;
    }
}