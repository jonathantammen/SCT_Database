using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turkey_Run
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            

        }

        private void addAthButton_Click(object sender, EventArgs e)
        {
            AddAth addAth = new AddAth();
            addAth.ShowDialog();

        }

        private void insertTimeButton_Click(object sender, EventArgs e)
        {
            InsertTime insertTime = new InsertTime();
            insertTime.ShowDialog();
        }

        private void getResButton_Click(object sender, EventArgs e)
        {
            Results results = new Results();
            results.ShowDialog();
        }
    }
}
