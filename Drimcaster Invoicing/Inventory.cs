using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drimcaster_Invoicing
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            Column4.ValueType = typeof(string);
            Column4.ThreeState = true;
            Column5.ValueType = typeof(string);
            Column5.ThreeState = true;
            Column8.ValueType = typeof(string);
            Column8.ThreeState = true;

            dataGridView1.Rows.Add();
            DataGridViewRow dgrow = dataGridView1.Rows[0];
            //Number
            dgrow.Cells[0].ReadOnly = false;
            //has Tax
            (dgrow.Cells[3] as DataGridViewCheckBoxCell).ReadOnly = false;
            //has Discount
            (dgrow.Cells[4] as DataGridViewCheckBoxCell).ReadOnly = false;
            //is Active
            (dgrow.Cells[7] as DataGridViewCheckBoxCell).ReadOnly = false;
        }

        public CheckState check;

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.RowIndex1 == 0)
            {
                e.SortResult = 0;
                e.Handled = true;
            }
            else
            {
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ///MessageBox.Show(e.RowIndex.ToString());
            if (e.RowIndex > 0)
            {
                int getindex = e.RowIndex - 1;
                (dataGridView1.Rows[getindex].Cells[3] as DataGridViewCheckBoxCell).Value = "0";
                (dataGridView1.Rows[getindex].Cells[4] as DataGridViewCheckBoxCell).Value = "0";
                (dataGridView1.Rows[getindex].Cells[7] as DataGridViewCheckBoxCell).Value = "0";
               
                dataGridView1[0, getindex].Value = getindex.ToString();
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex1].Cells[0].Value = e.RowIndex1;
            for (int i = 1; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1[0, i].Value = i.ToString();
            }
        }
    }
}
