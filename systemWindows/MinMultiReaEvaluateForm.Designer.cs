namespace systemWindows
{
    partial class MinMultiReaEvaluateForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.awayMinMultiReason = new System.Windows.Forms.Button();
            this.findMinMultiReasonSource = new System.Windows.Forms.Button();
            this.saveMinMultiReason = new System.Windows.Forms.Button();
            this.totalCount = new System.Windows.Forms.Button();
            this.computerCount = new System.Windows.Forms.Button();
            this.manChoose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(1004, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 31);
            this.textBox1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(915, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = ": ";
            // 
            // awayMinMultiReason
            // 
            this.awayMinMultiReason.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.awayMinMultiReason.Location = new System.Drawing.Point(762, 509);
            this.awayMinMultiReason.Name = "awayMinMultiReason";
            this.awayMinMultiReason.Size = new System.Drawing.Size(403, 38);
            this.awayMinMultiReason.TabIndex = 32;
            this.awayMinMultiReason.Text = "返回";
            this.awayMinMultiReason.UseVisualStyleBackColor = true;
            this.awayMinMultiReason.Click += new System.EventHandler(this.awayMinMultiReason_Click);
            // 
            // findMinMultiReasonSource
            // 
            this.findMinMultiReasonSource.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findMinMultiReasonSource.Location = new System.Drawing.Point(1016, 408);
            this.findMinMultiReasonSource.Name = "findMinMultiReasonSource";
            this.findMinMultiReasonSource.Size = new System.Drawing.Size(149, 43);
            this.findMinMultiReasonSource.TabIndex = 31;
            this.findMinMultiReasonSource.Text = "查看数据源";
            this.findMinMultiReasonSource.UseVisualStyleBackColor = true;
            this.findMinMultiReasonSource.Click += new System.EventHandler(this.findMinMultiReasonSource_Click);
            // 
            // saveMinMultiReason
            // 
            this.saveMinMultiReason.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveMinMultiReason.Location = new System.Drawing.Point(762, 409);
            this.saveMinMultiReason.Name = "saveMinMultiReason";
            this.saveMinMultiReason.Size = new System.Drawing.Size(127, 42);
            this.saveMinMultiReason.TabIndex = 30;
            this.saveMinMultiReason.Text = "保存";
            this.saveMinMultiReason.UseVisualStyleBackColor = true;
            this.saveMinMultiReason.Click += new System.EventHandler(this.saveMinMultiReason_Click);
            // 
            // totalCount
            // 
            this.totalCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalCount.Location = new System.Drawing.Point(762, 261);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(127, 38);
            this.totalCount.TabIndex = 29;
            this.totalCount.Text = "总分计算";
            this.totalCount.UseVisualStyleBackColor = true;
            // 
            // computerCount
            // 
            this.computerCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.computerCount.Location = new System.Drawing.Point(1004, 133);
            this.computerCount.Name = "computerCount";
            this.computerCount.Size = new System.Drawing.Size(131, 39);
            this.computerCount.TabIndex = 28;
            this.computerCount.Text = "智能计算";
            this.computerCount.UseVisualStyleBackColor = true;
            this.computerCount.Click += new System.EventHandler(this.computerCount_Click);
            // 
            // manChoose
            // 
            this.manChoose.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manChoose.Location = new System.Drawing.Point(762, 133);
            this.manChoose.Name = "manChoose";
            this.manChoose.Size = new System.Drawing.Size(127, 39);
            this.manChoose.TabIndex = 27;
            this.manChoose.Text = "人工选择";
            this.manChoose.UseVisualStyleBackColor = true;
            this.manChoose.Click += new System.EventHandler(this.manChoose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(916, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "闵式多因素评估法";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(744, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "方法名称 ： ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(63, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(580, 640);
            this.dataGridView1.TabIndex = 24;
            // 
            // MinMultiReaEvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.awayMinMultiReason);
            this.Controls.Add(this.findMinMultiReasonSource);
            this.Controls.Add(this.saveMinMultiReason);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.computerCount);
            this.Controls.Add(this.manChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MinMultiReaEvaluateForm";
            this.Text = "国际资产投资与预测子系统";
            this.Load += new System.EventHandler(this.MinMultiReaEvaluateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button awayMinMultiReason;
        private System.Windows.Forms.Button findMinMultiReasonSource;
        private System.Windows.Forms.Button saveMinMultiReason;
        private System.Windows.Forms.Button totalCount;
        private System.Windows.Forms.Button computerCount;
        private System.Windows.Forms.Button manChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}