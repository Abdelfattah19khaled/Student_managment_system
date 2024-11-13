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
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            sfd.Filter = "Text Files | *.TXT";
            sfd.InitialDirectory = "C:\\";
            if (sfd.ShowDialog()== DialogResult.OK)
            {
                //File.WriteAllText(sfd.FileName, textBox1.Text);
                MessageBox.Show("Saved successflly", "Save", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
