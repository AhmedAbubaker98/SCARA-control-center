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

namespace SCARA_control_center
{
    
    public partial class Form1 : Form
    {
        private char mode = 'J';

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

        private void button11_Click(object sender, EventArgs e)
        {
            


            
            string m1 = "P" + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
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
    }
}
