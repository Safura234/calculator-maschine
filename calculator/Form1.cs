using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        char _operation;
        bool _TextResultClear;
        int FirstCount;
        public Calculator()
        {
            InitializeComponent();
        }

        private void TextResult_Click(object sender, EventArgs e)
        {
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "8";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";  
            TextResult.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "2";

        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "7";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (_TextResultClear)
            {
                TextResult.Text = "";
                _TextResultClear = false;
            }
            if (TextResult.Text == "0") TextResult.Text = "";
            TextResult.Text += "0";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _TextResultClear = true;
            FirstCount = Convert.ToInt32(TextResult.Text);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            int SecondCount = Convert.ToInt32(TextResult.Text);
            int Result;
            switch (_operation)
            {
                case '+':
                    Result = FirstCount + SecondCount;
                    break;  
                    case '-':   
                    Result = FirstCount - FirstCount;
                    break;
                case '*':
                    Result = FirstCount * SecondCount;
                    break;
                case '/':
                    Result = FirstCount / SecondCount;
                    break;
                    default:
                    Result = 0;
                    break;


            }
            TextResult.Text = Convert.ToString(Result);
        }

        private void Minus_Click_1(object sender, EventArgs e)
        {
            _operation = '-';
            _TextResultClear = true;
            FirstCount = Convert.ToInt32(TextResult.Text);
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _TextResultClear = true;
            FirstCount = Convert.ToInt32(TextResult.Text);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _TextResultClear = true;
            FirstCount = Convert.ToInt32(TextResult.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextResult.Text = "0";
        }
    }
}
