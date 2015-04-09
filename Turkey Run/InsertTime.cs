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
    public partial class InsertTime : Form
    {
        public InsertTime()
        {
            InitializeComponent();
        }

        private void athDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.athDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turkeyDBDataSet);

        }

        private void InsertTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turkeyDBDataSet.athData' table. You can move, or remove it, as needed.
            this.athDataTableAdapter.Fill(this.turkeyDBDataSet.athData);
            
            foreach (DataRow row in turkeyDBDataSet.athData.Rows)
            {
                nameDrop.Items.Add(row["Name"]);
            }
           

        }

        private void startDialog_Click(object sender, EventArgs e)
        {
            openTimes.ShowDialog();
            System.IO.Stream ioStream = openTimes.OpenFile();
            insertTimes(ioStream);
        }

        private void insertTimes(System.IO.Stream file)
        {
            CSV_Parse parser = new CSV_Parse(file);
            String[] times = parser.read();

            foreach (String time in times)
            {
                if (time != null) timeList.Items.Add(time);
            }
        }

        private void nameDrop_Clicked(object sender, EventArgs e)
        {
            object item = nameDrop.SelectedItem;
            if ( item != null && nameDrop.DroppedDown) nameList.Items.Add(item);
            nameDrop.Items.Remove(item);
        }

        private void nameList_KeyPresed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                nameList.Items.Remove(nameList.SelectedItem);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            turkeyDBDataSet.AcceptChanges();
            for (int i = 0; i < nameList.Items.Count; i++)
            {
                for (int j = 0; j < turkeyDBDataSet.athData.Rows.Count; j++ )
                {
                    if (nameList.Items[i] == turkeyDBDataSet.athData.Rows[j]["Name"])
                    {
                        String time = (string) timeList.Items[i];
                        String[] components = time.Split(':');
                        double minutes = double.Parse(components[0])*60 + double.Parse(components[1]);
                        double seconds = double.Parse(components[2]);
                        seconds = Math.Round(seconds);

                        TimeSpan tMinutes = TimeSpan.FromMinutes(minutes);
                        TimeSpan tSeconds = TimeSpan.FromSeconds(seconds);
                        tMinutes = tMinutes.Add(tSeconds);

                        turkeyDBDataSet.athData.Rows[j].BeginEdit();
                        turkeyDBDataSet.athData.Rows[j].SetField("Actual Time", tMinutes);
                        turkeyDBDataSet.athData.Rows[j].EndEdit();
                        athDataTableAdapter.Update(turkeyDBDataSet);
                    }
                }
            }
            
            this.Close();
        }

    }
}
