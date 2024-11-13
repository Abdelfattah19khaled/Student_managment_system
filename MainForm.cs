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
using System.Diagnostics;

namespace Binary_File
{
    public partial class MainForm : Form
    {
        public static string filename = "";
        public static string ReadDA = "";

        public static MainForm FromMain;
        public MainForm()
        {
            InitializeComponent();
            FromMain = this;
            string path = "C:/Users/CITY-LAP/Desktop/PROJECTS/File-organization1#/Binary File Design only/Binary File/bin/Debug/Database/";
            string txt = ".txt";
            string filename = path + FilenametextBox.Text + txt;

        }

        public void Createbtn_Click_1(object sender, EventArgs e)
        {



            filename = FilenametextBox.Text;
            InsertForm insrtf = new InsertForm();
            insrtf.Show();

            // statment if Empty path name is not legal.'
           // using (StreamWriter fs = File.CreateText(filename)) { }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // this from create ! 

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InsertForm insrtf = new InsertForm();
            insrtf.Show();

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            Save sf = new Save();
            sf.Show();

            /*    string path = "C:/Users/CITY-LAP/Desktop/PROJECTS/File-organization1#/Binary File Design only/Binary File/bin/Debug/Database/";
              string txt = ".txt";
              string filename = path + FilenametextBox.Text + txt;
              string Saveas = "ss" ;
            try
              {
                  //File.Copy(filename,true);
              }
              catch (IOException iox)
              {
                  Console.WriteLine(iox.Message);
            */
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/CITY-LAP/Desktop/PROJECTS/File-organization1#/Binary File Design only/Binary File/bin/Debug/Database/";
            string txt = ".txt";
            string filename = path + FilenametextBox.Text + txt;

            //File.Delete(Path.Combine(filename));
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(filename)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(filename));
                    label3.Text = "File deleted.";
                }
                else label4.Text = "File not found";
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }


        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm insrtf = new InsertForm();
            insrtf.Show();
        }

        private void viewExistingStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ReadDA = File.ReadAllText("Database.txt", Encoding.UTF8);
           

            DisplayForm Dform = new DisplayForm();
            Dform.Show();
        }


        private void searchForStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchform Sform = new Searchform();
            Sform.Show();
        }
            


       private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void FilenametextBox_TextChanged(object sender, EventArgs e)
        {
          
        }



        private void Deletebtn_Click_1(object sender, EventArgs e)
        {
            string path = "Binary File/bin/Debug/Database/";
            string txt = ".txt";
            string filename = path + FilenametextBox.Text + txt;

            //File.Delete(Path.Combine(filename));
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(filename)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(filename));
                    label3.Text = "File deleted.";
                }
                else label4.Text = "File not found";
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }
    }
}
