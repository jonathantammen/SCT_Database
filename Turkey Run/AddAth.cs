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
    public partial class AddAth : Form
    {
        public AddAth()
        {
            InitializeComponent();
        }

        private void athDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.athDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turkeyDBDataSet);

        }

        private void AddAth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turkeyDBDataSet.athData' table. You can move, or remove it, as needed.
            this.athDataTableAdapter.Fill(this.turkeyDBDataSet.athData);

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            String name = athNameText.Lines[0];

            String time = exTimeText.Lines[0];
            String[] components = time.Split(new char[] {':', '.'}, StringSplitOptions.None);
            TimeSpan timeMin = TimeSpan.FromMinutes(Double.Parse(components[0]));
            TimeSpan timeSec = TimeSpan.FromSeconds(Double.Parse(components[1]));

            timeMin = timeMin.Add(timeSec);
            athDataTableAdapter.Insert(name.GetHashCode(), name, timeMin, null);
            athDataTableAdapter.Update(this.turkeyDBDataSet);         
            this.Close();
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && athNameText.Focused)
            {
                exTimeText.Focus();
            }
            else if (e.KeyChar == (char)13 && exTimeText.Focused)
            {
                doneButton.Focus();
            }
            else if (e.KeyChar == (char)13 && doneButton.Focused)
            {
                doneButton_Click(sender, e);
            }
        }

     }
}
