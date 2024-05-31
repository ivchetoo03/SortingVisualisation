using System;
using System.Linq;
using System.Windows.Forms;

namespace SortingVisualisatioon
{
    public partial class InputForm : Form
    {
        public int[] Array;

        public InputForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Array = txtArrayInput.Text.Split(' ').Select(int.Parse).ToArray();
                foreach(int number in Array)
                {
                    if(number < -50000 || number > 50000)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Число не входить в допустимий діапазон (50.000 / 50.000)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть коректні числа, розділені пробілом", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}