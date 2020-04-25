namespace GUIMinesweeper
{
    partial class Form3
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.playButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(157, 58);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "label1";
            // 
            // playButt
            // 
            this.playButt.Location = new System.Drawing.Point(142, 223);
            this.playButt.Name = "playButt";
            this.playButt.Size = new System.Drawing.Size(75, 23);
            this.playButt.TabIndex = 1;
            this.playButt.Text = "button1";
            this.playButt.UseVisualStyleBackColor = true;
            this.playButt.Click += new System.EventHandler(this.playButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Final Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(157, 160);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "label2";
            // 
            // scoreBox
            // 
            this.scoreBox.FormattingEnabled = true;
            this.scoreBox.Location = new System.Drawing.Point(302, 58);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(339, 329);
            this.scoreBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "High Scores:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButt);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button playButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ListBox scoreBox;
        private System.Windows.Forms.Label label2;
    }
}