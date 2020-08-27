namespace Test
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.labelQues = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxAnsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswersgroupBox = new System.Windows.Forms.GroupBox();
            this.mark = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQues
            // 
            this.labelQues.AutoSize = true;
            this.labelQues.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQues.Location = new System.Drawing.Point(221, 203);
            this.labelQues.Name = "labelQues";
            this.labelQues.Size = new System.Drawing.Size(142, 62);
            this.labelQues.TabIndex = 0;
            this.labelQues.Text = "תרגיל";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNext.Location = new System.Drawing.Point(289, 351);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(121, 49);
            this.buttonNext.TabIndex = 29;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxAnsw
            // 
            this.textBoxAnsw.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnsw.Location = new System.Drawing.Point(388, 206);
            this.textBoxAnsw.Name = "textBoxAnsw";
            this.textBoxAnsw.Size = new System.Drawing.Size(70, 58);
            this.textBoxAnsw.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(289, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 31;
            this.label1.Text = ":פתור את התרגילים";
            // 
            // AnswersgroupBox
            // 
            this.AnswersgroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AnswersgroupBox.Location = new System.Drawing.Point(408, 146);
            this.AnswersgroupBox.Name = "AnswersgroupBox";
            this.AnswersgroupBox.Size = new System.Drawing.Size(175, 230);
            this.AnswersgroupBox.TabIndex = 32;
            this.AnswersgroupBox.TabStop = false;
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark.Location = new System.Drawing.Point(12, 34);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(28, 31);
            this.mark.TabIndex = 33;
            this.mark.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = ":ציון";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(388, 271);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 19);
            this.error.TabIndex = 35;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources._3178868;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.AnswersgroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnsw);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelQues);
            this.Font = new System.Drawing.Font("Yu Gothic UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "test";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQues;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxAnsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AnswersgroupBox;
        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error;
    }
}