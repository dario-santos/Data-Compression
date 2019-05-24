using System.Collections.Generic;
using System.Windows.Forms;

namespace Data_Compression_UI
{
    class ProgressBar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkBoxes">List of checkBoxes that will perform some task.</param>
        /// <param name="value">Number of times we will repeat each program.</param>
        /// <returns></returns>
        public static int SetMaximum(CheckBox[] checkBoxes, int value)
        {
            int aux = 0;

            foreach(CheckBox checkBox in checkBoxes)
                if(checkBox.Checked)
                    aux++;

            return aux * value;
        }
    }
}
