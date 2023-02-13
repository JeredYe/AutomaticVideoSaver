
namespace AutomaticVideoSaver
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFile = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Preserve = new System.Windows.Forms.RadioButton();
            this.Bilibili = new System.Windows.Forms.RadioButton();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.delete = new System.Windows.Forms.CheckBox();
            this.tOpen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tSave = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(29, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(28, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "一键拷贝所下载的视频";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.Description = "请选择视频所在目录";
            this.openFile.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // saveFile
            // 
            this.saveFile.Description = "请选择存放目录";
            this.saveFile.HelpRequest += new System.EventHandler(this.saveFile_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "检测到 0 个视频";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "注意：重复文件名会默认覆盖";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Preserve
            // 
            this.Preserve.AutoSize = true;
            this.Preserve.Checked = true;
            this.Preserve.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preserve.Location = new System.Drawing.Point(28, 282);
            this.Preserve.Name = "Preserve";
            this.Preserve.Size = new System.Drawing.Size(117, 24);
            this.Preserve.TabIndex = 4;
            this.Preserve.TabStop = true;
            this.Preserve.Text = "保留原文件名";
            this.Preserve.UseVisualStyleBackColor = true;
            // 
            // Bilibili
            // 
            this.Bilibili.AutoSize = true;
            this.Bilibili.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bilibili.Location = new System.Drawing.Point(218, 282);
            this.Bilibili.Name = "Bilibili";
            this.Bilibili.Size = new System.Drawing.Size(161, 24);
            this.Bilibili.TabIndex = 5;
            this.Bilibili.Text = "根据BilibiliWin10端";
            this.Bilibili.UseVisualStyleBackColor = true;
            this.Bilibili.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 355);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(388, 26);
            this.progress.TabIndex = 6;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delete.Location = new System.Drawing.Point(263, 235);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 18);
            this.delete.TabIndex = 7;
            this.delete.Text = "复制后删除文件";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // tOpen
            // 
            this.tOpen.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOpen.Location = new System.Drawing.Point(114, 102);
            this.tOpen.Name = "tOpen";
            this.tOpen.Size = new System.Drawing.Size(205, 25);
            this.tOpen.TabIndex = 8;
            this.tOpen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "视频所在目录:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "视频保存目录:";
            // 
            // tSave
            // 
            this.tSave.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSave.Location = new System.Drawing.Point(114, 137);
            this.tSave.Name = "tSave";
            this.tSave.Size = new System.Drawing.Size(205, 25);
            this.tSave.TabIndex = 10;
            this.tSave.TextChanged += new System.EventHandler(this.tSave_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(325, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 56);
            this.button3.TabIndex = 12;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 393);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tOpen);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.Bilibili);
            this.Controls.Add(this.Preserve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "视频自动收集器ByTangent Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog openFile;
        private System.Windows.Forms.FolderBrowserDialog saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Preserve;
        private System.Windows.Forms.RadioButton Bilibili;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckBox delete;
        private System.Windows.Forms.TextBox tOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tSave;
        private System.Windows.Forms.Button button3;
    }
}

