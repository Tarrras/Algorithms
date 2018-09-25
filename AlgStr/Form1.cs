using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgStr
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog;
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Dictionary<int, string> myDictionarySecond = new Dictionary<int, string>();
        string line;
        Random random=new Random();
        int[] keys;
        int j=0,k=0,id,myKey;
        static int iter=0;
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadList(object o, EventArgs eventArgs)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files|*.txt";
            openFileDialog.InitialDirectory = "D:\\Alg";
            openFileDialog.ValidateNames = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                try
                {
                    StreamReader stream = new StreamReader(openFileDialog.FileName,Encoding.Default);
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] mass = line.Split(' ');
                        j = int.Parse(mass[0]);
                        string nameOf = mass[1] + " " + mass[2];
                        myDictionary.Add(j, nameOf);
                    }
                    keys = myDictionary.Keys.ToArray();
                    stream.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to upload file: " + e);
                }
                foreach (KeyValuePair<int, string> keyValue in myDictionary)
                {
                    richTextBox1.Text += string.Format("{0} {1}\n", keyValue.Key, keyValue.Value);
                }
            }
            else throw new Exception("Failed to upload file");
            //foreach (KeyValuePair<int, string> keyValue in myDictionary)
            //{
            //    keys[temp] = keyValue.Key;
            //    temp++;
            //}
        }


        /////////////////////////////////////////////////////// СЛИЯНИЕ
        private void Sliyanie_Click(object sender, EventArgs e)
        {
            keys=sortMerge(keys);
            CreateDictionary();
            ShowDictionary();
            AddToSortirovki("Сортировка слиянием");
        }
        public static int[] sortMerge(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return merge(sortMerge(massive.Take(mid_point).ToArray()), sortMerge(massive.Skip(mid_point).ToArray()));
        }
        public static int[] merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                    {
                        merged[i] = mass2[b++];
                    }
                    else
                    { //if int go for
                        merged[i] = mass1[a++];
                    }
                else
                    if (b < mass2.Length)
                    {
                        merged[i] = mass2[b++];
                    }
                else
                {
                    merged[i] = mass1[a++];
                }
                iter++;
            }
            return merged;
        }
        /////////////////////////////////////////////////////// СЛИЯНИЕ


        /////////////////////////////////////////////////////// БЛОЧНАЯ
        private void Blochnaya_Click(object sender, EventArgs e)
        {
            keys = BucketSort(keys);
            CreateDictionary();
            ShowDictionary();
            AddToSortirovki("Блочная сортировка");
        }

        public static int[] BucketSort(int[] items)
        {
            // Предварительная проверка элементов исходного массива
            if (items == null || items.Length < 2)
                return items;
            // Поиск элементов с максимальным и минимальным значениями
            int maxValue = items[0];
            int minValue = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] > maxValue)
                {
                    maxValue = items[i];
                   
                }

                if (items[i] < minValue)
                {
                    minValue = items[i];
                    
                }
                iter++;
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
                iter++;
            }

            // Занесение значений в пакеты

            for (int i = 0; i < items.Length; i++)
            {
                bucket[items[i] - minValue].Add(items[i]);
                iter++;
            }

            // Восстановление элементов в исходный массив
            // из карманов в порядке возрастания значений

            int position = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        items[position] = bucket[i][j];
                        position++;
                        iter++;
                    }
                }
            }
            return items;
        }
        ///////////////////////////////////////////////////////БЛОЧНАЯ


        ///////////////////////////////////////////////////////ШЕЛЛА
        private void Shella_Click(object sender, EventArgs e)
        {
            keys = shellSort(keys);
            CreateDictionary();
            ShowDictionary();
            AddToSortirovki("Сортировка Шелла");
        }
        public static int[] shellSort(int[] vector)
        {
            if (vector == null || vector.Length < 2)
                return vector;
            int step = vector.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < vector.Length; i++)
                {
                    int value = vector[i];
                    for (j = i - step; (j >= 0) && (vector[j] > value); j -= step)
                    {
                        vector[j + step] = vector[j];
                        
                    }
                    iter++;
                    vector[j + step] = value;
                }
                step /= 2;
            }
            return vector;
        }
        ///////////////////////////////////////////////////////ШЕЛЛА


        ///////////////////////////////////////////////////////БЫСТРАЯ
        private void bustraya_Click(object sender, EventArgs e)
        {
            keys = sorting(keys,0,keys.Length-1);
            CreateDictionary();
            ShowDictionary();
            AddToSortirovki("Быстрая сортировка");
        }
        public static int[] sorting(int[] arr,int first,int last)
        {
            if (arr == null || arr.Length < 2)
                return arr;
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last)
                {
                    ++i;
                    iter++;
                }
                while (arr[j] > p && j >= first)
                {
                    --j;
                    iter++;
                }
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                    
                }
                iter++;
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
            return arr;
        }
        ///////////////////////////////////////////////////////БЫСТРАЯ


        ///////////////////////////////////////////////////////ПИРАМИДАЛЬНАЯ
        private void pyramyde_Click(object sender, EventArgs e)
        {
            keys = Pyramid_Sort(keys,keys.Length);
            CreateDictionary();
            ShowDictionary();
            AddToSortirovki("Пирамидальная сортировка");
        }
        public static int add2pyramid(int[] arr, int i, int N)
        {
            int imax;
            int buf;
            if ((2 * i + 2) < N)
            {
                if (arr[2 * i + 1] < arr[2 * i + 2])
                {
                    imax = 2 * i + 2;
                }
                else
                {
                    imax = 2 * i + 1;
                }
            }
            else
            {
                imax = 2 * i + 1;
            }
            if (imax >= N) return i;
            if (arr[i] < arr[imax])
            {
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
                iter++;
            }
            return i;
        }

        public static int[] Pyramid_Sort(int[] arr, int len)
        {
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = add2pyramid(arr, i, len);
                if (prev_i != i) ++i;
                iter++;
            }

            int buf;
            for (int k = len - 1; k > 0; --k)
            {
                buf = arr[0];
                arr[0] = arr[k];
                arr[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    iter++;
                    prev_i = i;
                    i = add2pyramid(arr, i, k);
                }
                iter++;
            }
            return arr;
        }
        ///////////////////////////////////////////////////////ПИРАМИДАЛЬНАЯ


        private void keyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void readKey()
        {
            try
            {
                myKey = Convert.ToInt32(keyBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void showKey()
        {
            try
            {
                newKeyBox.Text = $"Position: {id + 1}, {myDictionary[myKey]}";
            }
            catch
            {
                MessageBox.Show($"Данный ключ отсуствует в словаре!");
            }
        }

        //ДВОИЧНЫЙ ----------------------------  ПОИСК
        private void searchForKeyBinary_Click(object sender, EventArgs e)
        {
            readKey();
            keys = sorting(keys, 0, keys.Length - 1);
            id = BinarySearch(keys, myKey);
            if (id == 0)
            {
                newKeyBox.Text = "Такого элемента не существует!";
            }
            else showKey();
            AddToPoiski("Бинарный поиск");
        }

        
        private static int BinarySearch(int[] a, int x)
        {

            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return 0;

            int first = 0;
            int last = a.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
                iter++;
            }

            if (a[last] == x)
                return last;
            else
                return 0;
        }
        //ДВОИЧНЫЙ ----------------------------  ПОИСК


        //ЛИНЕЙНЫЙ ---------------------------- ПОИСК
        private void searchForKeyLiner_Click(object sender, EventArgs e)
        {
            readKey();
            id = LinearSearch(keys, myKey);
            if (id == -1)
            {
                newKeyBox.Text = "Такого элемента не существует!";
            }
            else showKey();
            AddToPoiski("Линейный поиск");
        }
        public int LinearSearch(int[] array, int x)
        {
            int result = -1;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == x)
                {
                    result = index;
                    iter++;
                }
            }

            return result;
        }
        //ЛИНЕЙНЫЙ ---------------------------- ПОИСК

        //СТОРОЖ ---------------------------- ПОИСК
        private void searchForKeySentinel_Click(object sender, EventArgs e)
        {
            readKey();
            id = SentinelLinearSearch(keys,keys.Length, myKey);
            if (id == -1)
            {
                newKeyBox.Text = "Такого элемента не существует!";
            }
            else showKey();
            AddToPoiski("Поиск со сторожем");
        }
        public int SentinelLinearSearch(int[] array, int count, int x)
        {
            int last = array[count - 1];
            array[count - 1] = x;

            int index = 0;

            while (array[index] != x)
            {
                index++;
                iter++;
            }

            array[count - 1] = last;

            if (index < count - 1 || array[count - 1] == x)
            {
                return index;
            }

            return -1;
        }
        //СТОРОЖ ---------------------------- ПОИСК

        //ИНТЕПОЛЯЦИОННЫЙ ---------------------------- ПОИСК
        private void interpolyarnui_Click(object sender, EventArgs e)
        {
            readKey();
            keys = sorting(keys, 0, keys.Length - 1);
            id = interpolationSearch(keys, myKey);
            if (id == -1)
            {
                newKeyBox.Text = "Такого элемента не существует!";
            }
            else showKey();
            AddToPoiski("Интерполляционный поиск");
        }

        public int interpolationSearch(int[] sortedArray, int toFind)
        {
            int mid;
            int low = 0;
            int high = sortedArray.Length - 1;

            while (sortedArray[low] < toFind && sortedArray[high] > toFind)
            {
                mid = low + ((toFind - sortedArray[low]) * (high - low)) / (sortedArray[high] - sortedArray[low]);

                if (sortedArray[mid] < toFind)
                    low = mid + 1;
                else if (sortedArray[mid] > toFind)
                    high = mid - 1;
                else
                    return mid;
                iter++;
            }

            if (sortedArray[low] == toFind)
                return low;
            else if (sortedArray[high] == toFind)
                return high;
            else
                return -1; // Not found
        }
        //ИНТЕПОЛЯЦИОННЫЙ ---------------------------- ПОИСК

        //ФИБОНАЧИ ---------------------------- ПОИСК
        private void searchForKeyFibonachi_Click(object sender, EventArgs e)
        {
            readKey();
            keys = sorting(keys, 0, keys.Length - 1);
            id = fibMonaccianSearch(keys, myKey,keys.Length);
            if (id == -1)
            {
                newKeyBox.Text = "Такого элемента не существует!";
            }
            else showKey();
            AddToPoiski("Поиск Фибоначи");
        }
        public static int min(int x, int y)
        {
            return (x <= y) ? x : y;
        }

        
        public static int fibMonaccianSearch(int[] arr,int x, int n)
        {            
            int fibMMm2 = 0; 
            int fibMMm1 = 1; 
            int fibM = fibMMm2 + fibMMm1; 

            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
                iter++;
            }
            
            int offset = -1;
            
            while (fibM > 1)
            {                
                int i = min(offset + fibMMm2, n - 1);

                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                    iter++;
                }

                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    iter++;
                }
                
                else return i;
            }

            if (fibMMm1 == 1 && arr[offset + 1] == x)
                return offset + 1;

            return -1;
        }



        //ФИБОНАЧИ ---------------------------- ПОИСК


        public void DeleteList(object o, EventArgs eventArgs)
        {
            k = 0;
            keys = null;
            richTextBox1.Clear();
            myDictionary.Clear();
            myDictionarySecond.Clear();
            richTextBox2.Clear();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            foreach (string line in richTextBox1.Lines)
            {
                string[] mass = line.Split(' ','\n',',','-');
                j = int.Parse(mass[0]);
                string nameOf = mass[1] + " " + mass[2];
                myDictionary.Add(j, nameOf);
            }
            keys = myDictionary.Keys.ToArray();
        }

        public void CreateDictionary()
        {
            foreach (KeyValuePair<int, string> keyValue in myDictionary)
            {
                for (int i = k; i < keys.Length;)
                {
                    myDictionarySecond.Add(keys[i], myDictionary[keys[i]]);
                    k++;
                    break;
                }
            }
        }

        private void clearKeyBox_Click(object sender, EventArgs e)
        {
            keyBox.Clear();
            newKeyBox.Clear();

        }

        public void ShowDictionary()
        {
            foreach (KeyValuePair<int, string> keyValue in myDictionarySecond)
            {
                richTextBox2.Text += string.Format("{0} {1}\n", keyValue.Key, keyValue.Value);
            }
        }

        public void AddToSortirovki(string name)
        {
            Sortirovki.Text+=name+": "+iter+"\n";
            iter = 0;
        }

        public void AddToPoiski(string name)
        {
            Poiski.Text += name + ": " + iter + "\n";
            iter = 0;
        }
    }
}
