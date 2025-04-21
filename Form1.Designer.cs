namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bntOpen = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bntOpen
            // 
            this.bntOpen.Location = new System.Drawing.Point(12, 12);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(118, 44);
            this.bntOpen.TabIndex = 0;
            this.bntOpen.Text = "開啟檔案";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 62);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(1051, 474);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "存檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 548);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.bntOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

