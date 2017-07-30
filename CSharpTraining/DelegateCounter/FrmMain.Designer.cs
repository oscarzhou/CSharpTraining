namespace CSharpTraining
{
    partial class FrmMain
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
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlusOne.Location = new System.Drawing.Point(97, 144);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(127, 42);
            this.btnPlusOne.TabIndex = 0;
            this.btnPlusOne.Text = "+1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(279, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 42);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 487);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlusOne);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnReset;
    }
}

