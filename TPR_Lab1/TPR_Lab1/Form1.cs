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

namespace TPR_Lab1
{
    public partial class Form1 : Form
    {
        public string[] text;
        public int[,] inputArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadTxtButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string file = openFileDialog1.FileName;
                            try
                            {
                                text = File.ReadAllLines(file);
                               
                                inputArray = new int[3, 3];
                                for (int i = 0; i < 3; i++)
                                {
                                    string[] temp = text[i].Split(',');
                                    for (int j = 0; j < temp.Length; j++)
                                    {
                                        inputArray[i, j] = Int32.Parse(temp[j]);
                                    }

                                }


                                label1.Text = inputArray[0, 0].ToString();
                                label2.Text = inputArray[0, 1].ToString();
                                label3.Text = inputArray[0, 2].ToString();

                                label4.Text = inputArray[1, 0].ToString();
                                label5.Text = inputArray[1, 1].ToString();
                                label6.Text = inputArray[1, 2].ToString();

                                label7.Text = inputArray[2, 0].ToString();
                                label8.Text = inputArray[2, 1].ToString();
                                label9.Text = inputArray[2, 2].ToString();

                            }
                            catch (IOException)
                            {
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ValdaButton_Click(object sender, EventArgs e)
        {
            //first row
            int min = inputArray[0, 0];
            for (int j = 0; j < 3; j++)
            {
                if (min > inputArray[0, j]) {min = inputArray[0, j];}
            }
            Vald1_Label.Text = min.ToString();
            
            //second row
            int min2 = inputArray[1, 0];
            for (int j = 0; j < 3; j++)
            {
                if (min2 > inputArray[1, j]) {min2 = inputArray[1, j];}
            }
            Vald2_Label.Text = min2.ToString();

            //third row
            int min3 = inputArray[2, 0];
            for (int j = 0; j < 3; j++)
            {
                if (min3 > inputArray[2, j]) {min3 = inputArray[2, j];}
            }
            Vald3_Label.Text = min3.ToString();

            //find maxVald from rezults
            int maxVald = min;
            if (maxVald>min2)
            {
                if (maxVald > min3) maxVald = min;
                else
                {
                    if (min2 > min3) maxVald = min2;
                    else maxVald = min3;
                }
            }
            //viewe Rezult
            ValdRez_Label.Text = maxVald.ToString();
        }

        private void MaximButton_Click(object sender, EventArgs e)
        {
            int max = inputArray[0, 0];
            for (int j = 0; j < 3; j++)
            {
                if (max < inputArray[0, j]) {max = inputArray[0, j];}
            }
            Max1_Label.Text = max.ToString();

            int max2 = inputArray[1, 0];
            for (int j = 0; j < 3; j++)
            {
                if (max2 < inputArray[1, j]) {max2 = inputArray[1, j];}
            }
            Max2_Label.Text = max2.ToString();

            int max3 = inputArray[2, 0];
            for (int j = 0; j < 3; j++)
            {
                if (max3 < inputArray[2, j]) {max3 = inputArray[2, j];}
            }
            Max3_Label.Text = max3.ToString();

            //find maxMaxims from rezults
            int maxMaxims = max;
            if (maxMaxims > max2)
            {
                if (maxMaxims > max3) maxMaxims = max;
                else
                {
                    if (max2 > max3) maxMaxims = max2;
                    else maxMaxims = max3;
                }
            }
            //viewe Rezult
            MaxRez_Label.Text = maxMaxims.ToString();
        }

        private void Vald2_Label_Click(object sender, EventArgs e)
        {

           


        }

        private void LaplasaButton_Click(object sender, EventArgs e)
        {
            double laplas1, laplas2, laplas3;
            double p1 = 0.5, p2 = 0.35, p3 = 0.15;
            laplas1 = p1 * Convert.ToDouble(label1.Text) + p2 * Convert.ToDouble(label2.Text) + p3 * Convert.ToDouble(label3.Text);
            laplas2 = p1 * Convert.ToDouble(label6.Text) + p2 * Convert.ToDouble(label5.Text) + p3 * Convert.ToDouble(label4.Text);
            laplas3 = p1 * Convert.ToDouble(label7.Text) + p2 * Convert.ToDouble(label8.Text) + p3 * Convert.ToDouble(label9.Text);

            Laplas1_Label.Text = Math.Round(laplas1,1).ToString();
            Laplas2_Label.Text = Math.Round(laplas2,1).ToString();
            Laplas3_Label.Text = laplas3.ToString();

            //find maxLaplas from rezults
            double maxMaxims = laplas1;
            if (maxMaxims > laplas2)
            {
                if (maxMaxims > laplas3) maxMaxims = laplas1;
                else
                {
                    if (laplas2 > laplas3) maxMaxims = laplas2;
                    else maxMaxims = laplas3;
                }
            }
            //viewe Rezult
            LaplasRez_Label.Text = maxMaxims.ToString();

        }

        private void GyrvitzhaButton_Click(object sender, EventArgs e)
        {
            int[] minArray = new int[3];
            int[] maxArray = new int[3];

            double h1, h2, h3, kof = 0.7;

            //Find minArray
            int min = inputArray[0, 0];
            for (int j = 0; j < 3; j++)
            {
                if (min > inputArray[0, j]) {min = inputArray[0, j];}
            }
            minArray[0] = min;

            int min2 = inputArray[1, 0];
            for (int j = 0; j < 3; j++)
            {
                if (min2 > inputArray[1, j]) {min2 = inputArray[1, j];}
            }
            minArray[1] = min2;
            
            int min3 = inputArray[2, 0];
            for (int j = 0; j < 3; j++)
            {
                if (min3 > inputArray[2, j]){min3 = inputArray[2, j];}
            }
            minArray[2] = min3;

            //Find maxArray

            int max = inputArray[0, 0];
            for (int j = 0; j < 3; j++)
            {
                if (max < inputArray[0, j]){max = inputArray[0, j];}
            }
            maxArray[0] = max;

            int max2 = inputArray[1, 0];
            for (int j = 0; j < 3; j++)
            {
                if (max2 < inputArray[1, j]){max2 = inputArray[1, j];}
            }
            maxArray[1] = max2;

            int max3 = inputArray[2, 0];
            for (int j = 0; j < 3; j++)
            {
                if (max3 < inputArray[2, j]) {max3 = inputArray[2, j];}
            }
            maxArray[2] = max3;

            //Using formul
            h1 = kof * minArray[0] + (1 - kof) * maxArray[0];
            Gyrv1_Label.Text = h1.ToString();

            h2 = kof * minArray[1] + (1 - kof) * maxArray[1];
            Gyrv2_Label.Text = h2.ToString();

            h3 = kof * minArray[2] + (1 - kof) * maxArray[2];
            Gyrv3_Label.Text = h3.ToString();


            //find maxLaplas from rezults
            double maxGyrvitzh = h1;
            if (maxGyrvitzh > h2)
            {
                if (maxGyrvitzh > h3) maxGyrvitzh = h1;
                else
                {
                    if (h2 > h3) maxGyrvitzh = h2;
                    else maxGyrvitzh = h3;
                }
            }
            //viewe Rezult
            GyrvRez_Label.Text = maxGyrvitzh.ToString();

        }
    }
}
