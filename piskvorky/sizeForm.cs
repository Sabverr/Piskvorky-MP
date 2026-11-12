using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piskvorky
{
    public partial class SizeForm : Form
    {
        public int SelectedSize { get; private set; }

        public SizeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SelectedSize = (int)sizeInput.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
