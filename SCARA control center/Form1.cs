using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace SCARA_control_center
{
    
    public partial class Form1 : Form
    {
        public char mode = 'J';
        

        public Form1()

        {
            InitializeComponent();
            this.Text = "SCARA Human Machine Interface";
            serialPort1.Open();
            radioButton1.Checked = true;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(mode == 'J') { serialPort1.Write("A"); }
            else { serialPort1.Write("E"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("a"); }
            else { serialPort1.Write("e"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("B"); }
            else { serialPort1.Write("F"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("b"); }
            else { serialPort1.Write("f"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("C"); }
            else { serialPort1.Write("G"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("c"); }
            else { serialPort1.Write("g"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("D"); }
            else { serialPort1.Write("H"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mode == 'J') { serialPort1.Write("d"); }
            else { serialPort1.Write("h"); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            serialPort1.Write("J");
            mode = 'J';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.Write("X");
            mode = 'X';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Z");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string m1 = "S" + numericUpDown1.Value;
            serialPort1.Write(m1);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void button11_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Math.Round(numericUpDown3.Value));
            int y = Convert.ToInt32(Math.Round(numericUpDown4.Value));
            int z = Convert.ToInt32(Math.Round(numericUpDown5.Value));

            textBox1.Text = numericUpDown3.Value.ToString();
            textBox2.Text = numericUpDown4.Value.ToString();
            textBox3.Text = numericUpDown5.Value.ToString();

            double t2;
            double t1;
            double s1;
            double s2;
            double s3;

            t2 = Math.Acos(((x * x) + (y * y) - (32.7 * 32.7) - (22.3 * 22.3)) / (2 * 32.7 * 22.3));
            t2 = t2 * 180 / Math.PI;
            t1 = Math.Atan(y / x) - Math.Atan(22.3 * Math.Sin(t2) / 32.7 + (22.3 * Math.Cos(t2)));
            t1 = t1 * 180 / Math.PI;
            
            textBox6.Text = t1.ToString();
            textBox5.Text = t2.ToString();
            textBox4.Text = numericUpDown8.Value.ToString();
            textBox4.Text = numericUpDown5.Value.ToString();

            s1 = (t1 / .20);
            s2 = (t2 / .25);
            s3 = (z / 1);
            

            string m1 = "P" + s1 + s2 + s3;
        }

        public void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        public void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        public void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/PixyMon");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox6.Text = numericUpDown7.Value.ToString();
            textBox5.Text = numericUpDown9.Value.ToString();

            double x = 32.7 * (Math.Sin((Double)numericUpDown7.Value * Math.PI / 180)) + (22.3 * (Math.Cos((Double)numericUpDown9.Value * Math.PI / 180)));
            textBox1.Text = x.ToString();
            double y = 32.7 * (Math.Cos((Double)numericUpDown7.Value * Math.PI / 180)) + (22.3 * (Math.Sin((Double)numericUpDown9.Value * Math.PI / 180)));
            textBox2.Text = y.ToString();
            
            textBox4.Text = numericUpDown8.Value.ToString();
            textBox3.Text = numericUpDown8.Value.ToString();

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
