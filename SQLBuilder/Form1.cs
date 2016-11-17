using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLBuilder
{
    public partial class SQLMainWindow : Form
    {
        public SQLMainWindow()
        {
            InitializeComponent();
            textBox1.Text = "localhost";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon_sql;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHP_5_MySQLi P5_SQLI = new PHP_5_MySQLi();

            richTextBox1.Text = P5_SQLI.UseMySQLi(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imagecopy = "http://www.iconarchive.com/show/mnemo-icons-by-hechiceroo.html" + Environment.NewLine + Environment.NewLine + "Developed by Droitech Games. Free and Open Source Software;";

            MessageBox.Show(imagecopy," Icons by Hechiceroo | MNEMO ICONS ");
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
