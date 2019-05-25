using System.Linq;
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
            int aux = (from CheckBox checkBox in checkBoxes
                       where checkBox.Checked
                       select checkBox).Count();

            return aux * value;
        }
    }
}
