using System;
using System.Collections;

using System.Windows.Forms;

namespace BalanceApp.BL.Model
{
    public class ReverseColumnComparer : IComparer
    {
        public int ColumnIndex { get; set; }

        public ReverseColumnComparer(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }

        public int Compare(object x, object y)
        {
            try
            {
                return String.Compare(
                ((ListViewItem)x).SubItems[ColumnIndex].Text,
                ((ListViewItem)y).SubItems[ColumnIndex].Text);

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
