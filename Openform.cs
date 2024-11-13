using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_File
{
    public partial class Openform : Form
    {
        public static string Rtext = "";
        public Openform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Rtext;
           
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
