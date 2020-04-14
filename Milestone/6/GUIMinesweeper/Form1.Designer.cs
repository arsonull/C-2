namespace GUIMinesweeper
{
    partial class Form1
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
            this.sizeNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.diffBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeNum
            // 
            this.sizeNum.Location = new System.Drawing.Point(190, 69);
            this.sizeNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sizeNum.Name = "sizeNum";
            this.sizeNum.Size = new System.Drawing.Size(44, 20);
            this.sizeNum.TabIndex = 0;
            this.sizeNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Board Size:";
            // 
            // diffBar
            // 
            this.diffBar.Location = new System.Drawing.Point(70, 205);
            this.diffBar.Maximum = 9;
            this.diffBar.Minimum = 1;
            this.diffBar.Name = "diffBar";
            this.diffBar.Size = new System.Drawing.Size(206, 45);
            this.diffBar.TabIndex = 1;
            this.diffBar.Value = 1;
            this.diffBar.Scroll += new System.EventHandler(this.diffBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Difficulty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // playButt
            // 
            this.playButt.Location = new System.Drawing.Point(133, 299);
            this.playButt.Name = "playButt";
            this.playButt.Size = new System.Drawing.Size(75, 23);
            this.playButt.TabIndex = 4;
            this.playButt.Text = "Play!";
            this.playButt.UseVisualStyleBackColor = true;
            this.playButt.Click += new System.EventHandler(this.playButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 391);
            this.Controls.Add(this.playButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diffBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sizeNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar diffBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playButt;
    }
}

