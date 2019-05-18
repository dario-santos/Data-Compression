namespace Data_Compression_UI
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxCSCompression = new System.Windows.Forms.CheckBox();
            this.checkBoxPythonCompression = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDelTempFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxGenerateCharts = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(205, 377);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 42);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // checkBoxCSCompression
            // 
            this.checkBoxCSCompression.AutoSize = true;
            this.checkBoxCSCompression.Checked = true;
            this.checkBoxCSCompression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCSCompression.Location = new System.Drawing.Point(77, 141);
            this.checkBoxCSCompression.Name = "checkBoxCSCompression";
            this.checkBoxCSCompression.Size = new System.Drawing.Size(110, 17);
            this.checkBoxCSCompression.TabIndex = 1;
            this.checkBoxCSCompression.Text = "Compress with c#";
            this.checkBoxCSCompression.UseVisualStyleBackColor = true;
            // 
            // checkBoxPythonCompression
            // 
            this.checkBoxPythonCompression.AutoSize = true;
            this.checkBoxPythonCompression.Checked = true;
            this.checkBoxPythonCompression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPythonCompression.Location = new System.Drawing.Point(77, 173);
            this.checkBoxPythonCompression.Name = "checkBoxPythonCompression";
            this.checkBoxPythonCompression.Size = new System.Drawing.Size(129, 17);
            this.checkBoxPythonCompression.TabIndex = 2;
            this.checkBoxPythonCompression.Text = "Compress with python";
            this.checkBoxPythonCompression.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benchmark options";
            // 
            // checkBoxDelTempFiles
            // 
            this.checkBoxDelTempFiles.AutoSize = true;
            this.checkBoxDelTempFiles.Checked = true;
            this.checkBoxDelTempFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelTempFiles.Location = new System.Drawing.Point(77, 235);
            this.checkBoxDelTempFiles.Name = "checkBoxDelTempFiles";
            this.checkBoxDelTempFiles.Size = new System.Drawing.Size(184, 17);
            this.checkBoxDelTempFiles.TabIndex = 4;
            this.checkBoxDelTempFiles.Text = "Delete temp files after benchmark";
            this.checkBoxDelTempFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxGenerateCharts
            // 
            this.checkBoxGenerateCharts.AutoSize = true;
            this.checkBoxGenerateCharts.Checked = true;
            this.checkBoxGenerateCharts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGenerateCharts.Location = new System.Drawing.Point(77, 268);
            this.checkBoxGenerateCharts.Name = "checkBoxGenerateCharts";
            this.checkBoxGenerateCharts.Size = new System.Drawing.Size(180, 17);
            this.checkBoxGenerateCharts.TabIndex = 5;
            this.checkBoxGenerateCharts.Text = "Generate Chats after benchmark";
            this.checkBoxGenerateCharts.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.checkBoxGenerateCharts);
            this.Controls.Add(this.checkBoxDelTempFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPythonCompression);
            this.Controls.Add(this.checkBoxCSCompression);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxCSCompression;
        private System.Windows.Forms.CheckBox checkBoxPythonCompression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDelTempFiles;
        private System.Windows.Forms.CheckBox checkBoxGenerateCharts;
    }
}

