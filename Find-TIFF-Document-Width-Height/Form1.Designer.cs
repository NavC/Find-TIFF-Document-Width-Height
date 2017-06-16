namespace Find_TIFF_Document_Width_Height
{
    partial class Form1
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
            this.btnFindDimensions = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindDimensions
            // 
            this.btnFindDimensions.Location = new System.Drawing.Point(73, 192);
            this.btnFindDimensions.Name = "btnFindDimensions";
            this.btnFindDimensions.Size = new System.Drawing.Size(132, 46);
            this.btnFindDimensions.TabIndex = 0;
            this.btnFindDimensions.Text = "Find Dimensions";
            this.btnFindDimensions.UseVisualStyleBackColor = true;
            this.btnFindDimensions.Click += new System.EventHandler(this.btnFindDimensions_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(12, 95);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(156, 31);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Dimensions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 250);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnFindDimensions);
            this.Name = "Form1";
            this.Text = "Find TiFF Dimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDimensions;
        private System.Windows.Forms.Label lblSize;
    }
}

