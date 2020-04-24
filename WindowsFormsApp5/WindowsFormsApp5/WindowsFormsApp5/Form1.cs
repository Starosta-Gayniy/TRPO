using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        //создаем поток записи
        

        //записываем данные


        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount++;

            int row = dataGridView1.RowCount -1;
            dataGridView1[0, row - 1].Value = textBox1.Text;
            dataGridView1[1, row - 1].Value = textBox2.Text;
            dataGridView1[2, row - 1].Value = textBox3.Text;
            dataGridView1[3, row - 1].Value = textBox4.Text;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.Open("test.txt", FileMode.Append));
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
          
        }
    }
}
