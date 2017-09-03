namespace CSharpTraining
{
    partial class Gridview
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
            this.dgvTest1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTest1
            // 
            this.dgvTest1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest1.Location = new System.Drawing.Point(248, 86);
            this.dgvTest1.Name = "dgvTest1";
            this.dgvTest1.RowTemplate.Height = 30;
            this.dgvTest1.Size = new System.Drawing.Size(240, 150);
            this.dgvTest1.TabIndex = 0;
            // 
            // Gridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.dgvTest1);
            this.Name = "Gridview";
            this.Text = "Gridview";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTest1;
    }
}