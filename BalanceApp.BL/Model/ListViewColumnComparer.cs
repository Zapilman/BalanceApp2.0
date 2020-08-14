using System;
using System.Collections;
using System.Windows.Forms;

namespace BalanceApp.BL.Model
{
     public class ListViewColumnComparer : IComparer
    {
        public int ColumnIndex { get; set; }

        public ListViewColumnComparer(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }

        public int Compare(object x, object y)
        {
            try
            {
                if(String.Compare(
                ((ListViewItem)x).SubItems[ColumnIndex].Text,
                ((ListViewItem)y).SubItems[ColumnIndex].Text) == 1)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception) 
            {
                return 0;
            }
        }
    }
}
