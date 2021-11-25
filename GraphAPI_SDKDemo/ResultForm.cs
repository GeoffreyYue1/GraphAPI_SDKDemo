using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAPI_SDKDemo
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(string result)
        {
            InitializeComponent();
            tbx_Result.Text = result;

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
