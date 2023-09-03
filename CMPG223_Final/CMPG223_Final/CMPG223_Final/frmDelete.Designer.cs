namespace CMPG223_Final
{
    partial class frmDelete
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
            this.nudDeleteID = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDeleteID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteID)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDeleteID
            // 
            this.nudDeleteID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.nudDeleteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDeleteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.nudDeleteID.ForeColor = System.Drawing.Color.White;
            this.nudDeleteID.Location = new System.Drawing.Point(25, 53);
            this.nudDeleteID.Name = "nudDeleteID";
            this.nudDeleteID.Size = new System.Drawing.Size(288, 25);
            this.nudDeleteID.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 34);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(227, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 34);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblDeleteID
            // 
            this.lblDeleteID.AutoSize = true;
            this.lblDeleteID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteID.ForeColor = System.Drawing.Color.White;
            this.lblDeleteID.Location = new System.Drawing.Point(22, 25);
            this.lblDeleteID.Name = "lblDeleteID";
            this.lblDeleteID.Size = new System.Drawing.Size(291, 17);
            this.lblDeleteID.TabIndex = 58;
            this.lblDeleteID.Text = "Choose the ID of the Item to be Deleted";
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG223_Final.Properties.Resources.CMPG_223_background2;
            this.ClientSize = new System.Drawing.Size(336, 150);
            this.Controls.Add(this.lblDeleteID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nudDeleteID);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudDeleteID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDeleteID;
    }
}