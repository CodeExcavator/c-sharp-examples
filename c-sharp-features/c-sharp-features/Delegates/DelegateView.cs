using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_features.Delegates
{
    public partial class DelegateView : Form
    {        
        private readonly WeirdCalculator _weirdCalculator;

        public int counter;

        public DelegateView()
        {
            InitializeComponent();
            _weirdCalculator = new WeirdCalculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                //Assign the method to the delegate
                _weirdCalculator.processNumbersDelegate = Calculator.Add;
                //Use the delegate
                var result = _weirdCalculator.processNumbersDelegate(a, b);
                lblResult.Text = "Result of addition: " + result;
            }
            else
            {
                lblResult.Text = "";
            }
        }

        private void btnSubtrack_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                //Assign the method to the delegate
                _weirdCalculator.processNumbersDelegate = Calculator.Subtract;
                //Use the delegate
                var result = _weirdCalculator.processNumbersDelegate(a, b);
                lblResult.Text = "Result of subtraction: " + result;
            }   
            else
            {
                lblResult.Text = "";
            }
        }

        private void btnWithMsg_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                lblResult.Text = _weirdCalculator.ProcessNumbersWithMsg(a, b);                                
            }   
            else
            {
                lblResult.Text = "";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                //Assign the method to the delegate, with an anonymous function
                //Verbose form
                //_weirdCalculator.processNumbersDelegate = delegate(int x, int y)
                //{
                //    return x * y; 
                //};
                //Simplified form
                _weirdCalculator.processNumbersDelegate = (x, y) => x * y;

                //Use the delegate
                var result = _weirdCalculator.processNumbersDelegate(a, b);
                lblResult.Text = "Result of multiplication: " + result;                  
            }   
            else
            {
                lblResult.Text = "";
            }
        }
    }
}
