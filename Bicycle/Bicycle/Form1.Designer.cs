namespace Bicycle
{
    partial class fmBY
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
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.wbmap = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(12, 12);
            this.txtaddr.Multiline = true;
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(191, 25);
            this.txtaddr.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(209, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // wbmap
            // 
            this.wbmap.Location = new System.Drawing.Point(12, 43);
            this.wbmap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbmap.Name = "wbmap";
            this.wbmap.ScrollBarsEnabled = false;
            this.wbmap.Size = new System.Drawing.Size(609, 334);
            this.wbmap.TabIndex = 2;
            // 
            // fmBY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 389);
            this.Controls.Add(this.wbmap);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtaddr);
            this.Name = "fmBY";
            this.Text = "公共自行车";
            this.Load += new System.EventHandler(this.fmBY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.WebBrowser wbmap;
    }
}

