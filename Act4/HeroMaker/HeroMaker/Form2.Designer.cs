namespace HeroMaker
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.heroBox = new System.Windows.Forms.ListBox();
            this.heroListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.summBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heroListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heroes:";
            // 
            // heroBox
            // 
            this.heroBox.DataSource = this.heroListBindingSource;
            this.heroBox.FormattingEnabled = true;
            this.heroBox.Location = new System.Drawing.Point(55, 82);
            this.heroBox.Name = "heroBox";
            this.heroBox.Size = new System.Drawing.Size(172, 147);
            this.heroBox.TabIndex = 1;
            this.heroBox.SelectedIndexChanged += new System.EventHandler(this.heroBox_SelectedIndexChanged);
            // 
            // heroListBindingSource
            // 
            this.heroListBindingSource.DataSource = typeof(HeroMaker.HeroList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summary:";
            // 
            // summBox
            // 
            this.summBox.Location = new System.Drawing.Point(312, 82);
            this.summBox.Multiline = true;
            this.summBox.Name = "summBox";
            this.summBox.ReadOnly = true;
            this.summBox.Size = new System.Drawing.Size(286, 147);
            this.summBox.TabIndex = 3;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(98, 264);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "New Hero";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 322);
            this.Controls.Add(this.search);
            this.Controls.Add(this.summBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heroBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.heroListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox heroBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.BindingSource heroListBindingSource;
    }
}