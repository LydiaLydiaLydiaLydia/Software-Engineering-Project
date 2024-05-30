using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace FerrySYS
{
    internal class Utility
    {
        

        public static void fillComboBox(DataSet dataSet, ComboBox comboBox, String tableName, int columnNum)
        {
            comboBox.Items.Clear();
            for (int i = 0; i < dataSet.Tables[tableName].Rows.Count; i++)
            {
                comboBox.Items.Add(dataSet.Tables[0].Rows[i][columnNum].ToString());
            }
        }
    }
}
