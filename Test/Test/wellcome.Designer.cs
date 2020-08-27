namespace Test
{
    partial class wellcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wellcome));
            this.hellowText = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelQues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hellowText
            // 
            this.hellowText.AutoSize = true;
            this.hellowText.BackColor = System.Drawing.Color.Lavender;
            this.hellowText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellowText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.hellowText.Location = new System.Drawing.Point(515, 94);
            this.hellowText.Name = "hellowText";
            this.hellowText.Size = new System.Drawing.Size(133, 61);
            this.hellowText.TabIndex = 0;
            this.hellowText.Text = "שלום";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNext.Location = new System.Drawing.Point(312, 313);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(191, 46);
            this.buttonNext.TabIndex = 30;
            this.buttonNext.Text = "התחל מבחן";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelQues
            // 
            this.labelQues.AutoSize = true;
            this.labelQues.BackColor = System.Drawing.Color.Lavender;
            this.labelQues.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQues.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelQues.Location = new System.Drawing.Point(216, 184);
            this.labelQues.Name = "labelQues";
            this.labelQues.Size = new System.Drawing.Size(432, 62);
            this.labelQues.TabIndex = 31;
            this.labelQues.Text = "?מוכן להתחיל במבחן";
            // 
            // wellcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources._31788681;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelQues);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.hellowText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wellcome";
            this.Text = "wellcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hellowText;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelQues;
    }
}