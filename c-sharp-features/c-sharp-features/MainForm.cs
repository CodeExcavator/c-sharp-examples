using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c_sharp_features.Delegates;

namespace c_sharp_features
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDelegates_Click(object sender, EventArgs e)
        {
            DelegateView delegateView = new DelegateView();
            delegateView.Show();
        }
    }
}
