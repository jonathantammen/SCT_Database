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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();

        }

        private void athDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.athDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turkeyDBDataSet);

        }

        void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

            this.athDataDataGridView[4, e.RowIndex].Value =

                (DateTime)this.athDataDataGridView[3, e.RowIndex].Value - (DateTime)this.athDataDataGridView[2, e.RowIndex].Value;
            this.athDataDataGridView.NotifyCurrentCellDirty(true);

        }

        private void Results_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turkeyDBDataSet.athData' table. You can move, or remove it, as needed.
            this.athDataTableAdapter.Fill(this.turkeyDBDataSet.athData);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] topTen = new String[10];
            TimeSpan[] diffs = new TimeSpan[athDataDataGridView.Rows.Count];
            for (int i = 0; i < 10; i++) topTen[i] = "";

            for (int j = 0; j < athDataDataGridView.Rows.Count; j ++) {
                if (athDataDataGridView.Rows[j].Cells[2].Value == null) continue;
                TimeSpan diff = ((TimeSpan)athDataDataGridView.Rows[j].Cells[2].Value).Subtract((TimeSpan)athDataDataGridView.Rows[j].Cells[1].Value).Duration();
                diffs[j] = diff;
            }
            Array.Sort(diffs);
            foreach (DataGridViewRow row in athDataDataGridView.Rows)
            {
                if (row.Cells[1].Value == null) break;

                for (int k = 0; k < 10; k++) {
                    if (k >= athDataDataGridView.Rows.Count || diffs[k] == null) break;
                    
                    if (((TimeSpan)row.Cells[2].Value).Subtract((TimeSpan)row.Cells[1].Value).Duration() == diffs[k]) topTen[k] = (String) row.Cells[0].Value;
                }
            }
            String output = "";
            for (int l = 0; l < 10; l++)
            {
                if (l >= athDataDataGridView.Rows.Count) break;
                if (topTen[l] == "") continue;
                string numeric = (l).ToString();
                string time = diffs[l].ToString();
                output = output + numeric + ". " + topTen[l] + "(" + time + ")\n";
            }
            
            MessageBox.Show(output);


        }
    }
}
