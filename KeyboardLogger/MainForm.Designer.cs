namespace KeyboardLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loggerTextBox = new System.Windows.Forms.TextBox();
            this.loggerLabel = new System.Windows.Forms.Label();
            this.disabledToggle = new System.Windows.Forms.CheckBox();
            this.loggingToggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loggerTextBox
            // 
            this.loggerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggerTextBox.Enabled = false;
            this.loggerTextBox.Location = new System.Drawing.Point(13, 84);
            this.loggerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loggerTextBox.Multiline = true;
            this.loggerTextBox.Name = "loggerTextBox";
            this.loggerTextBox.Size = new System.Drawing.Size(1174, 391);
            this.loggerTextBox.TabIndex = 0;
            // 
            // loggerLabel
            // 
            this.loggerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggerLabel.Location = new System.Drawing.Point(13, 9);
            this.loggerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggerLabel.Name = "loggerLabel";
            this.loggerLabel.Size = new System.Drawing.Size(1174, 70);
            this.loggerLabel.TabIndex = 1;
            this.loggerLabel.Text = resources.GetString("loggerLabel.Text");
            // 
            // disabledToggle
            // 
            this.disabledToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.disabledToggle.AutoSize = true;
            this.disabledToggle.Checked = true;
            this.disabledToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disabledToggle.Location = new System.Drawing.Point(13, 483);
            this.disabledToggle.Name = "disabledToggle";
            this.disabledToggle.Size = new System.Drawing.Size(89, 25);
            this.disabledToggle.TabIndex = 2;
            this.disabledToggle.TabStop = false;
            this.disabledToggle.Text = "Disabled";
            this.disabledToggle.UseVisualStyleBackColor = true;
            this.disabledToggle.CheckedChanged += new System.EventHandler(this.OnDisabledToggle);
            // 
            // loggingToggle
            // 
            this.loggingToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loggingToggle.AutoSize = true;
            this.loggingToggle.Checked = true;
            this.loggingToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loggingToggle.Location = new System.Drawing.Point(108, 483);
            this.loggingToggle.Name = "loggingToggle";
            this.loggingToggle.Size = new System.Drawing.Size(86, 25);
            this.loggingToggle.TabIndex = 3;
            this.loggingToggle.TabStop = false;
            this.loggingToggle.Text = "Logging";
            this.loggingToggle.UseVisualStyleBackColor = true;
            this.loggingToggle.CheckedChanged += new System.EventHandler(this.OnLoggingToggle);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 518);
            this.Controls.Add(this.loggingToggle);
            this.Controls.Add(this.disabledToggle);
            this.Controls.Add(this.loggerLabel);
            this.Controls.Add(this.loggerTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(713, 220);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyboard Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loggerTextBox;
        private System.Windows.Forms.Label loggerLabel;
        private System.Windows.Forms.CheckBox disabledToggle;
        private System.Windows.Forms.CheckBox loggingToggle;
    }
}

