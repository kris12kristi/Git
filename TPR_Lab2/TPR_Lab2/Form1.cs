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

namespace TPR_Lab2
{
    public partial class Form1 : Form
    {
        public string[] text;
        // public double[,] inputArray;
        double[][] inputArray = new double[5][];


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTxtButton_Click(object sender, EventArgs e)
        {
           
            inputArray[0] = new double[5];
            inputArray[1] = new double[5];
            inputArray[2] = new double[2];
            inputArray[3] = new double[5];
            inputArray[4] = new double[5];

            //double tempDouble;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "x:\\";
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

                                //   inputArray = new double[1, 5];
                             //   inputArray[i].Length

                                for (int i = 0; i < 5; i++)
                                {
                                    string[] temp = text[i].Split(' ');
                                    for (int j = 0; j <temp.Length; j++)
                                    {
                                       // tempDouble = Convert.ToDouble(temp[j]);
                                        inputArray[i][j] =  Double.Parse(temp[j]);
                                    }

                                }

                                textBox1.Text = inputArray[0][0].ToString();
                                textBox2.Text = inputArray[0][1].ToString();
                                textBox3.Text = inputArray[0][2].ToString();
                                textBox4.Text = inputArray[0][3].ToString();
                                textBox5.Text = inputArray[0][4].ToString();

                                textBox6.Text = inputArray[1][0].ToString();
                                textBox7.Text = inputArray[1][1].ToString();
                                textBox8.Text = inputArray[1][2].ToString();
                                textBox9.Text = inputArray[1][3].ToString();
                                textBox10.Text = inputArray[1][4].ToString();

                                textBox11.Text = inputArray[2][0].ToString();
                                textBox12.Text = inputArray[2][1].ToString();

                                textBox13.Text = inputArray[3][0].ToString();
                                textBox14.Text = inputArray[3][1].ToString();
                                textBox15.Text = inputArray[3][2].ToString();
                                textBox16.Text = inputArray[3][3].ToString();
                                textBox17.Text = inputArray[3][4].ToString();

                                textBox18.Text = inputArray[4][0].ToString();
                                textBox19.Text = inputArray[4][1].ToString();
                                textBox20.Text = inputArray[4][2].ToString();
                                textBox21.Text = inputArray[4][3].ToString();
                                textBox22.Text = inputArray[4][4].ToString();

                                textBox23.Text = textBox3.Text;
                                textBox26.Text = textBox5.Text;

                                textBox30.Text = textBox8.Text;
                                textBox28.Text = textBox10.Text;

                                textBox31.Text = textBox15.Text;
                                textBox34.Text = textBox17.Text;


                                textBox38.Text = textBox20.Text;
                                textBox36.Text = textBox22.Text;

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

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void BranchA_Button_Click(object sender, EventArgs e)
        {
            textBox23.Text = textBox3.Text;
            textBox26.Text = textBox5.Text;

            double a = Convert.ToDouble(textBox3.Text);
            double income = a * 5;
            IncomDuring5Year_BrA.Text = (income).ToString();

            double b = Convert.ToDouble(textBox5.Text);
            double waste = b * 5;
            WasteDuring5Year_BrA.Text = (waste).ToString();

            double p1 = Convert.ToDouble(textBox2.Text);
            double p2 = Convert.ToDouble(textBox4.Text);
            double buildCost = Convert.ToDouble(textBox1.Text);

            A_BranchRezultTextBox.Text = (p1 * income - p2 * waste - buildCost).ToString();
        }

        private void BranchB_Button_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox8.Text;
            textBox28.Text = textBox10.Text;

            double a = Convert.ToDouble(textBox8.Text);
            double income = a * 5;
            IncomDuring5Year_BrB.Text = (income).ToString();

            double b = Convert.ToDouble(textBox10.Text);
            double waste = b * 5;
            WasteDuring5Year_BrB.Text = (waste).ToString();

            double p1 = Convert.ToDouble(textBox7.Text);
            double p2 = Convert.ToDouble(textBox9.Text);
            double buildCost = Convert.ToDouble(textBox6.Text);

            B_BranchRezultTextBox.Text = (p1 * income - p2 * waste - buildCost).ToString();

        }

        private void BranchC_Button_Click(object sender, EventArgs e)
        {
            //Branch A1
            textBox31.Text = textBox15.Text;
            textBox34.Text = textBox17.Text;

            double a = Convert.ToDouble(textBox15.Text);
            double income = a * 4;
            IncomDuring4Year_BrA1.Text = (income).ToString();

            double b = Convert.ToDouble(textBox17.Text);
            double waste = b * 4;
            WasteDuring4Year_BrA1.Text = (waste).ToString();

            double p1 = Convert.ToDouble(textBox14.Text);
            double p2 = Convert.ToDouble(textBox16.Text);
            double buildCost = Convert.ToDouble(textBox13.Text);

            double A1 = p1 * income - p2 * waste - buildCost;
            C_BranchA1RezultTextBox.Text = (A1).ToString();

  
            //Branch B1
            textBox38.Text = textBox20.Text;
            textBox36.Text = textBox22.Text;

            double a1 = Convert.ToDouble(textBox20.Text);
            double income1 = a1 * 4;
            IncomDuring4Year_BrB1.Text = (income1).ToString();

            double b1 = Convert.ToDouble(textBox22.Text);
            double waste1 = b1 * 4;
            WasteDuring4Year_BrB1.Text = (waste1).ToString();

            double p1_1 = Convert.ToDouble(textBox19.Text);
            double p2_1 = Convert.ToDouble(textBox21.Text);
            double buildCost1 = Convert.ToDouble(textBox18.Text);

            double B1 = p1_1 * income1 - p2_1 * waste1 - buildCost1;
            C_BranchB1RezultTextBox.Text = (B1).ToString();
           
            //Rezult after 1 year (poit 2)
            double halfRezult = Math.Max(A1, B1);
            C_BranchHalfRezultTextBox.Text = (halfRezult).ToString();

            //Branch C
            double p1_2 = Convert.ToDouble(textBox11.Text);
            double p2_2 = Convert.ToDouble(textBox12.Text);

            double F = Convert.ToDouble(textBox24.Text);

            C_BranchRezultTextBox.Text = (p1_2 * halfRezult - p2_2 * F).ToString();
        }

        private void RezultButton_Click(object sender, EventArgs e)
        {
            double branchA = Convert.ToDouble(A_BranchRezultTextBox.Text);
            double branchB = Convert.ToDouble(B_BranchRezultTextBox.Text);
            double branchC = Convert.ToDouble(C_BranchRezultTextBox.Text);

            double rezult = Math.Max(branchA, Math.Max(branchB, branchC));

            if (rezult == branchA) label1.Text = "Оптимальний варіант: А\n Будівництво великого заводу";
            else if (rezult == branchB) label1.Text = "Оптимальний варіант: Б\n Будівництво малого заводу";
            else label1.Text = "Оптимальний варіант: В\n Відкласти будівництво";

            OptRezultTextBox.Text = (rezult).ToString();


        }

        private void FastRezultButton_Click(object sender, EventArgs e)
        {
            BranchA_Button_Click(null, null);
            BranchB_Button_Click(null, null);
            BranchC_Button_Click(null, null);

            RezultButton_Click(null,null);

        }
    }
}
