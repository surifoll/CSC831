namespace HopfieldRecognizer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.butCreateNN = new System.Windows.Forms.Button();
            this.butAddPattern = new System.Windows.Forms.Button();
            this.panelStoredImages = new System.Windows.Forms.Panel();
            this.butRunDynamics = new System.Windows.Forms.Button();
            this.gbNNProperties = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNNSize = new System.Windows.Forms.Label();
            this.lblNumberOfPatterns = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblStaticEnergy = new System.Windows.Forms.Label();
            this.lblStaticSizeOfNN = new System.Windows.Forms.Label();
            this.lblStaticNumberOfPatterns = new System.Windows.Forms.Label();
            this.gbNNCurrentState = new System.Windows.Forms.GroupBox();
            this.imNNState = new ImageMagnifier.ImageMagnifier();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gbPatternsInNN = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNNProperties.SuspendLayout();
            this.gbNNCurrentState.SuspendLayout();
            this.gbPatternsInNN.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCreateNN
            // 
            this.butCreateNN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butCreateNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCreateNN.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateNN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butCreateNN.Location = new System.Drawing.Point(500, 80);
            this.butCreateNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreateNN.Name = "butCreateNN";
            this.butCreateNN.Size = new System.Drawing.Size(416, 47);
            this.butCreateNN.TabIndex = 1;
            this.butCreateNN.Text = "Create Neural Network (1000 Neurons)";
            this.butCreateNN.UseVisualStyleBackColor = false;
            this.butCreateNN.Click += new System.EventHandler(this.CreateNNBut_Click);
            // 
            // butAddPattern
            // 
            this.butAddPattern.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butAddPattern.Enabled = false;
            this.butAddPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddPattern.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddPattern.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddPattern.Location = new System.Drawing.Point(500, 159);
            this.butAddPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddPattern.Name = "butAddPattern";
            this.butAddPattern.Size = new System.Drawing.Size(416, 47);
            this.butAddPattern.TabIndex = 1;
            this.butAddPattern.Text = "Add pattern to Neural network";
            this.butAddPattern.UseVisualStyleBackColor = false;
            this.butAddPattern.Click += new System.EventHandler(this.AddPatternBut_Click);
            // 
            // panelStoredImages
            // 
            this.panelStoredImages.AutoScroll = true;
            this.panelStoredImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStoredImages.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelStoredImages.Location = new System.Drawing.Point(4, 24);
            this.panelStoredImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelStoredImages.Name = "panelStoredImages";
            this.panelStoredImages.Size = new System.Drawing.Size(308, 816);
            this.panelStoredImages.TabIndex = 0;
            // 
            // butRunDynamics
            // 
            this.butRunDynamics.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butRunDynamics.Enabled = false;
            this.butRunDynamics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRunDynamics.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRunDynamics.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butRunDynamics.Location = new System.Drawing.Point(500, 240);
            this.butRunDynamics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butRunDynamics.Name = "butRunDynamics";
            this.butRunDynamics.Size = new System.Drawing.Size(416, 47);
            this.butRunDynamics.TabIndex = 4;
            this.butRunDynamics.Text = "Run network dynamics";
            this.butRunDynamics.UseVisualStyleBackColor = false;
            this.butRunDynamics.Click += new System.EventHandler(this.RunDynamicsBut_Click);
            // 
            // gbNNProperties
            // 
            this.gbNNProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbNNProperties.Controls.Add(this.label5);
            this.gbNNProperties.Controls.Add(this.lblNNSize);
            this.gbNNProperties.Controls.Add(this.lblNumberOfPatterns);
            this.gbNNProperties.Controls.Add(this.lblEnergy);
            this.gbNNProperties.Controls.Add(this.lblStaticEnergy);
            this.gbNNProperties.Controls.Add(this.lblStaticSizeOfNN);
            this.gbNNProperties.Controls.Add(this.lblStaticNumberOfPatterns);
            this.gbNNProperties.Location = new System.Drawing.Point(515, 417);
            this.gbNNProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNNProperties.Name = "gbNNProperties";
            this.gbNNProperties.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNNProperties.Size = new System.Drawing.Size(381, 232);
            this.gbNNProperties.TabIndex = 5;
            this.gbNNProperties.TabStop = false;
            this.gbNNProperties.Text = "Properties of Neural Network";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // lblNNSize
            // 
            this.lblNNSize.AutoSize = true;
            this.lblNNSize.Location = new System.Drawing.Point(202, 40);
            this.lblNNSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNNSize.Name = "lblNNSize";
            this.lblNNSize.Size = new System.Drawing.Size(0, 20);
            this.lblNNSize.TabIndex = 2;
            // 
            // lblNumberOfPatterns
            // 
            this.lblNumberOfPatterns.AutoSize = true;
            this.lblNumberOfPatterns.Location = new System.Drawing.Point(208, 74);
            this.lblNumberOfPatterns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfPatterns.Name = "lblNumberOfPatterns";
            this.lblNumberOfPatterns.Size = new System.Drawing.Size(0, 20);
            this.lblNumberOfPatterns.TabIndex = 2;
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(208, 129);
            this.lblEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(0, 20);
            this.lblEnergy.TabIndex = 2;
            // 
            // lblStaticEnergy
            // 
            this.lblStaticEnergy.AutoSize = true;
            this.lblStaticEnergy.Location = new System.Drawing.Point(16, 131);
            this.lblStaticEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticEnergy.Name = "lblStaticEnergy";
            this.lblStaticEnergy.Size = new System.Drawing.Size(179, 20);
            this.lblStaticEnergy.TabIndex = 1;
            this.lblStaticEnergy.Text = "Current value of Energy:";
            // 
            // lblStaticSizeOfNN
            // 
            this.lblStaticSizeOfNN.AutoSize = true;
            this.lblStaticSizeOfNN.Location = new System.Drawing.Point(15, 40);
            this.lblStaticSizeOfNN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticSizeOfNN.Name = "lblStaticSizeOfNN";
            this.lblStaticSizeOfNN.Size = new System.Drawing.Size(174, 20);
            this.lblStaticSizeOfNN.TabIndex = 0;
            this.lblStaticSizeOfNN.Text = "Size of Neural Network:";
            // 
            // lblStaticNumberOfPatterns
            // 
            this.lblStaticNumberOfPatterns.AutoSize = true;
            this.lblStaticNumberOfPatterns.Location = new System.Drawing.Point(15, 74);
            this.lblStaticNumberOfPatterns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticNumberOfPatterns.Name = "lblStaticNumberOfPatterns";
            this.lblStaticNumberOfPatterns.Size = new System.Drawing.Size(150, 20);
            this.lblStaticNumberOfPatterns.TabIndex = 0;
            this.lblStaticNumberOfPatterns.Text = "Number of patterns:";
            // 
            // gbNNCurrentState
            // 
            this.gbNNCurrentState.Controls.Add(this.imNNState);
            this.gbNNCurrentState.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbNNCurrentState.Location = new System.Drawing.Point(3, 24);
            this.gbNNCurrentState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNNCurrentState.Name = "gbNNCurrentState";
            this.gbNNCurrentState.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNNCurrentState.Size = new System.Drawing.Size(312, 816);
            this.gbNNCurrentState.TabIndex = 5;
            this.gbNNCurrentState.TabStop = false;
            this.gbNNCurrentState.Text = "Current State of NN";
            // 
            // imNNState
            // 
            this.imNNState.ImageToMagnify = ((System.Drawing.Image)(resources.GetObject("imNNState.ImageToMagnify")));
            this.imNNState.Location = new System.Drawing.Point(27, 23);
            this.imNNState.MagnificationCoefficient = 20;
            this.imNNState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imNNState.Name = "imNNState";
            this.imNNState.Size = new System.Drawing.Size(200, 200);
            this.imNNState.TabIndex = 0;
            this.imNNState.Text = "imNNState";
            this.imNNState.Visible = false;
            // 
            // gbPatternsInNN
            // 
            this.gbPatternsInNN.Controls.Add(this.panelStoredImages);
            this.gbPatternsInNN.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPatternsInNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPatternsInNN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPatternsInNN.Location = new System.Drawing.Point(1073, 0);
            this.gbPatternsInNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPatternsInNN.Name = "gbPatternsInNN";
            this.gbPatternsInNN.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPatternsInNN.Size = new System.Drawing.Size(316, 845);
            this.gbPatternsInNN.TabIndex = 0;
            this.gbPatternsInNN.TabStop = false;
            this.gbPatternsInNN.Text = "Patterns in NN";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(415, 788);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suraj Fehintola (CSC831 Assignment)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1389, 845);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbNNCurrentState);
            this.Controls.Add(this.gbNNProperties);
            this.Controls.Add(this.butRunDynamics);
            this.Controls.Add(this.butAddPattern);
            this.Controls.Add(this.butCreateNN);
            this.Controls.Add(this.gbPatternsInNN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopfield neural network usage Example";
            this.Load += new System.EventHandler(this.HopfieldRecognizerMainForm_Load);
            this.gbNNProperties.ResumeLayout(false);
            this.gbNNProperties.PerformLayout();
            this.gbNNCurrentState.ResumeLayout(false);
            this.gbPatternsInNN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCreateNN;
        private System.Windows.Forms.Button butAddPattern;
        private System.Windows.Forms.Panel panelStoredImages;
        private System.Windows.Forms.Button butRunDynamics;
        private System.Windows.Forms.GroupBox gbNNProperties;
        private System.Windows.Forms.GroupBox gbNNCurrentState;
        private System.Windows.Forms.OpenFileDialog ofd;
        private ImageMagnifier.ImageMagnifier imNNState;
        private System.Windows.Forms.Label lblStaticSizeOfNN;
        private System.Windows.Forms.Label lblStaticNumberOfPatterns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNNSize;
        private System.Windows.Forms.Label lblNumberOfPatterns;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblStaticEnergy;
        private System.Windows.Forms.GroupBox gbPatternsInNN;
        private System.Windows.Forms.Label label1;
    }
}