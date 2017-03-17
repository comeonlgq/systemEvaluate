namespace systemWindows
{
    partial class AllMethodMessage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.focastMethodData = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forecastMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseDo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.表3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new systemWindows.Database1DataSet();
            this.gotoNext = new System.Windows.Forms.Button();
            this.turnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.表3TableAdapter = new systemWindows.Database1DataSetTableAdapters.表3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.focastMethodData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.表3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // focastMethodData
            // 
            this.focastMethodData.AllowUserToAddRows = false;
            this.focastMethodData.AllowUserToDeleteRows = false;
            this.focastMethodData.BackgroundColor = System.Drawing.Color.Lavender;
            this.focastMethodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.focastMethodData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.forecastMethod,
            this.methodCount,
            this.chooseDo});
            this.focastMethodData.Location = new System.Drawing.Point(28, 466);
            this.focastMethodData.Margin = new System.Windows.Forms.Padding(5);
            this.focastMethodData.MultiSelect = false;
            this.focastMethodData.Name = "focastMethodData";
            this.focastMethodData.RowHeadersWidth = 4;
            this.focastMethodData.RowTemplate.Height = 23;
            this.focastMethodData.Size = new System.Drawing.Size(1210, 150);
            this.focastMethodData.TabIndex = 1;
            this.focastMethodData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.focastMethodData_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "序号";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // forecastMethod
            // 
            this.forecastMethod.FillWeight = 110F;
            this.forecastMethod.HeaderText = "预测方法";
            this.forecastMethod.MinimumWidth = 20;
            this.forecastMethod.Name = "forecastMethod";
            this.forecastMethod.Width = 110;
            // 
            // methodCount
            // 
            this.methodCount.FillWeight = 900F;
            this.methodCount.HeaderText = "方法要点";
            this.methodCount.MaxInputLength = 3276700;
            this.methodCount.Name = "methodCount";
            this.methodCount.Width = 900;
            // 
            // chooseDo
            // 
            this.chooseDo.FillWeight = 110F;
            this.chooseDo.HeaderText = "选择操作";
            this.chooseDo.Name = "chooseDo";
            this.chooseDo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chooseDo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chooseDo.Width = 110;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1});
            this.dataGridView1.DataSource = this.表3BindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 325);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "序号";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "评价方法";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.FillWeight = 110F;
            this.dataGridViewTextBoxColumn2.HeaderText = "评价方法";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "方法要点";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.FillWeight = 900F;
            this.dataGridViewTextBoxColumn3.HeaderText = "方法要点";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 900;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "选择操作";
            this.Column1.FillWeight = 108F;
            this.Column1.HeaderText = "选择操作";
            this.Column1.Name = "Column1";
            this.Column1.Width = 108;
            // 
            // 表3BindingSource
            // 
            this.表3BindingSource.DataMember = "表3";
            this.表3BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gotoNext
            // 
            this.gotoNext.Location = new System.Drawing.Point(297, 624);
            this.gotoNext.Name = "gotoNext";
            this.gotoNext.Size = new System.Drawing.Size(131, 36);
            this.gotoNext.TabIndex = 5;
            this.gotoNext.Text = "下一步";
            this.gotoNext.UseVisualStyleBackColor = true;
            this.gotoNext.Click += new System.EventHandler(this.gotoNext_Click);
            // 
            // turnBack
            // 
            this.turnBack.Location = new System.Drawing.Point(896, 624);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(118, 36);
            this.turnBack.TabIndex = 6;
            this.turnBack.Text = "返回";
            this.turnBack.UseVisualStyleBackColor = true;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(360, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "国际投资环境评价与预测子系统之评价方法";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(360, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "国际投资环境评价与预测子系统之预测方法";
            // 
            // 表3TableAdapter
            // 
            this.表3TableAdapter.ClearBeforeFill = true;
            // 
            // AllMethodMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turnBack);
            this.Controls.Add(this.gotoNext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.focastMethodData);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AllMethodMessage";
            this.Text = "国际投资环境评价与预测子系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllMethodMessage_FormClosed);
            this.Load += new System.EventHandler(this.AllMethodMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.focastMethodData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.表3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView focastMethodData;
        private System.Windows.Forms.DataGridView dataGridView1;
      
        
        private System.Windows.Forms.Button gotoNext;
        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn forecastMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chooseDo;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource 表3BindingSource;
        private Database1DataSetTableAdapters.表3TableAdapter 表3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;



    }
}