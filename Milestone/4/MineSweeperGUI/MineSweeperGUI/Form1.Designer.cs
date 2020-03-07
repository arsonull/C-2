namespace MineSweeperGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.diffBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.diffLabel = new System.Windows.Forms.Label();
            this.beginButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diffBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty:";
            // 
            // diffBar
            // 
            this.diffBar.Location = new System.Drawing.Point(310, 232);
            this.diffBar.Maximum = 9;
            this.diffBar.Minimum = 1;
            this.diffBar.Name = "diffBar";
            this.diffBar.Size = new System.Drawing.Size(309, 90);
            this.diffBar.TabIndex = 1;
            this.diffBar.Value = 5;
            this.diffBar.Scroll += new System.EventHandler(this.diffBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.Location = new System.Drawing.Point(452, 182);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(70, 25);
            this.diffLabel.TabIndex = 3;
            this.diffLabel.Text = "label3";
            // 
            // beginButt
            // 
            this.beginButt.Location = new System.Drawing.Point(422, 392);
            this.beginButt.Name = "beginButt";
            this.beginButt.Size = new System.Drawing.Size(100, 40);
            this.beginButt.TabIndex = 4;
            this.beginButt.Text = "Begin";
            this.beginButt.UseVisualStyleBackColor = true;
            this.beginButt.Click += new System.EventHandler(this.beginButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 572);
            this.Controls.Add(this.beginButt);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diffBar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diffBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar diffBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Button beginButt;
    }
}

