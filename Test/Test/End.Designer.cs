namespace Test
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.marklable = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marklable
            // 
            this.marklable.AutoSize = true;
            this.marklable.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 28.2F, System.Drawing.FontStyle.Italic);
            this.marklable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.marklable.Location = new System.Drawing.Point(366, 109);
            this.marklable.Name = "marklable";
            this.marklable.Size = new System.Drawing.Size(148, 62);
            this.marklable.TabIndex = 0;
            this.marklable.Text = "label1";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 28.2F, System.Drawing.FontStyle.Italic);
            this.comment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comment.Location = new System.Drawing.Point(253, 263);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(157, 62);
            this.comment.TabIndex = 1;
            this.comment.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "הצג היסטוריית ציונים";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources._31788682;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.marklable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "End";
            this.Text = "End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marklable;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.Button button1;
    }
}