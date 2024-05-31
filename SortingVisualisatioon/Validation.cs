namespace SortingVisualisatioon
{
    public partial class MainForm {
        private void validateGenerationInput()
        {
            bool Validation = true;
            grid = false;
            ifSorted = false;
            ifGenerated = false;

            foreach (char c in quantityBox.Text)
            {
                if (!char.IsDigit(c))
                {
                    errorBox.Text = "Невірний ввід кількості елементів (присутні символи або недопустимі знаки)";
                    errorBox.Visible = true;
                    Validation = false;
                    break;
                }
            }

            if ((quantityBox.Text == "") && Validation)
            {
                errorBox.Text = "Введіть кількість елементів";
                errorBox.Visible = true;
                Validation = false;
            }
            else if (Validation)
            {
                numbers = new int[int.Parse(quantityBox.Text.ToString())];
                if ((numbers.Length < 100) && Validation)
                {
                    errorBox.Text = "Кількість чисел повинна бути щонайменше 100";
                    errorBox.Visible = true;
                    Validation = false;
                }
                else if ((numbers.Length > 1000000) && Validation)
                {
                    errorBox.Text = "Кількість чисел повинна бути щонайбільше 1.000.000";
                    errorBox.Visible = true;
                    Validation = false;
                }
            }

            if ((lowerLimitBox.Text == "") && Validation)
            {
                errorBox.Text = "Введіть нижню границю";
                errorBox.Visible = true;
                Validation = false;
            }
            else if((!int.TryParse(lowerLimitBox.Text, out lowerLimit)) && Validation)
            {
                errorBox.Text = "Невірний ввід нижньої границі (присутні символи або недопустимі знаки)";
                errorBox.Visible = true;
                Validation = false;
            }

            if ((higherLimitBox.Text == "") && Validation)
            {
                errorBox.Text = "Введіть верхню границю";
                errorBox.Visible = true;
                Validation = false;
            }
            else if ((!int.TryParse(higherLimitBox.Text, out higherLimit)) && Validation)
            {
                errorBox.Text = "Невірний ввід верхньої границі границі (присутні символи або недопустимі знаки)";
                errorBox.Visible = true;
                Validation = false;
            }

            if ((lowerLimit > higherLimit || lowerLimit == higherLimit) && Validation)
            {
                errorBox.Text = "Межі генерації виставлені невірно";
                errorBox.Visible = true;
                Validation = false;
            }
            else if ((lowerLimit < -50000) && Validation)
            {
                errorBox.Text = "Нижній ліміт має бути вище ніж -50.000";
                errorBox.Visible = true;
                Validation = false;
            }
            else if ((higherLimit > 50000) && Validation)
            {
                errorBox.Text = "Верхній ліміт має бути нижче ніж 50.000";
                errorBox.Visible = true;
                Validation = false;
            }

            if (Validation)
            {
                errorBox.Visible = false;
                ifGenerated = true;
                GenerateNumbers();
                if (numbers.Length <= 300)
                {
                    this.panelDisplaySorting.Visible = true;
                    this.numbersBox.Visible = false;
                    DrawNumbers();
                }
                else
                {
                    grid = true;
                    this.panelDisplaySorting.Visible = false;
                    this.numbersBox.Visible = true;
                    numbersBox.Text = string.Join(" ", numbers);
                }
            }
        }
        private void validateSortingInput()
        {
            bool Validation = true;
            ifSorted = false;

            if ((this.pickMethodBox.Text == "") && Validation)
            {
                errorBox.Text = "Виберіть метод сортування";
                errorBox.Visible = true;
                Validation = false;
            }

            if (!instantSort && Validation)
            {
                if ((sortingSpeedBox.Text == "") && Validation)
                {
                    errorBox.Text = "Введіть швидкість сортування";
                    errorBox.Visible = true;
                    Validation = false;
                }
                else if ((!int.TryParse(sortingSpeedBox.Text, out animationSpeed)) && animationSpeed <= 0 && Validation)
                {
                    errorBox.Text = "Невірний ввід швидкості сортування (присутні символи або недопустимі знаки)";
                    errorBox.Visible = true;
                    Validation = false;
                }
                else if (animationSpeed > 50 && Validation)
                {
                    errorBox.Text = "Швидкість сортування повинна бути щонайбільше 50";
                    errorBox.Visible = true;
                    Validation = false;
                }
                else if (Validation)
                {
                    errorBox.Visible = false;
                    StartSortingAnimation();
                    
                }
            }
            else if (Validation)
            {
                errorBox.Visible = false;
                StartSortingAnimation();
            }
        }
    }
}