namespace TestRegistry
{
    partial class FormMain
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
            this.labelKeyName = new System.Windows.Forms.Label();
            this.labelKeyExists = new System.Windows.Forms.Label();
            this.buttonGetValue = new System.Windows.Forms.Button();
            this.buttonSetValue = new System.Windows.Forms.Button();
            this.numericUpDownKeyValueData = new System.Windows.Forms.NumericUpDown();
            this.buttonResetKey = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonGetOSInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyValueData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKeyName
            // 
            this.labelKeyName.AutoSize = true;
            this.labelKeyName.Location = new System.Drawing.Point(11, 9);
            this.labelKeyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyName.Name = "labelKeyName";
            this.labelKeyName.Size = new System.Drawing.Size(127, 20);
            this.labelKeyName.TabIndex = 0;
            this.labelKeyName.Text = "Key name: {0}";
            // 
            // labelKeyExists
            // 
            this.labelKeyExists.AutoSize = true;
            this.labelKeyExists.Location = new System.Drawing.Point(11, 41);
            this.labelKeyExists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyExists.Name = "labelKeyExists";
            this.labelKeyExists.Size = new System.Drawing.Size(132, 20);
            this.labelKeyExists.TabIndex = 1;
            this.labelKeyExists.Text = "Key exists: {0}";
            // 
            // buttonGetValue
            // 
            this.buttonGetValue.Location = new System.Drawing.Point(15, 77);
            this.buttonGetValue.Name = "buttonGetValue";
            this.buttonGetValue.Size = new System.Drawing.Size(191, 36);
            this.buttonGetValue.TabIndex = 2;
            this.buttonGetValue.Text = "Get key value data";
            this.buttonGetValue.UseVisualStyleBackColor = true;
            this.buttonGetValue.Click += new System.EventHandler(this.buttonGetValue_Click);
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(15, 119);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(191, 36);
            this.buttonSetValue.TabIndex = 3;
            this.buttonSetValue.Text = "Set key value data";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            this.buttonSetValue.Click += new System.EventHandler(this.buttonSetValue_Click);
            // 
            // numericUpDownKeyValueData
            // 
            this.numericUpDownKeyValueData.Location = new System.Drawing.Point(227, 125);
            this.numericUpDownKeyValueData.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKeyValueData.Name = "numericUpDownKeyValueData";
            this.numericUpDownKeyValueData.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownKeyValueData.TabIndex = 4;
            // 
            // buttonResetKey
            // 
            this.buttonResetKey.Location = new System.Drawing.Point(15, 161);
            this.buttonResetKey.Name = "buttonResetKey";
            this.buttonResetKey.Size = new System.Drawing.Size(191, 36);
            this.buttonResetKey.TabIndex = 5;
            this.buttonResetKey.Text = "Reset key";
            this.buttonResetKey.UseVisualStyleBackColor = true;
            this.buttonResetKey.Click += new System.EventHandler(this.buttonResetKey_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1212, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabelMain.Text = "<>";
            // 
            // buttonGetOSInfo
            // 
            this.buttonGetOSInfo.Location = new System.Drawing.Point(373, 77);
            this.buttonGetOSInfo.Name = "buttonGetOSInfo";
            this.buttonGetOSInfo.Size = new System.Drawing.Size(270, 75);
            this.buttonGetOSInfo.TabIndex = 7;
            this.buttonGetOSInfo.Text = "Get Operating System info";
            this.buttonGetOSInfo.UseVisualStyleBackColor = true;
            this.buttonGetOSInfo.Click += new System.EventHandler(this.buttonGetOSInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 263);
            this.Controls.Add(this.buttonGetOSInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonResetKey);
            this.Controls.Add(this.numericUpDownKeyValueData);
            this.Controls.Add(this.buttonSetValue);
            this.Controls.Add(this.buttonGetValue);
            this.Controls.Add(this.labelKeyExists);
            this.Controls.Add(this.labelKeyName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "TestRegistry";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyValueData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeyName;
        private System.Windows.Forms.Label labelKeyExists;
        private System.Windows.Forms.Button buttonGetValue;
        private System.Windows.Forms.Button buttonSetValue;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyValueData;
        private System.Windows.Forms.Button buttonResetKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.Button buttonGetOSInfo;
    }
}

