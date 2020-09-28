namespace L1_WinFormCalculator
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
            this.leftOperandText = new System.Windows.Forms.TextBox();
            this.rightOperandText = new System.Windows.Forms.TextBox();
            this.leftOperandLabel = new System.Windows.Forms.Label();
            this.myOperatorLabel = new System.Windows.Forms.Label();
            this.myOperatorCombobox = new System.Windows.Forms.ComboBox();
            this.rightOperandLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftOperandText
            // 
            this.leftOperandText.Location = new System.Drawing.Point(12, 58);
            this.leftOperandText.Name = "leftOperandText";
            this.leftOperandText.Size = new System.Drawing.Size(100, 25);
            this.leftOperandText.TabIndex = 0;
            // 
            // rightOperandText
            // 
            this.rightOperandText.Location = new System.Drawing.Point(294, 58);
            this.rightOperandText.Name = "rightOperandText";
            this.rightOperandText.Size = new System.Drawing.Size(100, 25);
            this.rightOperandText.TabIndex = 1;
            // 
            // leftOperandLabel
            // 
            this.leftOperandLabel.AutoSize = true;
            this.leftOperandLabel.Location = new System.Drawing.Point(27, 27);
            this.leftOperandLabel.Name = "leftOperandLabel";
            this.leftOperandLabel.Size = new System.Drawing.Size(67, 15);
            this.leftOperandLabel.TabIndex = 2;
            this.leftOperandLabel.Text = "左操作数";
            // 
            // myOperatorLabel
            // 
            this.myOperatorLabel.AutoSize = true;
            this.myOperatorLabel.Location = new System.Drawing.Point(175, 27);
            this.myOperatorLabel.Name = "myOperatorLabel";
            this.myOperatorLabel.Size = new System.Drawing.Size(52, 15);
            this.myOperatorLabel.TabIndex = 3;
            this.myOperatorLabel.Text = "操作符";
            // 
            // myOperatorCombobox
            // 
            this.myOperatorCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myOperatorCombobox.FormattingEnabled = true;
            this.myOperatorCombobox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.myOperatorCombobox.Location = new System.Drawing.Point(139, 58);
            this.myOperatorCombobox.Name = "myOperatorCombobox";
            this.myOperatorCombobox.Size = new System.Drawing.Size(121, 23);
            this.myOperatorCombobox.TabIndex = 4;
            this.myOperatorCombobox.SelectedIndex = 0;
            // 
            // rightOperandLabel
            // 
            this.rightOperandLabel.AutoSize = true;
            this.rightOperandLabel.Location = new System.Drawing.Point(312, 27);
            this.rightOperandLabel.Name = "rightOperandLabel";
            this.rightOperandLabel.Size = new System.Drawing.Size(67, 15);
            this.rightOperandLabel.TabIndex = 5;
            this.rightOperandLabel.Text = "右操作数";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(439, 60);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "=";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(559, 61);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(100, 25);
            this.resultText.TabIndex = 7;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(580, 26);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 15);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 400);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.rightOperandLabel);
            this.Controls.Add(this.myOperatorCombobox);
            this.Controls.Add(this.myOperatorLabel);
            this.Controls.Add(this.leftOperandLabel);
            this.Controls.Add(this.rightOperandText);
            this.Controls.Add(this.leftOperandText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox leftOperandText;
        private System.Windows.Forms.TextBox rightOperandText;
        private System.Windows.Forms.Label leftOperandLabel;
        private System.Windows.Forms.Label myOperatorLabel;
        private System.Windows.Forms.ComboBox myOperatorCombobox;
        private System.Windows.Forms.Label rightOperandLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label resultLabel;
    }
}

