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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pequena");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Grande");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GZip", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pequena");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Grande");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BZip2", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Compression", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("GZip");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("BZip2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Decompression", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
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
            this.buttonStart.Location = new System.Drawing.Point(280, 368);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 52);
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
            this.checkBoxCSharpBenchmark.Location = new System.Drawing.Point(67, 86);
            this.checkBoxCSharpBenchmark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCSharpBenchmark.Name = "checkBoxCSharpBenchmark";
            this.checkBoxCSharpBenchmark.Size = new System.Drawing.Size(122, 21);
            this.checkBoxCSharpBenchmark.TabIndex = 1;
            this.checkBoxCSharpBenchmark.Text = "C# Benchmark";
            this.checkBoxCSharpBenchmark.UseVisualStyleBackColor = true;
            // 
            // checkBoxPythonBenchmark
            // 
            this.checkBoxPythonBenchmark.AutoSize = true;
            this.checkBoxPythonBenchmark.Checked = true;
            this.checkBoxPythonBenchmark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPythonBenchmark.Location = new System.Drawing.Point(67, 133);
            this.checkBoxPythonBenchmark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPythonBenchmark.Name = "checkBoxPythonBenchmark";
            this.checkBoxPythonBenchmark.Size = new System.Drawing.Size(149, 21);
            this.checkBoxPythonBenchmark.TabIndex = 2;
            this.checkBoxPythonBenchmark.Text = "Python Benchmark";
            this.checkBoxPythonBenchmark.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benchmark Options";
            // 
            // checkBoxDelTempFiles
            // 
            this.checkBoxDelTempFiles.AutoSize = true;
            this.checkBoxDelTempFiles.Checked = true;
            this.checkBoxDelTempFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelTempFiles.Location = new System.Drawing.Point(67, 182);
            this.checkBoxDelTempFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDelTempFiles.Name = "checkBoxDelTempFiles";
            this.checkBoxDelTempFiles.Size = new System.Drawing.Size(242, 21);
            this.checkBoxDelTempFiles.TabIndex = 4;
            this.checkBoxDelTempFiles.Text = "Delete temp files after benchmark";
            this.checkBoxDelTempFiles.UseVisualStyleBackColor = true;
            // 
            // progressBarBenchmark
            // 
            this.progressBarBenchmark.Location = new System.Drawing.Point(435, 391);
            this.progressBarBenchmark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarBenchmark.Name = "progressBarBenchmark";
            this.progressBarBenchmark.Size = new System.Drawing.Size(133, 28);
            this.progressBarBenchmark.TabIndex = 6;
            // 
            // treeViewChartList
            // 
            this.treeViewChartList.Location = new System.Drawing.Point(359, 79);
            this.treeViewChartList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewChartList.Name = "treeViewChartList";
            treeNode1.Name = "com_gzip_pequena";
            treeNode1.Text = "Pequena";
            treeNode2.Name = "com_gzip_media";
            treeNode2.Text = "Media";
            treeNode3.Name = "com_gzip_grande";
            treeNode3.Text = "Grande";
            treeNode4.Name = "com_gzip";
            treeNode4.Text = "GZip";
            treeNode5.Name = "com_bzip2_pequena";
            treeNode5.Text = "Pequena";
            treeNode6.Name = "com_bzip2_media";
            treeNode6.Text = "Media";
            treeNode7.Name = "com_bzip2_grande";
            treeNode7.Text = "Grande";
            treeNode8.Name = "com_bzip2";
            treeNode8.Text = "BZip2";
            treeNode9.Name = "com";
            treeNode9.Text = "Compression";
            treeNode10.Name = "dec_gzip";
            treeNode10.Text = "GZip";
            treeNode11.Name = "dec_bzip2";
            treeNode11.Text = "BZip2";
            treeNode12.Name = "dec";
            treeNode12.Text = "Decompression";
            this.treeViewChartList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeViewChartList.Size = new System.Drawing.Size(248, 226);
            this.treeViewChartList.TabIndex = 7;
            this.treeViewChartList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewChartList_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Progress Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chart List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewChartList);
            this.Controls.Add(this.progressBarBenchmark);
            this.Controls.Add(this.checkBoxDelTempFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPythonBenchmark);
            this.Controls.Add(this.checkBoxCSharpBenchmark);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

