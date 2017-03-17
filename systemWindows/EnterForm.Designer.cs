namespace systemWindows
{
    partial class denglu
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.systemName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userSecret = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwdText = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.BackColor = System.Drawing.Color.Lavender;
            this.systemName.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.systemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.systemName.Location = new System.Drawing.Point(262, 168);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(700, 64);
            this.systemName.TabIndex = 1;
            this.systemName.Text = "国际投资环境评价与预测子系统";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userName.Location = new System.Drawing.Point(442, 279);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(121, 39);
            this.userName.TabIndex = 2;
            this.userName.Text = "用户名 :";
            // 
            // userSecret
            // 
            this.userSecret.AutoSize = true;
            this.userSecret.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userSecret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userSecret.Location = new System.Drawing.Point(453, 367);
            this.userSecret.Name = "userSecret";
            this.userSecret.Size = new System.Drawing.Size(110, 39);
            this.userSecret.TabIndex = 3;
            this.userSecret.Text = "密  码 :";
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.userNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameText.Location = new System.Drawing.Point(609, 282);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(231, 37);
            this.userNameText.TabIndex = 4;
            // 
            // passwdText
            // 
            this.passwdText.BackColor = System.Drawing.SystemColors.Window;
            this.passwdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdText.Location = new System.Drawing.Point(609, 370);
            this.passwdText.Name = "passwdText";
            this.passwdText.Size = new System.Drawing.Size(231, 37);
            this.passwdText.TabIndex = 5;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enterButton.Location = new System.Drawing.Point(318, 481);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(179, 43);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "进入系统";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitButton.Location = new System.Drawing.Point(764, 481);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(179, 43);
            this.quitButton.TabIndex = 8;
            this.quitButton.Text = "退出系统";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click_1);
            // 
            // denglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwdText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.userSecret);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.systemName);
            this.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "denglu";
            this.Text = "国际投资环境评价与预测子系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userSecret;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwdText;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button quitButton;
    }
}

