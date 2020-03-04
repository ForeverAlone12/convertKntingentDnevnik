using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Открытие файла из АИС Контингент";
            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            textBox1.Text = openFileDialog1.FileName;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Папка для Дневник.ру";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не указан файл с данными из АИС Контингент!!!");
                return;
            }
                
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не указана папка для импорта файлов в Дневнинк.ру!!!");
                return;
            }

            Excel excel = new Excel();
            excel.readExcelFromKontingent(textBox1.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        
    }
}
