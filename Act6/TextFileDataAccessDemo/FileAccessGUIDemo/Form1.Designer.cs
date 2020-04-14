namespace FileAccessGUIDemo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.occBox = new System.Windows.Forms.TextBox();
            this.personButt = new System.Windows.Forms.Button();
            this.saveButt = new System.Windows.Forms.Button();
            this.loadButt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occupation:";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(90, 42);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(100, 20);
            this.fNameBox.TabIndex = 3;
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(90, 97);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(100, 20);
            this.lNameBox.TabIndex = 4;
            // 
            // occBox
            // 
            this.occBox.Location = new System.Drawing.Point(90, 152);
            this.occBox.Name = "occBox";
            this.occBox.Size = new System.Drawing.Size(100, 20);
            this.occBox.TabIndex = 5;
            // 
            // personButt
            // 
            this.personButt.Location = new System.Drawing.Point(62, 225);
            this.personButt.Name = "personButt";
            this.personButt.Size = new System.Drawing.Size(75, 23);
            this.personButt.TabIndex = 6;
            this.personButt.Text = "Create new Person!";
            this.personButt.UseVisualStyleBackColor = true;
            this.personButt.Click += new System.EventHandler(this.personButt_Click);
            // 
            // saveButt
            // 
            this.saveButt.Location = new System.Drawing.Point(12, 329);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(75, 23);
            this.saveButt.TabIndex = 7;
            this.saveButt.Text = "Save to File";
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // loadButt
            // 
            this.loadButt.Location = new System.Drawing.Point(115, 329);
            this.loadButt.Name = "loadButt";
            this.loadButt.Size = new System.Drawing.Size(75, 23);
            this.loadButt.TabIndex = 8;
            this.loadButt.Text = "Load File";
            this.loadButt.UseVisualStyleBackColor = true;
            this.loadButt.Click += new System.EventHandler(this.loadButt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(330, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(436, 329);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadButt);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.personButt);
            this.Controls.Add(this.occBox);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox occBox;
        private System.Windows.Forms.Button personButt;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Button loadButt;
        private System.Windows.Forms.ListBox listBox1;
    }
}

