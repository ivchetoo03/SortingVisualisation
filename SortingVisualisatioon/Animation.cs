using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;

namespace SortingVisualisatioon
{
    public partial class MainForm
    {
        private int DrawChance = 0;
        private int animationSpeed = 1;
        private int comparisons;
        private int swaps;
        Task sorting;
        Stopwatch stopwatch = new Stopwatch();

        private void StartSortingAnimation()
        {
            bool instant = this.instantSortCheck.Checked;

            comparisons = 0;
            swaps = 0;

            stopwatch.Reset();

            ifSorting = true;
            sorting = Task.Run(() =>
            {

                switch (this.pickMethodBox.SelectedItem.ToString())
                {
                    case "Класичне сортування Шелла":
                        ShellSort(numbers);
                        break;

                    case "Послідовність Седжвіка":
                        ShellSortSedgewick(numbers);
                        break;

                    case "Послідовність Фібоначі":
                        ShellSortFibonacci(numbers);
                        break;

                    case "Послідовність Токуда":
                        ShellSortTokuda(numbers);
                        break;

                    default:
                        break;
                }

                void ShellSort(int[] array)
                {
                    stopwatch.Start();
                    int n = array.Length;
                    for (int gap = n / 2; gap > 0; gap /= 2)
                    {
                        for (int i = gap; i < n; i += 1)
                        {
                            int temp = array[i];
                            int j;
                            for (j = i; j >= gap; j -= gap)
                            {
                                comparisons++;
                                if (array[j - gap] > temp)
                                {
                                    array[j] = array[j - gap];
                                    swaps++;
                                }
                                else
                                {
                                    break;
                                }

                                stopwatch.Stop();
                                if (DrawChance % animationSpeed == 0 && !grid && !instant) { RedrawNumbers(); }
                                else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                                DrawChance += 1;
                                stopwatch.Start();

                            }
                            array[j] = temp;
                        }

                        stopwatch.Stop();
                        if (!grid && !instant) { RedrawNumbers(); }
                        else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                        stopwatch.Start();
                    }
                    stopwatch.Stop();

                    if (!grid && instant) { RedrawNumbers(); }
                    else if (instant) { numbersBox.Text = string.Join(" ", array); }

                }
                void ShellSortSedgewick(int[] array)
                {
                    stopwatch.Start();
                    int[] sedgewickSequence = { 1, 5, 19, 41, 109, 209, 505, 929, 2161, 3905, 8929, 16001, 36289, 64769, 146305, 260609 };
                    int n = array.Length;

                    int intervalIndex = sedgewickSequence.Length - 1;
                    while (intervalIndex >= 0 && sedgewickSequence[intervalIndex] >= n)
                    {
                        intervalIndex--;
                    }

                    while (intervalIndex >= 0)
                    {
                        int interval = sedgewickSequence[intervalIndex];
                        for (int i = interval; i < n; i++)
                        {
                            int temp = array[i];
                            int j;
                            for (j = i; j >= interval; j -= interval)
                            {
                                comparisons++;
                                if (array[j - interval] > temp)
                                {
                                    array[j] = array[j - interval];
                                    swaps++;
                                }
                                else
                                {
                                    break;
                                }
                                stopwatch.Stop();
                                if (DrawChance % animationSpeed == 0 && !grid && !instant) { RedrawNumbers(); }
                                else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                                DrawChance += 1;
                                stopwatch.Start();
                            }
                            array[j] = temp;
                        }
                        intervalIndex--;

                        stopwatch.Stop();
                        if (!grid && !instant) { RedrawNumbers(); }
                        else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                        stopwatch.Start();
                    }
                    stopwatch.Stop();

                    if (!grid && instant) { RedrawNumbers();}
                    else if (instant) { numbersBox.Text = string.Join(" ", array); }
                }
                void ShellSortFibonacci(int[] array)
                {
                    stopwatch.Start();
                    int n = array.Length;
                    List<int> fibSequence = GenerateFibonacciSequence(n);

                    int intervalIndex = fibSequence.Count - 1;
                    while (intervalIndex >= 0 && fibSequence[intervalIndex] >= n)
                    {
                        intervalIndex--;
                    }

                    while (intervalIndex >= 0)
                    {
                        int interval = fibSequence[intervalIndex];
                        for (int i = interval; i < n; i++)
                        {
                            int temp = array[i];
                            int j;
                            for (j = i; j >= interval; j -= interval)
                            {
                                comparisons++;
                                if (array[j - interval] > temp)
                                {
                                    array[j] = array[j - interval];
                                    swaps++;
                                }
                                else
                                {
                                    break;
                                }
                                stopwatch.Stop();
                                if (DrawChance % animationSpeed == 0 && !grid && !instant) { RedrawNumbers(); }
                                else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                                DrawChance += 1;
                                stopwatch.Start();
                            }
                            array[j] = temp;
                        }
                        intervalIndex--;

                        stopwatch.Stop();
                        if (!grid && !instant) { RedrawNumbers(); }
                        else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                        stopwatch.Start();
                    }
                    stopwatch.Stop();

                    if (!grid && instant) { RedrawNumbers(); }
                    else if (instant) { numbersBox.Text = string.Join(" ", array); }

                    List<int> GenerateFibonacciSequence(int max)
                    {
                        List<int> sequence = new List<int> { 1, 1 };
                        int next = 2;
                        while (next <= max)
                        {
                            sequence.Add(next);
                            int count = sequence.Count;
                            next = sequence[count - 1] + sequence[count - 2];
                        }
                        return sequence;
                    }
                }
                void ShellSortTokuda(int[] array)
                {
                    stopwatch.Start();
                    int n = array.Length;
                    List<int> tokudaSequence = GenerateTokudaSequence(n);

                    // Починаємо з найбільшого інтервалу з послідовності Токуда, який менший за розмір масиву
                    int intervalIndex = tokudaSequence.Count - 1;
                    while (intervalIndex >= 0 && tokudaSequence[intervalIndex] >= n)
                    {
                        intervalIndex--;
                    }

                    // Виконуємо сортування з використанням вибраних інтервалів
                    while (intervalIndex >= 0)
                    {
                        int interval = tokudaSequence[intervalIndex];
                        for (int i = interval; i < n; i++)
                        {
                            int temp = array[i];
                            int j;
                            for (j = i; j >= interval; j -= interval)
                            {
                                comparisons++;
                                if (array[j - interval] > temp)
                                {
                                    array[j] = array[j - interval];
                                    swaps++;
                                }
                                else
                                {
                                    break;
                                }
                                stopwatch.Stop();
                                if (DrawChance % animationSpeed == 0 && !grid && !instant) { RedrawNumbers(); }
                                else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                                DrawChance += 1;
                                stopwatch.Start();
                            }
                            array[j] = temp;

                        }
                        intervalIndex--;

                        stopwatch.Stop();
                        if (!grid && !instant) { RedrawNumbers(); }
                        else if (!instant) { numbersBox.Text = string.Join(" ", array); }
                        stopwatch.Start();
                    }
                    stopwatch.Stop();

                    if (!grid && instant) { RedrawNumbers(); }
                    else if (instant) { numbersBox.Text = string.Join(" ", array); }

                    List<int> GenerateTokudaSequence(int max)
                    {
                        List<int> sequence = new List<int>();
                        int k = 1;
                        double value;
                        do
                        {
                            value = (Math.Pow(9, k) - Math.Pow(4, k)) / (5 * Math.Pow(4, k - 1));
                            sequence.Add((int)Math.Ceiling(value));
                            k++;
                        }
                        while ((int)Math.Ceiling(value) < max);
                        return sequence;
                    }
                }
                void RedrawNumbers()
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        RectangleHeight();
                        scale = (double)this.panelDisplaySorting.Height / rectHeight;

                        graphics.FillRectangle(
                            new SolidBrush(sortingBackground),
                            i * this.panelDisplaySorting.Width / numbers.Length, // X-координата ***
                            0, // Y-координата
                            this.panelDisplaySorting.Width / numbers.Length, // Ширина ***
                            this.panelDisplaySorting.Height // Висота
                            );

                        DrawRectangles(i);
                    }
                }

                this.time.Text = stopwatch.Elapsed.ToString();
                this.compCounter.Text = comparisons.ToString();
                this.swapCounter.Text = swaps.ToString();
                ifSorting = false;
                ifSorted = true;
            });
        }
        private void DrawNumbers()
        {
            graphics.Clear(sortingBackground);

            RectangleHeight();
            scale = (double)this.panelDisplaySorting.Height / rectHeight;

            for (int i = 0; i < numbers.Length; i++)
            {
                DrawRectangles(i);
            }
        }
        private void DrawRectangles(int i)
        {
            if (lowerLimit < 0 && higherLimit < 0)
            {
                graphics.FillRectangle(
                    Brushes.GhostWhite,
                    i * this.panelDisplaySorting.Width / numbers.Length, // X-координата ***
                    this.panelDisplaySorting.Height - (int)((double)-lowerLimit * scale), // Y-координата
                    this.panelDisplaySorting.Width / numbers.Length, // Ширина ***
                    (int)((double)-numbers[i] * scale) // Висота
                    );

            }
            else if (lowerLimit > 0 && higherLimit > 0)
            {
                graphics.FillRectangle(
                    Brushes.GhostWhite,
                    i * this.panelDisplaySorting.Width / numbers.Length, // X-координата ***
                    (this.panelDisplaySorting.Height - (int)((double)numbers[i] * scale))/* - (int)((double)lowerLimit * scale)*/, // Y-координата
                    this.panelDisplaySorting.Width / numbers.Length, // Ширина ***
                    (int)((double)numbers[i] * scale) // Висота
                    );
            }
            else
            {
                if (numbers[i] >= 0)
                {
                    graphics.FillRectangle(
                        Brushes.GhostWhite,
                        i * this.panelDisplaySorting.Width / numbers.Length, // X-координата ***
                        (this.panelDisplaySorting.Height - (int)((double)numbers[i] * scale)) - (int)((double)-lowerLimit * scale), // Y-координата
                        this.panelDisplaySorting.Width / numbers.Length, // Ширина ***
                        (int)((double)numbers[i] * scale) // Висота
                        );
                }
                else
                {
                    graphics.FillRectangle(
                        Brushes.GhostWhite,
                        i * this.panelDisplaySorting.Width / numbers.Length, // X-координата ***
                        this.panelDisplaySorting.Height - (int)((double)-lowerLimit * scale), // Y-координата
                        this.panelDisplaySorting.Width / numbers.Length, // Ширина ***
                        (int)((double)-numbers[i] * scale) // Висота
                        );
                }
            }
        }
        private void RectangleHeight()
        {
            if ((lowerLimit < 0 && higherLimit < 0) || (lowerLimit > 0 && higherLimit > 0))
            {
                rectHeight = Math.Max(Math.Abs(lowerLimit), Math.Abs(higherLimit));
            }
            else
            {
                rectHeight = Math.Abs(lowerLimit) + Math.Abs(higherLimit);
            }
        }
    }
}