﻿namespace JavaVersionSelector
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.apply_button = new System.Windows.Forms.Button();
            this.reload_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(49, 23);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 0;
            this.apply_button.Text = "適用";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // reload_button
            // 
            this.reload_button.Location = new System.Drawing.Point(154, 23);
            this.reload_button.Name = "reload_button";
            this.reload_button.Size = new System.Drawing.Size(75, 23);
            this.reload_button.TabIndex = 1;
            this.reload_button.Text = "再読み込み";
            this.reload_button.UseVisualStyleBackColor = true;
            this.reload_button.Click += new System.EventHandler(this.ReloadButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 455);
            this.Controls.Add(this.reload_button);
            this.Controls.Add(this.apply_button);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "JavaVersionSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button reload_button;
    }
}

