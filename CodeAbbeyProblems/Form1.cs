using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAbbeyProblems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dataOne, dataTwo;
        int iDataOne, iDataTwo;
        decimal problemNumber = 0;

       

        /// <summary>
        /// Executes selected problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProblemOne_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(problemNumber);
            switch(n)
            {
                case 1:
                    ExecuteProblemOne();
                    break;
                case 2:
                    ExecuteProblemTwo();
                    break;
                case 3:
                    ExecuteProblemThree();
                    break;
                case 4:
                    ExecuteProblemFour();
                    break;
                case 5:
                    ExecuteProblemFive();
                    break;
                case 6:
                    ExecuteProblemSix();
                    break;
                default:
                    break;

            }
        }

        private void numericUpDownProblemSelection_ValueChanged(object sender, EventArgs e)
        {
            problemNumber = numericUpDownProblemSelection.Value;
        }

        private void ExecuteProblemOne()
        {
            // take data from input one and two
            dataOne = textBoxInputOne.Text;
            dataTwo = textBoxInputTwo.Text;
            if (!(Int32.TryParse(dataOne, out iDataOne) && Int32.TryParse(dataTwo, out iDataTwo)))
            {
                MessageBox.Show("InputOne and InputTwo must be integers");
                return;
            }
            textBoxOutputOne.Text = Problems.SumOfTwoVars(iDataOne, iDataTwo).ToString();
        }

        private void ExecuteProblemTwo()
        {
            // data one = size of list
            // data two = list itself
            // take data from input one and two and convert
            dataOne = textBoxInputOne.Text;
            dataTwo = textBoxInputTwo.Text;
            int i;
            List<int> vals = new List<int>();
            foreach(string s in dataTwo.Split(' '))
            {
                if (!Int32.TryParse(s, out i))
                {
                    MessageBox.Show("InputTwo needs to be a list of integers");
                }
                vals.Add(i);
            }
            textBoxOutputOne.Text = Problems.SumInLoop(vals).ToString();
        }

        private void ExecuteProblemThree()
        {
            // data one = size of list
            // data two = list itself
            // take data from input one and two and convert
            dataOne = textBoxInputOne.Text;
            dataTwo = textBoxInputTwo.Text;
            int i;
            List<int> vals = new List<int>();
            // get each list
            foreach(string listS in dataTwo.Split(new char [] {',','\n'}))
            {
                List<int> curr_vals = new List<int>();
                // get each value
                foreach (string s in listS.Split(' '))
                {
                    if (!Int32.TryParse(s, out i))
                    {
                        MessageBox.Show("InputTwo needs to be a list of list of integers, separate ints by ' ' and lists by ','");
                        return;
                    }
                    curr_vals.Add(i);
                }
                vals.Add(curr_vals.Sum());
            }
            textBoxOutputOne.Clear();
            foreach(var v in vals)
            {
                
                textBoxOutputOne.Text += String.Format("{0} ", v.ToString());
            }
        }

        private void ExecuteProblemFour()
        {
            // data one = size of list
            // data two = list itself
            // take data from input one and two and convert
            dataOne = textBoxInputOne.Text;
            dataTwo = textBoxInputTwo.Text;
            int i;
            List<int> vals = new List<int>();
            // get each list
            foreach (string listS in dataTwo.Split(new char[] { ',', '\n' }))
            {
                List<int> curr_vals = new List<int>();
                // get each value
                foreach (string s in listS.Split(' '))
                {
                    if (!Int32.TryParse(s, out i))
                    {
                        MessageBox.Show("InputTwo needs to be a list of list of integers, separate ints by ' ' and lists by ','");
                        return;
                    }
                    curr_vals.Add(i);
                }
                vals.Add(Problems.MinOfTwoNumbers(curr_vals[0], curr_vals[1]));
            }
            textBoxOutputOne.Clear();
            foreach (var v in vals)
            {

                textBoxOutputOne.Text += String.Format("{0} ", v.ToString());
            }
        }
        private void ExecuteProblemFive()
        {
            // data one = size of list
            // data two = list itself
            // take data from input one and two and convert
            dataOne = textBoxInputOne.Text;
            dataTwo = textBoxInputTwo.Text;
            int i;
            List<int> vals = new List<int>();
            // get each list
            foreach (string listS in dataTwo.Split(new char[] { ',', '\n' }))
            {
                List<int> curr_vals = new List<int>();
                // get each value
                foreach (string s in listS.Split(' '))
                {
                    if (!Int32.TryParse(s, out i))
                    {
                        MessageBox.Show("InputTwo needs to be a list of list of integers, separate ints by ' ' and lists by ','");
                        return;
                    }
                    curr_vals.Add(i);
                }
                vals.Add(Problems.MinOfThreeNumbers(curr_vals[0], curr_vals[1], curr_vals[2]));
            }
            textBoxOutputOne.Clear();
            foreach (var v in vals)
            {

                textBoxOutputOne.Text += String.Format("{0} ", v.ToString());
            }
        }
    
        private void ExecuteProblemSix()
        {
            dataOne = textBoxInputOne.Text;
            string[] ss = dataOne.Split(' ');
            int len = ss.Count();
            int x;
            int[] values = new int[len];
            for (int i = 0; i < len; i++ )
            {
                Int32.TryParse(ss[i], out x);
                values[i] = x;
            }
            textBoxOutputOne.Clear();
            int[] output = Problems.MaximumOfAnArray(values);
            foreach (var v in output)
            {
                textBoxOutputOne.Text += String.Format("{0} ", v);
            }
        }
    
    } 
}
