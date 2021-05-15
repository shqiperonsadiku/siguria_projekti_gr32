﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.getFrequencyBtn = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.enterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearKeyBtn = new System.Windows.Forms.Button();
            this.keyValueTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(915, 162);
            this.textBox1.TabIndex = 0;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 22);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.Text = "Load File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // getFrequencyBtn
            // 
            this.getFrequencyBtn.Location = new System.Drawing.Point(12, 232);
            this.getFrequencyBtn.Name = "getFrequencyBtn";
            this.getFrequencyBtn.Size = new System.Drawing.Size(104, 26);
            this.getFrequencyBtn.TabIndex = 5;
            this.getFrequencyBtn.Text = "Get Frequency";
            this.getFrequencyBtn.UseVisualStyleBackColor = true;
            this.getFrequencyBtn.Click += new System.EventHandler(this.getFrequencyBtn_Click);
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(93, 22);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(75, 23);
            this.clearText.TabIndex = 6;
            this.clearText.Text = "Clear Data";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 264);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 257);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(164, 557);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(254, 19);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "English alphabet letters frequency";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(173, 264);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Letters";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(754, 257);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(12, 585);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Letters";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(915, 300);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(301, 949);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(87, 26);
            this.enterBtn.TabIndex = 16;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 949);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter key value :";
            // 
            // decryptedText
            // 
            this.decryptedText.Location = new System.Drawing.Point(11, 1016);
            this.decryptedText.Multiline = true;
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.Size = new System.Drawing.Size(916, 144);
            this.decryptedText.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 985);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Decrypted Text";
            // 
            // clearKeyBtn
            // 
            this.clearKeyBtn.Location = new System.Drawing.Point(409, 949);
            this.clearKeyBtn.Name = "clearKeyBtn";
            this.clearKeyBtn.Size = new System.Drawing.Size(114, 28);
            this.clearKeyBtn.TabIndex = 22;
            this.clearKeyBtn.Text = "Clear key value";
            this.clearKeyBtn.UseVisualStyleBackColor = true;
            this.clearKeyBtn.Click += new System.EventHandler(this.clearKeyBtn_Click);
            // 
            // keyValueTxt
            // 
            this.keyValueTxt.Location = new System.Drawing.Point(147, 949);
            this.keyValueTxt.Multiline = true;
            this.keyValueTxt.Name = "keyValueTxt";
            this.keyValueTxt.Size = new System.Drawing.Size(112, 26);
            this.keyValueTxt.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(951, 561);
            this.Controls.Add(this.keyValueTxt);
            this.Controls.Add(this.clearKeyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.getFrequencyBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button getFrequencyBtn;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decryptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearKeyBtn;
        private System.Windows.Forms.TextBox keyValueTxt;
    }
}

