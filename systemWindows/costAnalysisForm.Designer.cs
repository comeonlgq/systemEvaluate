namespace systemWindows
{
    partial class costAnalysisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.manChoose = new System.Windows.Forms.Button();
            this.computerCount = new System.Windows.Forms.Button();
            this.totalCount = new System.Windows.Forms.Button();
            this.saveCostAnalysis = new System.Windows.Forms.Button();
            this.findCostAnalysisSource = new System.Windows.Forms.Button();
            this.awayCostAnalysis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(31, 67);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "方法名称 ： ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(253, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "成本分析法";
            // 
            // manChoose
            // 
            this.manChoose.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manChoose.Location = new System.Drawing.Point(613, 22);
            this.manChoose.Name = "manChoose";
            this.manChoose.Size = new System.Drawing.Size(127, 39);
            this.manChoose.TabIndex = 3;
            this.manChoose.Text = "人工选择";
            this.manChoose.UseVisualStyleBackColor = true;
            this.manChoose.Click += new System.EventHandler(this.manChoose_Click);
            // 
            // computerCount
            // 
            this.computerCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.computerCount.Location = new System.Drawing.Point(825, 22);
            this.computerCount.Name = "computerCount";
            this.computerCount.Size = new System.Drawing.Size(131, 39);
            this.computerCount.TabIndex = 4;
            this.computerCount.Text = "智能计算";
            this.computerCount.UseVisualStyleBackColor = true;
            this.computerCount.Click += new System.EventHandler(this.computerCount_Click);
            // 
            // totalCount
            // 
            this.totalCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalCount.Location = new System.Drawing.Point(108, 623);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(119, 38);
            this.totalCount.TabIndex = 7;
            this.totalCount.Text = "总分计算";
            this.totalCount.UseVisualStyleBackColor = true;
            this.totalCount.Click += new System.EventHandler(this.totalCount_Click);
            // 
            // saveCostAnalysis
            // 
            this.saveCostAnalysis.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveCostAnalysis.Location = new System.Drawing.Point(622, 628);
            this.saveCostAnalysis.Name = "saveCostAnalysis";
            this.saveCostAnalysis.Size = new System.Drawing.Size(101, 42);
            this.saveCostAnalysis.TabIndex = 8;
            this.saveCostAnalysis.Text = "保存";
            this.saveCostAnalysis.UseVisualStyleBackColor = true;
            this.saveCostAnalysis.Click += new System.EventHandler(this.saveCostAnalysis_Click);
            // 
            // findCostAnalysisSource
            // 
            this.findCostAnalysisSource.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findCostAnalysisSource.Location = new System.Drawing.Point(807, 627);
            this.findCostAnalysisSource.Name = "findCostAnalysisSource";
            this.findCostAnalysisSource.Size = new System.Drawing.Size(149, 43);
            this.findCostAnalysisSource.TabIndex = 9;
            this.findCostAnalysisSource.Text = "查看数据源";
            this.findCostAnalysisSource.UseVisualStyleBackColor = true;
            this.findCostAnalysisSource.Click += new System.EventHandler(this.findCostAnalysisSource_Click);
            // 
            // awayCostAnalysis
            // 
            this.awayCostAnalysis.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.awayCostAnalysis.Location = new System.Drawing.Point(1043, 628);
            this.awayCostAnalysis.Name = "awayCostAnalysis";
            this.awayCostAnalysis.Size = new System.Drawing.Size(102, 38);
            this.awayCostAnalysis.TabIndex = 10;
            this.awayCostAnalysis.Text = "返回";
            this.awayCostAnalysis.UseVisualStyleBackColor = true;
            this.awayCostAnalysis.Click += new System.EventHandler(this.awayCostAnalysis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(234, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = ": ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(284, 630);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 12;
            // 
            // costAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.awayCostAnalysis);
            this.Controls.Add(this.findCostAnalysisSource);
            this.Controls.Add(this.saveCostAnalysis);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.computerCount);
            this.Controls.Add(this.manChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "costAnalysisForm";
            this.Text = "国际资产投资与预测子系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.costAnalysisForm_FormClosed);
            this.Load += new System.EventHandler(this.ExampleExcelIntoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button manChoose;
        private System.Windows.Forms.Button computerCount;
        private System.Windows.Forms.Button totalCount;
        private System.Windows.Forms.Button saveCostAnalysis;
        private System.Windows.Forms.Button findCostAnalysisSource;
        private System.Windows.Forms.Button awayCostAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}