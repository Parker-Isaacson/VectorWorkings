namespace VectorWorkings
{
    partial class VectorGraphMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmdAddVector = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cboVectorListing = new System.Windows.Forms.ComboBox();
            this.cmdAddVectors = new System.Windows.Forms.Button();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmdResetChart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHoverInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAddVector
            // 
            this.cmdAddVector.Location = new System.Drawing.Point(63, 2);
            this.cmdAddVector.Name = "cmdAddVector";
            this.cmdAddVector.Size = new System.Drawing.Size(109, 31);
            this.cmdAddVector.TabIndex = 0;
            this.cmdAddVector.Text = "Add Vector";
            this.cmdAddVector.UseVisualStyleBackColor = true;
            this.cmdAddVector.Click += new System.EventHandler(this.cmdAddVector_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.Location = new System.Drawing.Point(13, 38);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(300, 435);
            this.txtOutput.TabIndex = 1;
            // 
            // cboVectorListing
            // 
            this.cboVectorListing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVectorListing.FormattingEnabled = true;
            this.cboVectorListing.Location = new System.Drawing.Point(178, 4);
            this.cboVectorListing.Name = "cboVectorListing";
            this.cboVectorListing.Size = new System.Drawing.Size(185, 28);
            this.cboVectorListing.TabIndex = 2;
            this.cboVectorListing.SelectedIndexChanged += new System.EventHandler(this.cboVectorListing_SelectedIndexChanged);
            // 
            // cmdAddVectors
            // 
            this.cmdAddVectors.Location = new System.Drawing.Point(369, 2);
            this.cmdAddVectors.Name = "cmdAddVectors";
            this.cmdAddVectors.Size = new System.Drawing.Size(115, 31);
            this.cmdAddVectors.TabIndex = 3;
            this.cmdAddVectors.Text = "Pre-Canned";
            this.cmdAddVectors.UseVisualStyleBackColor = true;
            this.cmdAddVectors.Click += new System.EventHandler(this.cmdAddVectors_Click);
            // 
            // chartFunctions
            // 
            this.chartFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunctions.Legends.Add(legend1);
            this.chartFunctions.Location = new System.Drawing.Point(319, 38);
            this.chartFunctions.Name = "chartFunctions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunctions.Series.Add(series1);
            this.chartFunctions.Size = new System.Drawing.Size(441, 412);
            this.chartFunctions.TabIndex = 5;
            this.chartFunctions.Text = "chart1";
            this.chartFunctions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartFunctions_MouseMove);
            // 
            // cmdResetChart
            // 
            this.cmdResetChart.Location = new System.Drawing.Point(490, 2);
            this.cmdResetChart.Name = "cmdResetChart";
            this.cmdResetChart.Size = new System.Drawing.Size(106, 31);
            this.cmdResetChart.TabIndex = 6;
            this.cmdResetChart.Text = "Reset Chart";
            this.cmdResetChart.UseVisualStyleBackColor = true;
            this.cmdResetChart.Click += new System.EventHandler(this.cmdResetChart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSave,
            this.menuFileOpen,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "File";
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(158, 34);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(158, 34);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(158, 34);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // labelHoverInformation
            // 
            this.labelHoverInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHoverInformation.AutoSize = true;
            this.labelHoverInformation.Location = new System.Drawing.Point(319, 453);
            this.labelHoverInformation.Name = "labelHoverInformation";
            this.labelHoverInformation.Size = new System.Drawing.Size(125, 20);
            this.labelHoverInformation.TabIndex = 8;
            this.labelHoverInformation.Text = "Hover On Graph";
            // 
            // VectorGraphMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 485);
            this.Controls.Add(this.labelHoverInformation);
            this.Controls.Add(this.cmdResetChart);
            this.Controls.Add(this.cmdAddVectors);
            this.Controls.Add(this.chartFunctions);
            this.Controls.Add(this.cboVectorListing);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmdAddVector);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VectorGraphMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAddVector;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cboVectorListing;
        private System.Windows.Forms.Button cmdAddVectors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.Windows.Forms.Button cmdResetChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.Label labelHoverInformation;
    }
}

