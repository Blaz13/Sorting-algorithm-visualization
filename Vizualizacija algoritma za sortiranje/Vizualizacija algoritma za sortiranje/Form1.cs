using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizualizacija_algoritma_za_sortiranje
{
    public partial class Form1 : Form
    {

        public List<int> niz = new List<int>();
        private Random rand = new Random();
        private int visina;
        private int sirina;


        public void DrawIt(int start, int stop)
        {
            System.Drawing.Pen myPen, myEraser;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            myEraser = new System.Drawing.Pen(System.Drawing.SystemColors.Control);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();

            for (int i = start; i < stop; i++)
            {
                formGraphics.DrawLine(myEraser, 10 + i, visina, 10 + i, 0);
                formGraphics.DrawLine(myPen, 10 + i, visina - 50, 10 + i, visina - niz[i] - 50);
            }

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public int bubbleSort(List<int> niz)
        {
            bool zamjena = true;

            int counter = 0;
            int n = niz.Count();

            for (int i = 0; i < n && zamjena; ++i)
            {
                zamjena = false;
                for (int j = 0; j < n - 1 - i; ++j)
                {
                    counter++;
                    if (niz[j] > niz[j + 1])
                    {
                        zamjena = true;
                        int temp = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j + 1] = temp;
                    }
                }
                if (cbStep.Checked == true) {
                    DrawIt(0, sirina - i);
                }
            }
            DrawIt(0, sirina);
            return counter;
        }
        public int selectionSort(List<int> niz)
        {
            int minIndex, i, j, counter = 0;
            int n = niz.Count();

            for (i = 0; i < n; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                {
                    counter++;
                    if (niz[j] < niz[minIndex])
                    {
                        minIndex = j;
                    }                    
                }
                if (cbStep.Checked == true)
                {
                    DrawIt(i, minIndex);
                }
                int temp = niz[i];
                niz[i] = niz[minIndex];
                niz[minIndex] = temp;
                if (cbStep.Checked == true)
                {
                    DrawIt(i, sirina);
                }
            }

            DrawIt(0, sirina);
            return counter;
        }
        public int insertionSort(List<int> niz)
        {
            int counter = 0;
            int n = niz.Count();
            for (int i = 0; i < n; i++)
            {
                int temp = niz[i];
                int j;
                for (j = i; j >= 1 && niz[j - 1] > temp; j--)
                {
                    counter++;
                    niz[j] = niz[j - 1];
                }
                niz[j] = temp;
                if (cbStep.Checked == true)
                {
                    DrawIt(0, i);
                }
            }
            DrawIt(0, sirina);
            return counter;
        }
        public int shellSort(List<int> niz)
        {
            int i, j, korak, temp, counter = 0;
            int n = niz.Count();
            for (korak = n / 2; korak > 0; korak /= 2)
            {
                for (i = korak; i < n; i++)
                {
                    temp = niz[i];
                    for (j = i; j >= korak && niz[j - korak] > temp; j -= korak)
                    {
                        counter++;
                        niz[j] = niz[j - korak];
                    }
                    niz[j] = temp;
                }
                if (cbStep.Checked == true)
                {
                    DrawIt(0, sirina);
                }
            }
            DrawIt(0, sirina);
            return counter;
        }

        public int quickSort(List<int> niz, int left, int right)
        {
            if (cbStep.Checked == true)
            {
                DrawIt(left, right);
            }
            int counter = 0;
            if (niz == null || niz.Count <= 1)
                return counter;
            
            if (left < right)
            {
                counter++;
                int pivotIdx = MyPartition(niz, left, right, ref counter);
                //Console.WriteLine("MQS " + left + " " + right);
                //DumpList(list);                
                quickSort(niz, left, pivotIdx - 1);
                quickSort(niz, pivotIdx, right);                
            }
            return counter;
        }
        int MyPartition(List<int> list, int left, int right, ref int counter)
        {
            int start = left;
            int pivot = list[start];
            left++;
            right--;

            while (true)
            {
                while (left <= right && list[left] <= pivot)
                    left++;

                while (left <= right && list[right] > pivot)
                    right--;

                if (left > right)
                {
                    counter++;
                    list[start] = list[left - 1];
                    list[left - 1] = pivot;
                    counter++;
                    return left;
                }


                int temp = list[left];
                list[left] = list[right];
                list[right] = temp;

            }
        }

        /*void podesi(List<int> niz, int i, int n)
        {
            int j = 2 * i;
            int stavka = niz[i];
            while (j <= n)
            {
                if ((j < n) && (niz[j] < niz[j + 1]))
                {
                    j++;
                }
                if (stavka >= niz[j])
                {
                    break;
                }
                niz[j / 2] = niz[j];
                j *= 2;
            }
            niz[j / 2] = stavka;
        }

        void createHeap(List<int> niz)
        {
            int n = niz.Count() - 1;
            for (int i = n / 2; i >= 1; i--)
            {
                podesi(niz, i, n);
            }
        }
        int heapSort(List<int> niz)
        {
            int i, counter = 0;
            int n = niz.Count() - 1;
            createHeap(niz);
            for (i = n; i >= 2; i--)
            {
                int temp = niz[1];
                niz[1] = niz[i];
                niz[i] = temp;
                podesi(niz, 1, i - 1);
                if (cbStep.Checked == true)
                {
                    DrawIt(0, sirina);
                }
            }
            DrawIt(0, sirina);
            return counter;
        }*/
        void heapSort(List<int> niz)
        {
            int n = niz.Count;
            for (int p = (n - 1) / 2; p >= 0; p--)
                podesi(niz, n, p);

            for (int i = niz.Count - 1; i > 0; i--)
            {
                //Swap
                int temp = niz[i];
                niz[i] = niz[0];
                niz[0] = temp;
                if (cbStep.Checked == true)
                {
                    DrawIt(0, n);
                }
                n--;
                podesi(niz, n, 0);
            }
            DrawIt(0, sirina);
        }
        private static void podesi(List<int> input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                podesi(input, heapSize, largest);
            }
        }



        int mergeSort(List<int> niz, int lijevo, int desno)
        {
            if (cbStep.Checked == true)
            {
                DrawIt(lijevo, desno);
            }
            int sredina, counter = 0;
            counter++;
            if (desno > lijevo)
            {                
                sredina = (desno + lijevo) / 2;
                mergeSort(niz, lijevo, sredina);
                mergeSort(niz, (sredina + 1), desno);

                merge(niz, lijevo, (sredina + 1), desno, ref counter);
            }
            
            return counter;
        }

        void merge(List<int> niz, int lijevo, int sredina, int desno, ref int counter)
        {
            int[] temp = new int[niz.Count];
            int i, eol, num, pos;

            eol = (sredina - 1);
            pos = lijevo;
            num = (desno - lijevo + 1);

            while ((lijevo <= eol) && (sredina <= desno))
            {
                counter++;
                if (niz[lijevo] <= niz[sredina])
                    temp[pos++] = niz[lijevo++];
                else
                    temp[pos++] = niz[sredina++];
            }

            while (lijevo <= eol)
                temp[pos++] = niz[lijevo++];

            while (sredina <= desno)
                temp[pos++] = niz[sredina++];

            for (i = 0; i < num; i++)
            {
                niz[desno] = temp[desno];
                desno--;
            }
        }

        public int combSort(List<int> niz)
        {
            int counter = 0;
            double gap = niz.Count;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                if (cbStep.Checked == true)
                {
                    DrawIt(0, sirina);
                }
                gap /= 1.247330950103979;
                counter++;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < niz.Count)
                {
                    int igap = i + (int)gap;
                    counter++;
                    if (niz[i] > niz[igap])
                    {
                        int swap = niz[i];
                        niz[i] = niz[igap];
                        niz[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
            DrawIt(0, sirina);
            return counter;
        }
        public int[] countSort(List<int> niz)
        {
            int[] temp = new int[niz.Count];
            int[] counters = new int[niz.Count];
            int max = 0;
            for(int i=0; i<niz.Count; i++)
            {                
                counters[i] = 0;
                if (niz[i] > max)
                {                    
                    max = niz[i];
                }
            }
            for (int j = 0; j < niz.Count; j++)
            {
                counters[niz[j]] = counters[niz[j]] + 1;
            }

            for (int i = 1; i <= max; i++)
            {
                counters[i] = counters[i] + counters[i - 1];
            }

            for (int j = niz.Count - 1; j >= 0; j--)
            {
                temp[counters[niz[j]] - 1] = niz[j];
                counters[niz[j]] = counters[niz[j]] - 1;
            }

            for (int i = 0; i < niz.Count; i++)
            {
                niz[i] = temp[i];
                if (i != 0) {
                    if (cbStep.Checked == true)
                    {
                        DrawIt(i-1, i);
                    }
                }
            }

            return temp;
        }       


        public Form1()
        {
            InitializeComponent();
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            visina = Form1.ActiveForm.Size.Height;
            sirina = Form1.ActiveForm.Size.Width - 40;
            niz = new List<int>();
            for (int i = 0; i < sirina; ++i)
            {
                niz.Add(rand.Next(visina - 100));
            }
            DrawIt(0, sirina);
            lblNum.Text = sirina.ToString();
            
        }

        private void bttnSort_Click(object sender, EventArgs e)
        {
            int odabir = cbOdabir.SelectedIndex;

            switch (odabir)
            {
                case 0:
                    insertionSort(niz);
                    break;

                case 1:
                    selectionSort(niz);
                    break;

                case 2:
                    bubbleSort(niz);
                    break;

                case 3:
                    quickSort(niz, 0, niz.Count);
                    DrawIt(0, sirina);
                    break;

                case 4:
                    mergeSort(niz, 0, niz.Count-1);
                    DrawIt(0, sirina);
                    break;

                case 5:
                    heapSort(niz);
                    break;

                case 6:
                    combSort(niz);
                    break;

                case 7:
                    shellSort(niz);
                    break;

                case 8:
                    countSort(niz);
                    DrawIt(0, sirina);
                    break;
            }
        }

        private void cbStep_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
