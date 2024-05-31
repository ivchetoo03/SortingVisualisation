using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SortingVisualisatioon
{
    public partial class MainForm : Form
    {
        private int[] numbers;
        private int lowerLimit;
        private int higherLimit;
        private int rectHeight;
        private double scale;
        private bool ifGenerated = false;
        private bool ifSorted = false;
        private bool ifSorting = false;
        private bool grid = false;
        private bool instantSort = false;
        private Graphics graphics;
        private Color sortingBackground = Color.DarkSlateBlue;

        public MainForm()
        {
            InitializeComponent();
            errorProvider1.SetError(quantityLabel, "Кількість випадкових чисел, що будуть генеруватися (не менше 100 та не більше 1.000.000, до 300 елементів сортування візуалізується анімацією)");
            errorProvider1.SetError(generationBorderLabel, "Межі, в яких генеруються значення чисел (мінімум -50.000, максимум 50.000)");
            errorProvider1.SetError(methodLabel, "Вибір методу, за яким буде відубватись сортування. Потрібно вибрати один із запропонованих");
            errorProvider1.SetError(sortingSpeedLabel, "Швидкість візуалізації алгоритму (не менше 1 і не більше 50)");
            graphics = this.panelDisplaySorting.CreateGraphics();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84: // WM_NCHITTEST
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1) // HTCLIENT (область клієнта)
                        m.Result = (IntPtr)0x2; // HTCAPTION (заголовок вікна)
                    return;
            }
            base.WndProc(ref m);
        }

        private void buttonToGenerateNumbers_Click(object sender, EventArgs e)
        {
            if (!ifSorting)
            {
                validateGenerationInput();
            }
        }

        private void buttonToSortNumbers_Click(object sender, EventArgs e)
        {
            if (ifGenerated && !ifSorting)
            {
                validateSortingInput();
            }
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            if (ifSorted) { SaveArraysToFile(numbers); }
        }

        private void manualInputButton_Click(object sender, EventArgs e)
        {
            if (!ifSorting)
            {
                using (InputForm inputForm = new InputForm())
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        numbers = inputForm.Array;
                        grid = true;
                        this.panelDisplaySorting.Visible = false;
                        this.numbersBox.Visible = true;
                        numbersBox.Text = string.Join(" ", numbers);
                        ifGenerated = true;
                    }
                }
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateNumbers()
        {
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(lowerLimit, higherLimit + 1);
            }
        }
        private void pickMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.pickMethodBox.SelectedItem.ToString())
            {
                case "Класичне сортування Шелла":
                    this.descriptionBox.Text = "Це поліпшена версія простого сортування вставками. Складність: в середньому - O(nlog2(n)), найгірший - O(n^2)." +
                        "\nВін працює шляхом створення “проміжного” списку, який містить елементи, розташовані на певній відстані один від одного." +
                        "\nДаний алгоритм може швидко переміщати елементи на великі відстані, що покращує ефективність сортування вставками, особливо для середніх та великих за розміром списків.";
                    break;

                case "Послідовність Седжвіка":
                    this.descriptionBox.Text = "Це одна з найефективніших послідовностей кроків для сортування Шелла. Складність: O(n^(4/3))" +
                        "\nВона визначається формулами: h = 1,5,19,41,109,209,505,929..." +
                        "\nЦя послідовність вибирає кроки так, щоб забезпечити добру збалансованість між кількістю кроків і ефективністю сортування, що дозволяє досягти високої швидкості виконання на практиці.";
                    break;

                case "Послідовність Фібоначі":
                    this.descriptionBox.Text = "Ця послідовність використовує числа Фібоначчі як кроки для сортування. Складність: O(n^(3/2))" +
                        "\nЧисла Фібоначчі визначаються рекурсивною формулою F(n) = F(n-1) + F(n-2)." +
                        "\nЦя послідовність обирає кроки, які швидко зменшуються, що дозволяє ефективно зменшити кількість невідсортованих ділянок. " +
                        "\nВона не є найефективнішою серед усіх можливих послідовностей, але все ж краще в порівнянні з довільними чи геометричними послідовностями.";
                    break;

                case "Послідовність Токуда":
                    this.descriptionBox.Text = "Дана послідовність є однією з ефективних реалізацій сортування Шелла та пропонує добре збалансовані кроки для оптимальної продуктивності." +
                        "\nСкладність: O(n^(5/3))" +
                        "\nПриклад перших кількох значень послідовності Токуда: 1, 4, 9, 20, 46, 103, ..." +
                        "\nПослідовність Токуда вважається однією з найефективніших для сортування Шелла, забезпечуючи швидше сортування на практиці для великих масивів.";
                    break;

                default:
                    break;
            }
        }
        private void instantSortCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.sortingSpeedBox.Visible = !this.sortingSpeedBox.Visible;
            this.sortingSpeedLabel.Visible = !this.sortingSpeedLabel.Visible;
            instantSort = !instantSort;

        }
        private void SaveArraysToFile(int[] sortedArray)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Зберегти масив";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine(string.Join(" ", sortedArray));
                        }

                        MessageBox.Show("Масив збережено успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при збереженні файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}