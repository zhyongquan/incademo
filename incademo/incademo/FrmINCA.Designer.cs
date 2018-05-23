namespace incademo
{
    partial class FrmINCA
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMeasureName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeasureValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalibrationName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalibrationValue = new System.Windows.Forms.TextBox();
            this.btnExperiment = new System.Windows.Forms.Button();
            this.btnGetValue = new System.Windows.Forms.Button();
            this.btnSetValue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(87, 20);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(294, 21);
            this.txtVersion.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExperiment);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INCA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMeasureValue);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMeasureName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 88);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measure";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCalibrationValue);
            this.groupBox4.Controls.Add(this.txtCalibrationName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 86);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calibration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtMeasureName
            // 
            this.txtMeasureName.Location = new System.Drawing.Point(87, 24);
            this.txtMeasureName.Name = "txtMeasureName";
            this.txtMeasureName.Size = new System.Drawing.Size(294, 21);
            this.txtMeasureName.TabIndex = 1;
            this.txtMeasureName.Text = "Input_1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value:";
            // 
            // txtMeasureValue
            // 
            this.txtMeasureValue.Location = new System.Drawing.Point(87, 56);
            this.txtMeasureValue.Name = "txtMeasureValue";
            this.txtMeasureValue.Size = new System.Drawing.Size(294, 21);
            this.txtMeasureValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // txtCalibrationName
            // 
            this.txtCalibrationName.Location = new System.Drawing.Point(87, 20);
            this.txtCalibrationName.Name = "txtCalibrationName";
            this.txtCalibrationName.Size = new System.Drawing.Size(294, 21);
            this.txtCalibrationName.TabIndex = 1;
            this.txtCalibrationName.Text = "DEMO_CONSTANT_1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Value:";
            // 
            // txtCalibrationValue
            // 
            this.txtCalibrationValue.Location = new System.Drawing.Point(87, 52);
            this.txtCalibrationValue.Name = "txtCalibrationValue";
            this.txtCalibrationValue.Size = new System.Drawing.Size(294, 21);
            this.txtCalibrationValue.TabIndex = 3;
            // 
            // btnExperiment
            // 
            this.btnExperiment.Location = new System.Drawing.Point(6, 49);
            this.btnExperiment.Name = "btnExperiment";
            this.btnExperiment.Size = new System.Drawing.Size(75, 23);
            this.btnExperiment.TabIndex = 3;
            this.btnExperiment.Text = "Experiment";
            this.btnExperiment.UseVisualStyleBackColor = true;
            this.btnExperiment.Click += new System.EventHandler(this.btnExperiment_Click);
            // 
            // btnGetValue
            // 
            this.btnGetValue.Location = new System.Drawing.Point(18, 287);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(75, 23);
            this.btnGetValue.TabIndex = 7;
            this.btnGetValue.Text = "GetValue";
            this.btnGetValue.UseVisualStyleBackColor = true;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // btnSetValue
            // 
            this.btnSetValue.Location = new System.Drawing.Point(99, 287);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(75, 23);
            this.btnSetValue.TabIndex = 8;
            this.btnSetValue.Text = "SetValue";
            this.btnSetValue.UseVisualStyleBackColor = true;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // FrmINCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.btnSetValue);
            this.Controls.Add(this.btnGetValue);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmINCA";
            this.Text = "INCA DEMO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMeasureName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeasureValue;
        private System.Windows.Forms.TextBox txtCalibrationValue;
        private System.Windows.Forms.TextBox txtCalibrationName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExperiment;
        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.Button btnSetValue;
    }
}

