using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseTheString
{
    public partial class ReverseString : Form
    {
        public ReverseString()
        {
            InitializeComponent();
        }

        public static string PassingText;

        private void ReverseString_Load(object sender, EventArgs e)
        {




        }

        

        private void reverseButton_Click (object sender, EventArgs e)
        {
            PassingText = reverseIt(InputBox.Text);
            wordOutput.Text = PassingText;
            
        }


        public string reverseIt(string input)
        {
            
            var stringToArray = input.Trim().ToArray();
            var letterList = new List<char>();

            for (var i = stringToArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                letterList.Add(stringToArray[i]);
            }
            var word = String.Join("", letterList.ToArray());
            Console.WriteLine(word);
            return word;
        }


    }
}
