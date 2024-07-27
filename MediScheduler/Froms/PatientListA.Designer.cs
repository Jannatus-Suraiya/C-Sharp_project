namespace MediScheduler
{
    partial class PatientListA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListA));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPatientlist1 = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientlist1)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(18)))), ((int)(((byte)(66)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Patient List !";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvPatientlist1
            // 
            this.dgvPatientlist1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvPatientlist1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientlist1.Location = new System.Drawing.Point(7, 78);
            this.dgvPatientlist1.Name = "dgvPatientlist1";
            this.dgvPatientlist1.RowHeadersWidth = 51;
            this.dgvPatientlist1.RowTemplate.Height = 24;
            this.dgvPatientlist1.Size = new System.Drawing.Size(741, 476);
            this.dgvPatientlist1.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.panel9.Controls.Add(this.button1);
            this.panel9.Location = new System.Drawing.Point(7, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(261, 61);
            this.panel9.TabIndex = 21;
            // 
            // PatientListA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(93)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(754, 564);
            this.Controls.Add(this.dgvPatientlist1);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientListA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientListA";
            this.Load += new System.EventHandler(this.PatientListA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientlist1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPatientlist1;
        private System.Windows.Forms.Panel panel9;
    }
}