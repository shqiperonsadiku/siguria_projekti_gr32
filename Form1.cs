using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace siguriaProjektiDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog d1 = new OpenFileDialog();
            if (d1.ShowDialog() == DialogResult.OK)
            {
                if ((st = d1.OpenFile()) != null)
                {
                    string file = d1.FileName;
                    String str = File.ReadAllText(file);
                    textBox1.Text = str;
                }
            }
        }
        private void add(String letter, string frequency)
        {
            String[] row = { letter, frequency };

            ListViewItem item = new ListViewItem(row);
            //ADD ITEMS
            listView1.Items.Add(item);
        }


        private void getFrequencyBtn_Click(object sender, EventArgs e)
        {
            String allText = textBox1.Text;
            allText = allText.ToUpper();       
            allText = allText.Replace('.'.ToString(), string.Empty);
            allText = allText.Replace(','.ToString(), string.Empty);
            allText = allText.Replace('-'.ToString(), string.Empty);
            allText = allText.Replace('!'.ToString(), string.Empty);
            allText = allText.Replace('?'.ToString(), string.Empty);
            allText = allText.Replace('\''.ToString(), string.Empty);
            allText = allText.Replace('('.ToString(), string.Empty);
            allText = allText.Replace(')'.ToString(), string.Empty);
            allText = allText.Replace(' '.ToString(), string.Empty);
      

            while (allText.Length>0)
            {
                int countOfChar = 0;                          
                for (int i = 0; i < allText.Length; i++)
                {

                    if (allText[0] == allText[i])
                    {
                        countOfChar++;
                    } 
                }               
                add(countOfChar.ToString("D5"), allText[0].ToString());
                chart1.ChartAreas.FirstOrDefault().AxisX.Interval = 1;                
                chart1.Series["Letters"].Points.AddXY(allText[0].ToString(), countOfChar);                
                allText = allText.Replace(allText[0].ToString(), string.Empty);
            }

       
            listView1.Columns.Add("Letter \nFrequency", 95);
            listView1.Columns.Add("Letter", 40);                   
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Descending;                       
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listView1.Clear();
            chart1.Series[0].Points.Clear();
        }

        private void showDataBtn_Click(object sender, EventArgs e)
        {
            chart2.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chart2.Series["Letters"].Points.AddXY('A'.ToString(), 8.12);
            chart2.Series["Letters"].Points.AddXY('B'.ToString(), 1.49);
            chart2.Series["Letters"].Points.AddXY('C'.ToString(), 2.71);
            chart2.Series["Letters"].Points.AddXY('D'.ToString(), 4.32);
            chart2.Series["Letters"].Points.AddXY('E'.ToString(), 12.02);
            chart2.Series["Letters"].Points.AddXY('F'.ToString(), 2.30);
            chart2.Series["Letters"].Points.AddXY('G'.ToString(), 2.03);
            chart2.Series["Letters"].Points.AddXY('H'.ToString(), 5.92);
            chart2.Series["Letters"].Points.AddXY('I'.ToString(), 7.31);
            chart2.Series["Letters"].Points.AddXY('J'.ToString(), 0.10);
            chart2.Series["Letters"].Points.AddXY('K'.ToString(), 0.69);
            chart2.Series["Letters"].Points.AddXY('L'.ToString(), 3.98);
            chart2.Series["Letters"].Points.AddXY('M'.ToString(), 2.61);
            chart2.Series["Letters"].Points.AddXY('N'.ToString(), 6.95);
            chart2.Series["Letters"].Points.AddXY('O'.ToString(), 7.68);
            chart2.Series["Letters"].Points.AddXY('P'.ToString(), 1.82);
            chart2.Series["Letters"].Points.AddXY('Q'.ToString(), 0.11);
            chart2.Series["Letters"].Points.AddXY('R'.ToString(), 6.02);
            chart2.Series["Letters"].Points.AddXY('S'.ToString(), 6.28);
            chart2.Series["Letters"].Points.AddXY('T'.ToString(), 9.10);
            chart2.Series["Letters"].Points.AddXY('U'.ToString(), 2.88);
            chart2.Series["Letters"].Points.AddXY('V'.ToString(), 1.11);
            chart2.Series["Letters"].Points.AddXY('W'.ToString(), 2.09);
            chart2.Series["Letters"].Points.AddXY('X'.ToString(), 0.17);
            chart2.Series["Letters"].Points.AddXY('Y'.ToString(), 2.11);
            chart2.Series["Letters"].Points.AddXY('Z'.ToString(), 0.07);
        }

        private char Encrypt(char ch, int code)
        {
            if (!char.IsLetter(ch)) return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((ch + code - offset) % 26 + offset);
        }

        private string Encrypt(string input, int code)
        {
            return new string(input.Select(ch => Encrypt(ch, code)).ToArray());
        }

        private string Decrypt(string input, int code)
        {
            return Encrypt(input, 26 - code);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            decryptedText.Text = Decrypt(textBox1.Text, int.Parse(keyValueTxt.Text));
        }

        private void clearKeyBtn_Click(object sender, EventArgs e)
        {
            keyValueTxt.Clear();
            decryptedText.Clear();
        }

    }
}
