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
namespace devapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            StringBuilder csvtest = new StringBuilder();
            csvtest.AppendLine("name,age");
            csvtest.AppendLine("bob,5");
            String Pathofcsv = "C:\\Users\\A_mah\\Documents\\test.csv";
            File.AppendAllText(Pathofcsv, csvtest.ToString());

        }
    }
}
