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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Pequena");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Grande");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("GZip", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Pequena");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Grande");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("BZip2", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Compression", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("GZip");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("BZip2");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Decompression", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxCSharpBenchmark = new System.Windows.Forms.CheckBox();
            this.checkBoxPythonBenchmark = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDelTempFiles = new System.Windows.Forms.CheckBox();
            this.progressBarBenchmark = new System.Windows.Forms.ProgressBar();
            this.treeViewChartList = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(210, 299);
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
            // progressBarBenchmark
            // 
            this.progressBarBenchmark.Location = new System.Drawing.Point(326, 318);
            this.progressBarBenchmark.Name = "progressBarBenchmark";
            this.progressBarBenchmark.Size = new System.Drawing.Size(100, 23);
            this.progressBarBenchmark.TabIndex = 6;
            // 
            // treeViewChartList
            // 
            this.treeViewChartList.Location = new System.Drawing.Point(269, 64);
            this.treeViewChartList.Name = "treeViewChartList";
            treeNode13.Name = "NodeComGzipPequena";
            treeNode13.Text = "Pequena";
            treeNode14.Name = "NodeComGzipMedia";
            treeNode14.Text = "Media";
            treeNode15.Name = "NodeComGzipGrande";
            treeNode15.Text = "Grande";
            treeNode16.Name = "NodeComGzip";
            treeNode16.Text = "GZip";
            treeNode17.Name = "NodeComBzip2Pequena";
            treeNode17.Text = "Pequena";
            treeNode18.Name = "NodeComBzip2Media";
            treeNode18.Text = "Media";
            treeNode19.Name = "NodeComBzip2Grande";
            treeNode19.Text = "Grande";
            treeNode20.Name = "NodeComBzip2";
            treeNode20.Text = "BZip2";
            treeNode21.Name = "NodeCom";
            treeNode21.Text = "Compression";
            treeNode22.Name = "NodeDecGzip";
            treeNode22.Text = "GZip";
            treeNode23.Name = "NodeDecBzip2";
            treeNode23.Text = "BZip2";
            treeNode24.Name = "NodeDec";
            treeNode24.Text = "Decompression";
            this.treeViewChartList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24});
            this.treeViewChartList.Size = new System.Drawing.Size(187, 184);
            this.treeViewChartList.TabIndex = 7;
            this.treeViewChartList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewChartList_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Progress Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chart List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewChartList);
            this.Controls.Add(this.progressBarBenchmark);
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
        private System.Windows.Forms.ProgressBar progressBarBenchmark;
        private System.Windows.Forms.TreeView treeViewChartList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

