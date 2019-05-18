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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node5");
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxCSharpBenchmark = new System.Windows.Forms.CheckBox();
            this.checkBoxPythonBenchmark = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDelTempFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxGenerateCharts = new System.Windows.Forms.CheckBox();
            this.progressBarBenchmark = new System.Windows.Forms.ProgressBar();
            this.treeViewCharts = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(203, 358);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 42);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // checkBoxCSharpBenchmark
            // 
            this.checkBoxCSharpBenchmark.AutoSize = true;
            this.checkBoxCSharpBenchmark.Checked = true;
            this.checkBoxCSharpBenchmark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCSharpBenchmark.Location = new System.Drawing.Point(50, 70);
            this.checkBoxCSharpBenchmark.Name = "checkBoxCSharpBenchmark";
            this.checkBoxCSharpBenchmark.Size = new System.Drawing.Size(97, 17);
            this.checkBoxCSharpBenchmark.TabIndex = 1;
            this.checkBoxCSharpBenchmark.Text = "C# Benchmark";
            this.checkBoxCSharpBenchmark.UseVisualStyleBackColor = true;
            // 
            // checkBoxPythonBenchmark
            // 
            this.checkBoxPythonBenchmark.AutoSize = true;
            this.checkBoxPythonBenchmark.Checked = true;
            this.checkBoxPythonBenchmark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPythonBenchmark.Location = new System.Drawing.Point(50, 108);
            this.checkBoxPythonBenchmark.Name = "checkBoxPythonBenchmark";
            this.checkBoxPythonBenchmark.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPythonBenchmark.TabIndex = 2;
            this.checkBoxPythonBenchmark.Text = "Python Benchmark";
            this.checkBoxPythonBenchmark.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benchmark Options";
            // 
            // checkBoxDelTempFiles
            // 
            this.checkBoxDelTempFiles.AutoSize = true;
            this.checkBoxDelTempFiles.Checked = true;
            this.checkBoxDelTempFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelTempFiles.Location = new System.Drawing.Point(50, 148);
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
            this.checkBoxGenerateCharts.Location = new System.Drawing.Point(326, 34);
            this.checkBoxGenerateCharts.Name = "checkBoxGenerateCharts";
            this.checkBoxGenerateCharts.Size = new System.Drawing.Size(103, 17);
            this.checkBoxGenerateCharts.TabIndex = 5;
            this.checkBoxGenerateCharts.Text = "Generate Charts";
            this.checkBoxGenerateCharts.UseVisualStyleBackColor = true;
            // 
            // progressBarBenchmark
            // 
            this.progressBarBenchmark.Location = new System.Drawing.Point(309, 377);
            this.progressBarBenchmark.Name = "progressBarBenchmark";
            this.progressBarBenchmark.Size = new System.Drawing.Size(100, 23);
            this.progressBarBenchmark.TabIndex = 6;
            // 
            // treeViewCharts
            // 
            this.treeViewCharts.CheckBoxes = true;
            this.treeViewCharts.Location = new System.Drawing.Point(50, 217);
            this.treeViewCharts.Name = "treeViewCharts";
            treeNode1.Checked = true;
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Checked = true;
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Node5";
            this.treeViewCharts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewCharts.Size = new System.Drawing.Size(170, 104);
            this.treeViewCharts.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.treeViewCharts);
            this.Controls.Add(this.progressBarBenchmark);
            this.Controls.Add(this.checkBoxGenerateCharts);
            this.Controls.Add(this.checkBoxDelTempFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPythonBenchmark);
            this.Controls.Add(this.checkBoxCSharpBenchmark);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Compression Benchmark";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxCSharpBenchmark;
        private System.Windows.Forms.CheckBox checkBoxPythonBenchmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDelTempFiles;
        private System.Windows.Forms.CheckBox checkBoxGenerateCharts;
        private System.Windows.Forms.ProgressBar progressBarBenchmark;
        private System.Windows.Forms.TreeView treeViewCharts;
    }
}

