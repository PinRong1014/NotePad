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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listUndo = new System.Windows.Forms.ListBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntOpen
            // 
            this.bntOpen.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntOpen.Location = new System.Drawing.Point(853, 39);
            this.bntOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(209, 33);
            this.bntOpen.TabIndex = 0;
            this.bntOpen.Text = "開啟檔案";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 39);
            this.rtbText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(835, 498);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(853, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "存檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listUndo
            // 
            this.listUndo.FormattingEnabled = true;
            this.listUndo.ItemHeight = 15;
            this.listUndo.Location = new System.Drawing.Point(853, 188);
            this.listUndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUndo.Name = "listUndo";
            this.listUndo.Size = new System.Drawing.Size(209, 349);
            this.listUndo.TabIndex = 4;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnUndo.Location = new System.Drawing.Point(853, 113);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(209, 33);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "復原上一步";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnRedo.Location = new System.Drawing.Point(853, 150);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(209, 33);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.Text = "重作下一步";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(282, 23);
            this.comboBoxFont.TabIndex = 7;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(406, 12);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(100, 23);
            this.comboBoxStyle.TabIndex = 8;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(300, 12);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(100, 23);
            this.comboBoxSize.TabIndex = 9;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1075, 548);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.listUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.bntOpen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listUndo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxSize;
    }
}

