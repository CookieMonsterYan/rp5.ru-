namespace rp5.ru降雨数据提取
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_csvFiles = new System.Windows.Forms.DataGridView();
            this.CsvFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_csvFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_result = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.btn_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_csvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "降雨csv文件";
            // 
            // dgv_csvFiles
            // 
            this.dgv_csvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_csvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CsvFile});
            this.dgv_csvFiles.Location = new System.Drawing.Point(29, 80);
            this.dgv_csvFiles.Name = "dgv_csvFiles";
            this.dgv_csvFiles.RowTemplate.Height = 23;
            this.dgv_csvFiles.Size = new System.Drawing.Size(545, 197);
            this.dgv_csvFiles.TabIndex = 2;
            // 
            // CsvFile
            // 
            this.CsvFile.HeaderText = "csv文件";
            this.CsvFile.Name = "CsvFile";
            this.CsvFile.Width = 500;
            // 
            // btn_csvFiles
            // 
            this.btn_csvFiles.Location = new System.Drawing.Point(111, 38);
            this.btn_csvFiles.Name = "btn_csvFiles";
            this.btn_csvFiles.Size = new System.Drawing.Size(35, 23);
            this.btn_csvFiles.TabIndex = 3;
            this.btn_csvFiles.Text = "...";
            this.btn_csvFiles.UseVisualStyleBackColor = true;
            this.btn_csvFiles.Click += new System.EventHandler(this.btn_csvFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "保存降雨文件";
            // 
            // txtb_result
            // 
            this.txtb_result.Location = new System.Drawing.Point(111, 297);
            this.txtb_result.Name = "txtb_result";
            this.txtb_result.Size = new System.Drawing.Size(390, 21);
            this.txtb_result.TabIndex = 5;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(508, 297);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(35, 23);
            this.btn_result.TabIndex = 6;
            this.btn_result.Text = "...";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(29, 372);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(472, 23);
            this.pb.TabIndex = 7;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(508, 371);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 8;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.txtb_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_csvFiles);
            this.Controls.Add(this.dgv_csvFiles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_csvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_csvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn CsvFile;
        private System.Windows.Forms.Button btn_csvFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_result;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button btn_run;
    }
}

