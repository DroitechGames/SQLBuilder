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
            hostTextBox.Text = "localhost";
            dbTextbox.Text = "";
            userTextbox.Text = "";
            passTextbox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon_sql;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QueryBox.Clear();
        }
        static bool checkState;
        private void button1_Click(object sender, EventArgs e)
        {
            PHP_5_MySQLi P5_SQLI = new PHP_5_MySQLi();
            if (_UseMD5.Checked != true)
            {
                checkState = false;
                MessageBox.Show("MD5 Not Selected.");
            }
            else
            {
                QueryBox.Text = P5_SQLI.UseMySQLi(hostTextBox.Text, dbTextbox.Text, userTextbox.Text, passTextbox.Text, _ConnectionVar.Text, _ConnectionError.Text, checkState);
            }
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
