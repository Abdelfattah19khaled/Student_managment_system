using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Binary_File
{
    
    public partial class InsertForm : Form
    {
        //public string Filename { get; set; }
        public static string SetValueForId = "";
        public static string SetValueForName = "";
        public static string SetValueForTel = "";
        public static string SetValueForYear = "";
        public static string SetValueForGender = "";
        public static string SetValueForFilename = "";
        //public static InsertForm FromInsert;
        //public TextBox tbxinsrt;
        public InsertForm()
        {
            InitializeComponent();
           // FromInsert = this;
            //tbxinsrt = FilenameBox;
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = MainForm.filename;


        }
             

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string ReadDB = File.ReadAllText("Database.txt", Encoding.UTF8);
           
            SetValueForId = "|| ID : "+ IDtextBox.Text;
            SetValueForName =" Name : " + NametextBox.Text;
            SetValueForTel = " Tel : " + TeltextBox.Text;
            SetValueForYear = " Year : " + YeartextBox.Text;
            SetValueForGender = " Gender : " + GendertextBox.Text+" ||\n";

            //


            string path = "Binary File/bin/Debug/Database/";
            string txt = ".txt";
               // SetValueForText1
            string filename = path + MainForm.filename+ txt;
            string Database = path + "Database";
      

            string Sumrec = SetValueForId + SetValueForName + SetValueForTel + SetValueForYear + SetValueForGender ;


           File.WriteAllText(filename, Sumrec );
            string Result = ReadDB + Sumrec ;
            File.WriteAllText("Database.txt", Result);

            ReadDB = "" ;
            Result = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

            //string readme = File.ReadAllText("readme.txt", Encoding.UTF8);
           // string readText = File.ReadAllText("Database.txt", Encoding.UTF8);
           // string sum = readText +readme; 
           // File.WriteAllText("Database.txt", sum); 
           this.Close();

        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void NametextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void FilenameBox_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        public void Filenamelabel_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
