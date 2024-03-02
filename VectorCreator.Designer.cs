namespace VectorWorkings
{
    partial class VectorCreator
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
            this.labelMagnitude = new System.Windows.Forms.Label();
            this.cmdCreateVector = new System.Windows.Forms.Button();
            this.txtMagnitude = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.txtInitialHeight = new System.Windows.Forms.TextBox();
            this.labelInitialHeight = new System.Windows.Forms.Label();
            this.txtVectorName = new System.Windows.Forms.TextBox();
            this.labelVectorName = new System.Windows.Forms.Label();
            this.txtInitialRange = new System.Windows.Forms.TextBox();
            this.labelInitialRange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMagnitude
            // 
            this.labelMagnitude.AutoSize = true;
            this.labelMagnitude.Location = new System.Drawing.Point(12, 64);
            this.labelMagnitude.Name = "labelMagnitude";
            this.labelMagnitude.Size = new System.Drawing.Size(84, 20);
            this.labelMagnitude.TabIndex = 0;
            this.labelMagnitude.Text = "Magnitude";
            // 
            // cmdCreateVector
            // 
            this.cmdCreateVector.Location = new System.Drawing.Point(12, 12);
            this.cmdCreateVector.Name = "cmdCreateVector";
            this.cmdCreateVector.Size = new System.Drawing.Size(100, 39);
            this.cmdCreateVector.TabIndex = 5;
            this.cmdCreateVector.Text = "Create";
            this.cmdCreateVector.UseVisualStyleBackColor = true;
            this.cmdCreateVector.Click += new System.EventHandler(this.cmdCreateVector_Click);
            // 
            // txtMagnitude
            // 
            this.txtMagnitude.Location = new System.Drawing.Point(16, 88);
            this.txtMagnitude.Name = "txtMagnitude";
            this.txtMagnitude.Size = new System.Drawing.Size(100, 26);
            this.txtMagnitude.TabIndex = 1;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(122, 88);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 26);
            this.txtAngle.TabIndex = 2;
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(118, 64);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(50, 20);
            this.labelAngle.TabIndex = 3;
            this.labelAngle.Text = "Angle";
            // 
            // txtInitialHeight
            // 
            this.txtInitialHeight.Location = new System.Drawing.Point(16, 150);
            this.txtInitialHeight.Name = "txtInitialHeight";
            this.txtInitialHeight.Size = new System.Drawing.Size(100, 26);
            this.txtInitialHeight.TabIndex = 3;
            // 
            // labelInitialHeight
            // 
            this.labelInitialHeight.AutoSize = true;
            this.labelInitialHeight.Location = new System.Drawing.Point(12, 126);
            this.labelInitialHeight.Name = "labelInitialHeight";
            this.labelInitialHeight.Size = new System.Drawing.Size(97, 20);
            this.labelInitialHeight.TabIndex = 5;
            this.labelInitialHeight.Text = "Initial Height";
            // 
            // txtVectorName
            // 
            this.txtVectorName.Location = new System.Drawing.Point(122, 36);
            this.txtVectorName.Name = "txtVectorName";
            this.txtVectorName.Size = new System.Drawing.Size(100, 26);
            this.txtVectorName.TabIndex = 0;
            // 
            // labelVectorName
            // 
            this.labelVectorName.AutoSize = true;
            this.labelVectorName.Location = new System.Drawing.Point(118, 12);
            this.labelVectorName.Name = "labelVectorName";
            this.labelVectorName.Size = new System.Drawing.Size(51, 20);
            this.labelVectorName.TabIndex = 7;
            this.labelVectorName.Text = "Name";
            // 
            // txtInitialRange
            // 
            this.txtInitialRange.Location = new System.Drawing.Point(129, 150);
            this.txtInitialRange.Name = "txtInitialRange";
            this.txtInitialRange.Size = new System.Drawing.Size(100, 26);
            this.txtInitialRange.TabIndex = 4;
            // 
            // labelInitialRange
            // 
            this.labelInitialRange.AutoSize = true;
            this.labelInitialRange.Location = new System.Drawing.Point(125, 126);
            this.labelInitialRange.Name = "labelInitialRange";
            this.labelInitialRange.Size = new System.Drawing.Size(102, 20);
            this.labelInitialRange.TabIndex = 9;
            this.labelInitialRange.Text = "Initial Ramge";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 224);
            this.Controls.Add(this.txtInitialRange);
            this.Controls.Add(this.labelInitialRange);
            this.Controls.Add(this.txtVectorName);
            this.Controls.Add(this.labelVectorName);
            this.Controls.Add(this.txtInitialHeight);
            this.Controls.Add(this.labelInitialHeight);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.txtMagnitude);
            this.Controls.Add(this.cmdCreateVector);
            this.Controls.Add(this.labelMagnitude);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMagnitude;
        private System.Windows.Forms.Button cmdCreateVector;
        private System.Windows.Forms.TextBox txtMagnitude;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.TextBox txtInitialHeight;
        private System.Windows.Forms.Label labelInitialHeight;
        private System.Windows.Forms.TextBox txtVectorName;
        private System.Windows.Forms.Label labelVectorName;
        private System.Windows.Forms.TextBox txtInitialRange;
        private System.Windows.Forms.Label labelInitialRange;
    }
}