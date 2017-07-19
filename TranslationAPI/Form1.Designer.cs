namespace TranslationAPI
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.xiala1 = new System.Windows.Forms.ComboBox();
            this.xiala2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromTxt
            // 
            this.fromTxt.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromTxt.Location = new System.Drawing.Point(23, 183);
            this.fromTxt.Multiline = true;
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(370, 150);
            this.fromTxt.TabIndex = 0;
            this.fromTxt.TextChanged += new System.EventHandler(this.fromTxt_TextChanged);
            this.fromTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fromTxt_KeyDown);
            // 
            // translateBtn
            // 
            this.translateBtn.Location = new System.Drawing.Point(567, 80);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(90, 40);
            this.translateBtn.TabIndex = 1;
            this.translateBtn.Text = "翻译";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // toTxt
            // 
            this.toTxt.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toTxt.Location = new System.Drawing.Point(427, 183);
            this.toTxt.Multiline = true;
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(376, 150);
            this.toTxt.TabIndex = 3;
            this.toTxt.TextChanged += new System.EventHandler(this.toTxt_TextChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(686, 80);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(90, 40);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "人工翻译";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // xiala1
            // 
            this.xiala1.FormattingEnabled = true;
            this.xiala1.Items.AddRange(new object[] {
            "自动检测",
            "英语",
            "中文",
            "日语",
            "德语"});
            this.xiala1.Location = new System.Drawing.Point(72, 100);
            this.xiala1.Name = "xiala1";
            this.xiala1.Size = new System.Drawing.Size(121, 20);
            this.xiala1.TabIndex = 5;
            this.xiala1.Text = "自动检测";
            this.xiala1.SelectedIndexChanged += new System.EventHandler(this.xiala1_SelectedIndexChanged);
            // 
            // xiala2
            // 
            this.xiala2.FormattingEnabled = true;
            this.xiala2.Items.AddRange(new object[] {
            "中文",
            "英语",
            "日语",
            "德语"});
            this.xiala2.Location = new System.Drawing.Point(344, 100);
            this.xiala2.Name = "xiala2";
            this.xiala2.Size = new System.Drawing.Size(121, 20);
            this.xiala2.TabIndex = 6;
            this.xiala2.Text = "中文";
            this.xiala2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::TranslationAPI.Properties.Resources.捕获;
            this.button2.Location = new System.Drawing.Point(364, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 26);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xiala2);
            this.Controls.Add(this.xiala1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.toTxt);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.fromTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "翻译";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox xiala1;
        private System.Windows.Forms.ComboBox xiala2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

