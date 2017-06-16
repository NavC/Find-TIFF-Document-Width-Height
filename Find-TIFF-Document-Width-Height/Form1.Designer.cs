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
            this.lblPages = new System.Windows.Forms.Label();
            this.btnPages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindDimensions
            // 
            this.btnFindDimensions.Location = new System.Drawing.Point(156, 192);
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
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(12, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(140, 29);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Dimensions";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(12, 40);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(94, 29);
            this.lblPages.TabIndex = 1;
            this.lblPages.Text = "Pages: ";
            // 
            // btnPages
            // 
            this.btnPages.Location = new System.Drawing.Point(18, 192);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(132, 46);
            this.btnPages.TabIndex = 0;
            this.btnPages.Text = "Find Pages";
            this.btnPages.UseVisualStyleBackColor = true;
            this.btnPages.Click += new System.EventHandler(this.btnPages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 250);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnPages);
            this.Controls.Add(this.btnFindDimensions);
            this.Name = "Form1";
            this.Text = "Find TiFF Dimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDimensions;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnPages;
    }
}

