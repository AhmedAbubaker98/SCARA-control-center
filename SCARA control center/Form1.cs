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
        double L1 = 24;
        double L2 = 12;
        double t2;
        double t1;
        double pt2;
        double pt1;

        public Form1()

        {
            InitializeComponent();
            this.Text = "SCARA Human Machine Interface";
            serialPort1.Open();
            radioButton1.Checked = true;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(mode == 'J')
            {
                pt2 = t2;
                pt1 = t1;
                //textBox6.Text = numericUpDown7.Value.ToString("###,##0.00");
                //textBox5.Text = numericUpDown9.Value.ToString("###,##0.00");
                //textBox4.Text = numericUpDown8.Value.ToString("###,##0.00");
                //textBox3.Text = numericUpDown8.Value.ToString("###,##0.00");

                t1 = (t1 + (0.36 * (double)numericUpDown1.Value)) * (Math.PI / 180);
                //t2 = t2 * Math.PI / 180;
                double x = L1 * Math.Cos(t1) + L2 * Math.Cos(t1 + t2);
                textBox1.Text = x.ToString("###,##0.00");
                double y = L1 * Math.Sin(t1) + L2 * Math.Sin(t1 + t2);
                textBox2.Text = y.ToString("###,##0.00");

                t1 = t1 * 180 / Math.PI;
                //t2 = t2 * 180 / Math.PI;

                textBox6.Text = t1.ToString("###,##0.00");
                textBox1.Text = x.ToString("###,##0.00");
                textBox2.Text = y.ToString("###,##0.00");


                serialPort1.Write("A"); }
            else {

                pt2 = t2;
                pt1 = t1;
                double x = Convert.ToInt32(textBox1.Text) + 1;
                double y = Convert.ToInt32(textBox2.Text);
                double z = Convert.ToInt32(textBox3.Text);

                textBox1.Text = x.ToString("###,##0.00");
                //textBox2.Text = numericUpDown4.Value.ToString("###,##0.00");
                //textBox3.Text = numericUpDown5.Value.ToString("###,##0.00");

                t2 = Math.Acos((x * x + y * y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
                t2 = t2 * 180 / Math.PI;
                t1 = Math.Atan2(y, x) - Math.Atan2((L2 * Math.Sin(t2)), (L1 + L2 * Math.Cos(t2)));
                t1 = t1 * 180 / Math.PI;

                textBox6.Text = t1.ToString("###,##0.00");
                textBox5.Text = t2.ToString("###,##0.00");
                textBox4.Text = numericUpDown5.Value.ToString("###,##0.00");

                string m1 = "P" + t1 / 0.20 + t2 / 0.25 + z;
                serialPort1.Write(m1);

                //serialPort1.Write("E");
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {
                pt2 = t2;
                pt1 = t1;
                //textBox6.Text = numericUpDown7.Value.ToString("###,##0.00");
                //textBox5.Text = numericUpDown9.Value.ToString("###,##0.00");
                //textBox4.Text = numericUpDown8.Value.ToString("###,##0.00");
                //textBox3.Text = numericUpDown8.Value.ToString("###,##0.00");

                t1 = (t1 - (0.36 * (double)numericUpDown1.Value)) * (Math.PI / 180);
                //t2 = t2 * Math.PI / 180;
                double x = L1 * Math.Cos(t1) + L2 * Math.Cos(t1 + t2);
                textBox1.Text = x.ToString("###,##0.00");
                double y = L1 * Math.Sin(t1) + L2 * Math.Sin(t1 + t2);
                textBox2.Text = y.ToString("###,##0.00");

                t1 = t1 * 180 / Math.PI;
                //t2 = t2 * 180 / Math.PI;

                textBox6.Text = t1.ToString("###,##0.00");
                textBox1.Text = x.ToString("###,##0.00");
                textBox2.Text = y.ToString("###,##0.00");


                serialPort1.Write("A");


                serialPort1.Write("a"); }
            else {
                pt2 = t2;
                pt1 = t1;
                double x = Convert.ToInt32(textBox1.Text) - 1;
                double y = Convert.ToInt32(textBox2.Text);
                double z = Convert.ToInt32(textBox3.Text);

                textBox1.Text = x.ToString("###,##0.00");
                //textBox2.Text = numericUpDown4.Value.ToString("###,##0.00");
                //textBox3.Text = numericUpDown5.Value.ToString("###,##0.00");

                t2 = Math.Acos((x * x + y * y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
                t2 = t2 * 180 / Math.PI;
                t1 = Math.Atan2(y, x) - Math.Atan2((L2 * Math.Sin(t2)), (L1 + L2 * Math.Cos(t2)));
                t1 = t1 * 180 / Math.PI;

                textBox6.Text = t1.ToString("###,##0.00");
                textBox5.Text = t2.ToString("###,##0.00");
                textBox4.Text = numericUpDown5.Value.ToString("###,##0.00");

                string m1 = "P" + t1 / 0.20 + t2 / 0.25 + z;
                serialPort1.Write(m1);


                serialPort1.Write("e"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {
               
            
            
            }
            else {
                pt2 = t2;
                pt1 = t1;
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text) + 1;
                double z = Convert.ToInt32(textBox3.Text);

                //textBox1.Text = x.ToString("###,##0.00");
                textBox2.Text = y.ToString("###,##0.00");
                //textBox3.Text = numericUpDown5.Value.ToString("###,##0.00");

                t2 = Math.Acos((x * x + y * y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
                t2 = t2 * 180 / Math.PI;
                t1 = Math.Atan2(y, x) - Math.Atan2((L2 * Math.Sin(t2)), (L1 + L2 * Math.Cos(t2)));
                t1 = t1 * 180 / Math.PI;

                textBox6.Text = t1.ToString("###,##0.00");
                textBox5.Text = t2.ToString("###,##0.00");
                textBox4.Text = numericUpDown5.Value.ToString("###,##0.00");

                string m1 = "P" + t1 / 0.20 + t2 / 0.25 + z;
                serialPort1.Write(m1);



                serialPort1.Write("F"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {
               
            
            
            }
            else {

                pt2 = t2;
                pt1 = t1;
                double x = Convert.ToInt32(textBox1.Text) ;
                double y = Convert.ToInt32(textBox2.Text) - 1;
                double z = Convert.ToInt32(textBox3.Text);

                //textBox1.Text = x.ToString("###,##0.00");
                textBox2.Text = y.ToString("###,##0.00");
                //textBox3.Text = numericUpDown5.Value.ToString("###,##0.00");

                t2 = Math.Acos((x * x + y * y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
                t2 = t2 * 180 / Math.PI;
                t1 = Math.Atan2(y, x) - Math.Atan2((L2 * Math.Sin(t2)), (L1 + L2 * Math.Cos(t2)));
                t1 = t1 * 180 / Math.PI;

                textBox6.Text = t1.ToString("###,##0.00");
                textBox5.Text = t2.ToString("###,##0.00");
                textBox4.Text = numericUpDown5.Value.ToString("###,##0.00");

                string m1 = "P" + t1 / 0.20 + t2 / 0.25 + z;
                serialPort1.Write(m1);


                serialPort1.Write("f"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {
                pt2 = t2;
                pt1 = t1;
                //textBox6.Text = numericUpDown7.Value.ToString("###,##0.00");
                //textBox5.Text = numericUpDown9.Value.ToString("###,##0.00");
                //textBox4.Text = numericUpDown8.Value.ToString("###,##0.00");
                //textBox3.Text = numericUpDown8.Value.ToString("###,##0.00");

                //t1 = t1  * (Math.PI / 180);
                t2 = (t2 + (0.36 * (double)numericUpDown1.Value)) * Math.PI / 180;
                double x = L1 * Math.Cos(t1) + L2 * Math.Cos(t1 + t2);
                textBox1.Text = x.ToString("###,##0.00");
                double y = L1 * Math.Sin(t1) + L2 * Math.Sin(t1 + t2);
                textBox2.Text = y.ToString("###,##0.00");

                //t1 = t1 * 180 / Math.PI;
                t2 = t2 * 180 / Math.PI;

                textBox5.Text = t2.ToString("###,##0.00");
                textBox1.Text = x.ToString("###,##0.00");
                textBox2.Text = y.ToString("###,##0.00");


                serialPort1.Write("A");


                serialPort1.Write("B");


                serialPort1.Write("C"); }
            else { 
                
                
                
                
                serialPort1.Write("G"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {
                pt2 = t2;
                pt1 = t1;
                //textBox6.Text = numericUpDown7.Value.ToString("###,##0.00");
                //textBox5.Text = numericUpDown9.Value.ToString("###,##0.00");
                //textBox4.Text = numericUpDown8.Value.ToString("###,##0.00");
                //textBox3.Text = numericUpDown8.Value.ToString("###,##0.00");

                //t1 = t1  * (Math.PI / 180);
                t2 = (t2 - (0.36 * (double)numericUpDown1.Value)) * Math.PI / 180;
                double x = L1 * Math.Cos(t1) + L2 * Math.Cos(t1 + t2);
                textBox1.Text = x.ToString("###,##0.00");
                double y = L1 * Math.Sin(t1) + L2 * Math.Sin(t1 + t2);
                textBox2.Text = y.ToString("###,##0.00");

                //t1 = t1 * 180 / Math.PI;
                t2 = t2 * 180 / Math.PI;

                textBox5.Text = t2.ToString("###,##0.00");
                textBox1.Text = x.ToString("###,##0.00");
                textBox2.Text = y.ToString("###,##0.00");


                serialPort1.Write("A");


                serialPort1.Write("b");


                serialPort1.Write("c"); }
            else { 
                
                
                
                
                serialPort1.Write("g"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {



                serialPort1.Write("D"); }
            else { 
                
                
                
                
                serialPort1.Write("H"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mode == 'J')
            {



                serialPort1.Write("d"); }
            else { 
                
                
                
                
                serialPort1.Write("h"); }
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
            pt2 = t2;
            pt1 = t1;
            double x = Convert.ToInt32((numericUpDown3.Value));
            double y = Convert.ToInt32((numericUpDown4.Value));
            double z = Convert.ToInt32((numericUpDown5.Value));

            textBox1.Text = numericUpDown3.Value.ToString("###,##0.00");
            textBox2.Text = numericUpDown4.Value.ToString("###,##0.00");
            textBox3.Text = numericUpDown5.Value.ToString("###,##0.00");

            //t2 = Math.Acos(((x * x) + (y * y) - (32.7 * 32.7) - (22.3 * 22.3)) / (2 * 32.7 * 22.3));
            t2 = Math.Acos((x * x + y * y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
            t2 = t2 * 180 / Math.PI;
            //t1 = Math.Atan(y / x) - Math.Atan(22.3 * Math.Sin(t2) / 32.7 + (22.3 * Math.Cos(t2)));
            t1 = Math.Atan2(y, x) - Math.Atan2((L2 * Math.Sin(t2)), (L1 + L2 * Math.Cos(t2)));
            t1 = t1 * 180 / Math.PI;
            
            textBox6.Text = t1.ToString("###,##0.00");
            textBox5.Text = t2.ToString("###,##0.00");
            textBox4.Text = numericUpDown5.Value.ToString("###,##0.00");
            
            string m1 = "P" + t1 / 0.20 + t2 / 0.25 + z;
            serialPort1.Write(m1);
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
            pt2 = t2;
            pt1 = t1;

            textBox6.Text = numericUpDown7.Value.ToString("###,##0.00");
            textBox5.Text = numericUpDown9.Value.ToString("###,##0.00");
            textBox4.Text = numericUpDown8.Value.ToString("###,##0.00");
            textBox3.Text = numericUpDown8.Value.ToString("###,##0.00");

            t1 = t1 * Math.PI / 180; 
            t2 = t2 * Math.PI / 180;
            double x = L1 * Math.Cos(t1) + L2 * Math.Cos(t1 + t2);
            textBox1.Text = x.ToString("###,##0.00");
            double y = L1 * Math.Sin(t1) + L2 * Math.Sin(t1 + t2);
            textBox2.Text = y.ToString("###,##0.00");

            t1 = t1 * 180 / Math.PI;
            t2 = t2 * 180 / Math.PI;

            textBox1.Text = x.ToString("###,##0.00");
            textBox2.Text = y.ToString("###,##0.00");

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
