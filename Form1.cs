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

        private void openFileBtn_Click(object sender, EventArgs e)
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
            allText = allText.Replace(' '.ToString(), string.Empty);
            //allText.Split('.', ' ', ',', '-', '!', '?');            

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
                allText = allText.Replace(allText[0].ToString(), string.Empty);
            }
            
            listView1.Columns.Add("Letter Frequency", 110);
            listView1.Columns.Add("Letter", 100);                   
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Descending;                       
        }

        
        private void clearText_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listView1.Clear();
        }          
    }
}
