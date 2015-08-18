using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.MainForm;

namespace Forms
{
    public partial class SplashScreenForm
    {
        private ShowResultForm _resultForm;

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxNumA.Text);
            int b = Convert.ToInt32(textBoxNumB.Text);
            int result = 0;

            string op = comboBoxOperation.SelectedItem.ToString();

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("Denominator can not be 0");
                        return;
                    }

                    result = a / b;
                    break;

                default:
                    result = 999999;
                    break;
            }

            if (_resultForm == null)
            {
                _resultForm = new ShowResultForm(result);
                _resultForm.FormClosed += RunWhenResultClosed;
                _resultForm.Shown += delegate
                {

                };
            }

            _resultForm.ShowDialog();

            textboxResults.Text += result + Environment.NewLine ;
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            if (_resultForm == null)
            {
                MessageBox.Show("There is no history");
                return;
            }

            _resultForm.ShowDialog();
        }

        private void RunWhenResultClosed(object sender, EventArgs e)
        {
            textBoxNumA.Clear();
            textBoxNumB.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)

        {
            AboutForm _aF = new AboutForm();
            _aF.ShowDialog();
        }


    } 
}
