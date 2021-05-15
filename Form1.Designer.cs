
namespace siguriaProjektiDesktop
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.getFrequencyBtn = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clearFrequencyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(767, 162);
            this.textBox1.TabIndex = 0;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(29, 22);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.Text = "Load File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // getFrequencyBtn
            // 
            this.getFrequencyBtn.Location = new System.Drawing.Point(29, 231);
            this.getFrequencyBtn.Name = "getFrequencyBtn";
            this.getFrequencyBtn.Size = new System.Drawing.Size(104, 26);
            this.getFrequencyBtn.TabIndex = 5;
            this.getFrequencyBtn.Text = "Get Frequency";
            this.getFrequencyBtn.UseVisualStyleBackColor = true;
            this.getFrequencyBtn.Click += new System.EventHandler(this.getFrequencyBtn_Click);
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(124, 22);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(75, 23);
            this.clearText.TabIndex = 6;
            this.clearText.Text = "Clear Text";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 264);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 257);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clearFrequencyBtn
            // 
            this.clearFrequencyBtn.Location = new System.Drawing.Point(139, 233);
            this.clearFrequencyBtn.Name = "clearFrequencyBtn";
            this.clearFrequencyBtn.Size = new System.Drawing.Size(75, 23);
            this.clearFrequencyBtn.TabIndex = 8;
            this.clearFrequencyBtn.Text = "Clear Frequency";
            this.clearFrequencyBtn.UseVisualStyleBackColor = true;
            this.clearFrequencyBtn.Click += new System.EventHandler(this.clearFrequencyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 524);
            this.Controls.Add(this.clearFrequencyBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.getFrequencyBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button getFrequencyBtn;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button clearFrequencyBtn;
    }
}

