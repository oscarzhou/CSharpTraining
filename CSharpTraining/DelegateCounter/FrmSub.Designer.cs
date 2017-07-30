namespace CSharpTraining
{
    partial class FrmSub
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
            this.lbCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCounter
            // 
            this.lbCounter.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCounter.Location = new System.Drawing.Point(193, 133);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(66, 69);
            this.lbCounter.TabIndex = 0;
            this.lbCounter.Text = "0";
            // 
            // FrmSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 360);
            this.Controls.Add(this.lbCounter);
            this.Name = "FrmSub";
            this.Text = "Sub Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCounter;
    }
}