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

namespace Student_Filing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
                 string Name;
                Name=Console.ReadLine();
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string F_Name;
            F_Name = Console.ReadLine();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(Console.ReadLine());
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string Roll_No;
            Roll_No = Console.ReadLine();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int sem;
            sem = Convert.ToInt32(Console.ReadLine());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fpath = @"c:\OOPSE\myfile.txt";
            string Data = "";
            StreamWriter towrite = null;
            try
            {
                towrite = new StreamWriter(fpath);
                Data = textBox1.Text + "\r\n" + textBox3.Text + "\r\n" + textBox5.Text + "\r\n" + textBox6.Text + "\r\n" + textBox7.Text + "\r\n" ;
                towrite.Write(Data);
                
               


            }
            catch (IOException ex)
            {
                Console.WriteLine("some error" + ex.Message);
            }
            finally
            {
                towrite.Close();
            }
            Console.WriteLine("Name:{0} \nF_Name:{1} \nAge:{2} \nRoll_No:{3} \nSemester:{4} \n");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



    }
}
