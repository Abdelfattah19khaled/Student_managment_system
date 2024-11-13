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

namespace Binary_File
{
    public partial class Searchform : Form

    {
        public static string ReadSearch= "";
       // public static string Rtext= "";
        public Searchform()
        {
            InitializeComponent();
        }

        private void FilenametextBox_TextChanged(object sender, EventArgs e)
        {
             // FilenametextBox3.Text = ReadSearch;
            ReadSearch = FilenametextBox3.Text; 
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            // form 

            //   string path = ReadSearch + ".txt";

            //Binary File\bin\Debug\Database
            string path = "Binary File/bin/Debug/Database/";
            string txt = ".txt";
            // SetValueForText1
            string filename = path + ReadSearch + txt;
            string ReadS = File.ReadAllText("Database.txt", Encoding.UTF8);
           // string ReadS = File.ReadAllText(filename, Encoding.UTF8);
            ReadS = Openform.Rtext;
            Openform Oform = new Openform();
            Oform.Show();
        }
    }
}
