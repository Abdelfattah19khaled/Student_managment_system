using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Binary_File
{
    public partial class DisplayForm : Form
    {
       // public static string ReadBA = "";
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = MainForm.ReadDA;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void displayFNtextBox_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
