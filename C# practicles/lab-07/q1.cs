using System;
using System.Windows.Forms;

namespace FirstFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            // Open the second form
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }
    }
}




using System;
using System.Windows.Forms;

namespace SecondFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
