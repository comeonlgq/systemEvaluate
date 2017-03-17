namespace systemWindows
{
    partial class InvestObstacleForm
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
            this.awayInvestObstacle = new System.Windows.Forms.Button();
            this.findInvestObstacleSource = new System.Windows.Forms.Button();
            this.saveInvestObstacle = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(294, 625);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(244, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = ": ";
            // 
            // awayInvestObstacle
            // 
            this.awayInvestObstacle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.awayInvestObstacle.Location = new System.Drawing.Point(1053, 623);
            this.awayInvestObstacle.Name = "awayInvestObstacle";
            this.awayInvestObstacle.Size = new System.Drawing.Size(102, 38);
            this.awayInvestObstacle.TabIndex = 21;
            this.awayInvestObstacle.Text = "返回";
            this.awayInvestObstacle.UseVisualStyleBackColor = true;
            this.awayInvestObstacle.Click += new System.EventHandler(this.awayInvestObstacle_Click);
            // 
            // findInvestObstacleSource
            // 
            this.findInvestObstacleSource.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findInvestObstacleSource.Location = new System.Drawing.Point(817, 622);
            this.findInvestObstacleSource.Name = "findInvestObstacleSource";
            this.findInvestObstacleSource.Size = new System.Drawing.Size(149, 43);
            this.findInvestObstacleSource.TabIndex = 20;
            this.findInvestObstacleSource.Text = "查看数据源";
            this.findInvestObstacleSource.UseVisualStyleBackColor = true;
            this.findInvestObstacleSource.Click += new System.EventHandler(this.findInvestObstacleSource_Click);
            // 
            // saveInvestObstacle
            // 
            this.saveInvestObstacle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveInvestObstacle.Location = new System.Drawing.Point(632, 623);
            this.saveInvestObstacle.Name = "saveInvestObstacle";
            this.saveInvestObstacle.Size = new System.Drawing.Size(101, 42);
            this.saveInvestObstacle.TabIndex = 19;
            this.saveInvestObstacle.Text = "保存";
            this.saveInvestObstacle.UseVisualStyleBackColor = true;
            this.saveInvestObstacle.Click += new System.EventHandler(this.saveInvestObstacle_Click);
            // 
            // totalCount
            // 
            this.totalCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalCount.Location = new System.Drawing.Point(118, 618);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(119, 38);
            this.totalCount.TabIndex = 18;
            this.totalCount.Text = "总分计算";
            this.totalCount.UseVisualStyleBackColor = true;
            // 
            // computerCount
            // 
            this.computerCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.computerCount.Location = new System.Drawing.Point(835, 17);
            this.computerCount.Name = "computerCount";
            this.computerCount.Size = new System.Drawing.Size(131, 39);
            this.computerCount.TabIndex = 17;
            this.computerCount.Text = "智能计算";
            this.computerCount.UseVisualStyleBackColor = true;
            this.computerCount.Click += new System.EventHandler(this.computerCount_Click);
            // 
            // manChoose
            // 
            this.manChoose.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manChoose.Location = new System.Drawing.Point(623, 17);
            this.manChoose.Name = "manChoose";
            this.manChoose.Size = new System.Drawing.Size(127, 39);
            this.manChoose.TabIndex = 16;
            this.manChoose.Text = "人工选择";
            this.manChoose.UseVisualStyleBackColor = true;
            this.manChoose.Click += new System.EventHandler(this.manChoose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(263, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "投资障碍分析法";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(96, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "方法名称 ： ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(132, 141);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(985, 406);
            this.dataGridView1.TabIndex = 13;
            // 
            // InvestObstacleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.awayInvestObstacle);
            this.Controls.Add(this.findInvestObstacleSource);
            this.Controls.Add(this.saveInvestObstacle);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.computerCount);
            this.Controls.Add(this.manChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InvestObstacleForm";
            this.Text = "国际资产投资与预测子系统";
            this.Load += new System.EventHandler(this.InvestObstacleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button awayInvestObstacle;
        private System.Windows.Forms.Button findInvestObstacleSource;
        private System.Windows.Forms.Button saveInvestObstacle;
        private System.Windows.Forms.Button totalCount;
        private System.Windows.Forms.Button computerCount;
        private System.Windows.Forms.Button manChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}