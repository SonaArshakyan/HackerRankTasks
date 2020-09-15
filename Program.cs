using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
//using textWriter = System.Console;

namespace HackerRankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //****************************************************************************************String Tasks
            // Task1 hackerrank (HackerRank in a String)
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    string result = hackerrankInString(s);
            //    textWriter.WriteLine(result);
            //}

            // Task2 hackerrank (Strong Password)
            //int n = Convert.ToInt32(Console.ReadLine());
            //string password = Console.ReadLine();
            //int answer = minimumNumber(n, password);
            //Console.WriteLine(answer);


            //Task4 Sherlock and the Valid String 
            //string s = Console.ReadLine();  //File.ReadAllText("test.txt");
            //// string s = Console.In.ReadToEnd();
            //string result = isValid(s);
            //Console.WriteLine(result);

            //Task3 hackerrank (Two Characters)
            //int l = Convert.ToInt32(Console.ReadLine().Trim());
            //string s = File.ReadAllText("test.txt");
            //int result = alternate(s);
            //Console.WriteLine(result);

            //Task4 Funny String
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    string result = funnyString(s);
            //    Console.WriteLine(result);
            //}

            //Task5  Gemstones
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    string arrItem = Console.ReadLine();
            //    arr[i] = arrItem;
            //}
            //int result = gemstones(arr);
            //Console.WriteLine(result);


            //Task6 Alternating Characters
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    int result = alternatingCharacters(s);
            //    Console.WriteLine(result);
            //}

            //Task7 Beautiful Binary String
            //int n = Convert.ToInt32(Console.ReadLine());          
            //string b = Console.ReadLine();
            //int result = beautifulBinaryString(b);
            //Console.WriteLine(result);


            //Task8 Caesar Cipher
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //int k = Convert.ToInt32(Console.ReadLine());
            //string result = caesarCipher(s, k);
            //Console.WriteLine(result);


            //Task9 Mars Exploration
            //string s = Console.ReadLine();
            //int result = marsExploration(s);
            //Console.WriteLine(result);

            //Task10   Pangrams 
            //string s = Console.ReadLine();
            //string result = pangrams(s);
            //Console.WriteLine(result);

            //Task11 The Love-Letter Mystery
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    int result = theLoveLetterMystery(s);
            //    Console.WriteLine(result);
            //}

            //Task12 separateNumbers
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    separateNumbers(s);
            //}

            //string ss = "accdde".Replace('c', ' ');
            //ss = Regex.Replace(ss, @"\s+", String.Empty);
            //Console.WriteLine("accdde".Length - ss.Length);
            // Console.WriteLine("accddde".Split('e').Length-1);


            //Task 13 Two Strings
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s1 = Console.ReadLine();
            //    string s2 = Console.ReadLine();
            //    string result = twoStrings(s1, s2);
            //    Console.WriteLine(result);
            //}

            //Task14 Palindrome Index
            // Console.WriteLine("hgygsvlfcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcwflvsgygh"[8]);
            //int q = Convert.ToInt32(Console.ReadLine());
            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    int result = palindromeIndex(s);
            //    Console.WriteLine(result);
            //}

            //Task15 makingAnagrams
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //int result = makingAnagrams(s1, s2);
            //Console.WriteLine(result);



            //Task 16 weighted Uniform Strings
            //string s = Console.ReadLine();
            //int queriesCount = Convert.ToInt32(Console.ReadLine());
            //int[] queries = new int[queriesCount];
            //for (int i = 0; i < queriesCount; i++)
            //{
            //    int queriesItem = Convert.ToInt32(Console.ReadLine());
            //    queries[i] = queriesItem;
            //}
            //string[] result = weightedUniformStrings(s, queries);
            //Console.WriteLine(string.Join("\n", result));

            //**************************************************************************Sorting Tasks
            // task 1 BigSorting
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] unsorted = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    string unsortedItem = Console.ReadLine();
            //    unsorted[i] = unsortedItem;
            //}
            //string[] result = bigSorting(unsorted);
            //Console.WriteLine(string.Join("\n", result));


            //Task 2 Quicksort 1 - Partition          
            //int[] arr = new int[] { 4, 5, 3 ,7 ,2 };
            //int[] result = quickSort(arr);
            //Print(result);

            //Task3 Counting Sort
            //int[] arr = new int[] { 4, 5, 3, 7, 2 };
            //int[] result = quickSort(arr);
            //Print(result);

            // Task 4 Insertion Sort - Part 1
            //int[] arr = new int[] {2, 3 ,4 ,5 ,6 ,7 ,8 ,9, 10, 1};
            //insertionSort1(23, arr);

            // Task 5 Insertion Sort - Part 2
            //int[] arr = new int[] { 1, 4, 3, 5, 6, 2 };
            //insertionSort2(6, arr);

            // Task 6 Correctness and the Loop Invariant
            //Task7 Closest Numbers
            //int[] arr = new int[] { 5, 4, 3, 2 };
            //Print(closestNumbers(arr));

            //Task8 Find the Median
            //int[] arr = new int[] { 0, 1, 2, 4, 6, 5, 3 };
            //Console.WriteLine(findMedian(arr));

            //*****************************************************************Search Tasks
            //Task1 Ice Cream Parlor
            //int t = Convert.ToInt32(Console.ReadLine());
            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int m = Convert.ToInt32(Console.ReadLine());
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //    int[] result = icecreamParlor(m, arr);
            //    Console.WriteLine(string.Join(" ", result));
            //}


            //Task2  Missing Numbers
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //int m = Convert.ToInt32(Console.ReadLine());
            //int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));
            //int[] result = missingNumbers(arr, brr);
            //Console.WriteLine(string.Join(" ", result));


            //Sherlock and Array
            //int T = Convert.ToInt32(Console.ReadLine().Trim());
            //for (int TItr = 0; TItr < T; TItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());
            //    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            //    string result = balancedSums(arr);
            //    Console.WriteLine(result);
            //    Console.ReadLine();
            //}


        }
        static string balancedSums(List<int> arr)
        {
            int n = arr.Count;
            int LSideSum = 0;
            int RSideSum = arr.Sum();
            for (int i = 0; i < n; i++)
            {
                LSideSum += arr[i];
                if (LSideSum == RSideSum) return "YES";
                RSideSum -= arr[i];
            }
            return "NO";
        }
        static string balancedSumsBadWay(List<int> arr)
        {
            int n = arr.Count;
            var arrAy = arr.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (areEqualElementsSumOfArray(arrAy, i))
                    return "YES";
            }
            return "NO";
        }
        static bool areEqualElementsSumOfArray(int[] arr, int IndexKey)
        {
            int r = arr.Length - 1;
            int n1 = IndexKey;
            int n2 = r - IndexKey;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[i];
            for (int j = 0; j < n2; j++)
                R[j] = arr[IndexKey + 1 + j];
            if (L.Sum() == R.Sum()) return true;
            else return false;

        }
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            List<int> addednumbers = new List<int>();
            int n = arr.Length;
            int m = brr.Length;
            var arrList = arr.ToList();
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                if (arrList.Contains(brr[i]))
                {
                    arrList.Remove(brr[i]);
                }

                else if (addednumbers.Count != 0)
                {
                    addednumbers.Add(brr[i]);
                }
                else
                {
                    addednumbers.Add(brr[i]);
                }

            }
            addednumbers.Sort();
            return addednumbers.ToArray();
        }
        static bool FindUsingBinnarySearch(List<int> arr, int key)
        {
            int l = 0;
            int r = arr.Count - 1;
            int middle = 0;
            while (l <= r)
            {
                middle = (r + l) / 2;
                if (key == arr[middle])
                {
                    return true;
                }
                else if (key < arr[middle])
                {
                    r = middle - 1;
                }
                else
                {
                    l = middle + 1;
                }
            }
            return false;
        }
        static int[] icecreamParlor(int m, int[] arr)
        {

            List<int> arrNoSort = arr.ToList();
            Array.Sort(arr);
            int n = arr.Length;
            int number1 = 0, number2 = 0;
            List<int> result = new List<int>();
            for (int i = 0, j = n - 1; i <= j;)
            {
                if ((arr[i] + arr[j]) > m) j--;
                else if ((arr[i] + arr[j]) < m) i++;
                else
                {
                    number1 = arr[i];
                    number2 = arr[j];
                    break;
                }
            }

            for (int i = 0; i < arrNoSort.Count; i++)
            {
                if (arrNoSort[i] == number1 || arrNoSort[i] == number2)
                {
                    result.Add(i + 1);
                }
            }
            return result.ToArray();
        }
        static int findMedian(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length / 2];

        }
        static int[] closestNumbers(int[] arr)
        {
            int n = arr.Length;
            int sum = 0;
            List<int> closestNumbers = new List<int>();
            List<int> Mindifnumbers = new List<int>();
            Array.Sort(arr);
            for (int i = 0; i < n - 1; i++)
            {
                int j = i + 1;
                sum = Math.Abs(arr[i] - arr[j]); closestNumbers.Add(sum);
            }
            int min = closestNumbers.Min();

            for (int i = 0; i < n - 1; i++)
            {
                int j = i + 1;
                sum = Math.Abs(arr[i] - arr[j]);
                if (sum == min)
                {
                    Mindifnumbers.Add(arr[i]);
                    Mindifnumbers.Add(arr[j]);
                }
            }


            return Mindifnumbers.ToArray();
        }
        static int runningTime(int[] arr)
        {
            int count = 0;
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] >= arr[i - 1]) continue;
                else
                {
                    int temp = arr[i];
                    int j = i - 1;
                    while (j >= 0 && arr[j] > temp)
                    {
                        arr[j + 1] = arr[j]; j--; count++;
                    }
                    arr[j + 1] = temp;

                }

            }
            // if (count > 0) return count+1;
            //else

            return count;
        }
        static void insertionSort2(int n, int[] arr)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j]; j--;
                }
                arr[j + 1] = temp;

            }
            Print(arr);
        }
        static void insertionSort1(int n, int[] arr)
        {

            int leng = arr.Length; n = arr[leng - 1];
            int i = leng - 2, j = 0;
            while (i >= 0)
            {
                if (arr[i] > n)
                {
                    arr[i + 1] = arr[i];
                    Print(arr);
                    i--;
                }
                else
                {
                    j = i; break;
                }

            }
            if (i == -1)
            {
                arr[j] = n;
            }
            else
                arr[j + 1] = n;
            Print(arr);
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]); Console.Write(' ');
            }

            Console.WriteLine();
        }

        static int[] countingSort(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArr = new int[n];
            int k = arr.Max();
            int[] count = new int[k + 1];
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }
            for (int i = 1; i <= k; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                sortedArr[--count[arr[i]]] = arr[i];
            }
            return sortedArr;
        }

        static int Partition(int[] arr, int l, int r)
        {
            int pivot = arr[l];
            int i = l, j = r;
            while (true)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i < j)
                {
                    exchange(arr, i, j);
                    i++;
                    j--;
                }
                else return j;
            }
        }
        static int[] Quicksort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int pivot = Partition(arr, l, r);
                Quicksort(arr, l, pivot);
                Quicksort(arr, pivot + 1, r);
            }
            return arr;
        }
        static int[] quickSort(int[] arr)
        {
            Quicksort(arr, 0, arr.Length - 1);
            return arr;
        }
        static void exchange(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static string[] bigSorting(string[] unsorted)
        {
            MergSortForStringArray(unsorted, 0, unsorted.Length - 1);
            return unsorted;
        }

        static void MergeStrings(string[] arr, int m, int l, int r)
        {
            int n1 = m + 1 - l;
            int n2 = r - m;

            string[] L = new string[n1];
            string[] R = new string[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];
            int ii = 0; int jj = 0; int k = l;
            while (ii < n1 && jj < n2)
            {
                int a = L[ii].Length;
                int b = R[jj].Length;

                if (a == b)
                {
                    if (string.Compare(L[ii], R[jj]) == -1)
                    {
                        arr[k] = L[ii];
                        ii++;
                    }
                    else
                    {
                        arr[k] = R[jj];
                        jj++;
                    }
                }
                else if (a < b)
                {
                    arr[k] = L[ii];
                    ii++;
                }
                else
                {
                    arr[k] = R[jj];
                    jj++;
                }
                k++;
            }
            while (ii < n1)
            {
                arr[k] = L[ii];
                ii++;
                k++;
            }
            while (jj < n2)
            {
                arr[k] = R[jj];
                jj++;
                k++;
            }

        }
        static void MergSortForStringArray(string[] arr, int l, int r)
        {
            if (l < r)
            {
                int midl = (l + r) / 2;
                MergSortForStringArray(arr, l, midl);
                MergSortForStringArray(arr, midl + 1, r);
                MergeStrings(arr, midl, l, r);
            }
        }
        static string[] bigSortingBubleSort(string[] unsorted)
        {
            int len = unsorted.Length - 1;
            for (int i = len; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    int a = unsorted[i].Length;
                    int b = unsorted[j].Length;
                    if (a > b) continue;
                    else if (a == b)
                    {
                        //if (string.Compare(unsorted[i], unsorted[j]) == -1)
                        //    exchange(unsorted, i, j);
                    }
                    else
                    {
                        //   exchange(unsorted, i, j);
                    }
                }
            }
            return unsorted;
        }


        static int makingAnagrams(string s1, string s2)
        {
            int n = s1.Length;
            int m = s2.Length;
            int count = 0;
            Dictionary<char, int> keyValuePairs1 = new Dictionary<char, int>();
            Dictionary<char, int> keyValuePairs2 = new Dictionary<char, int>();
            string a = "abcdefghijklmnopqrstuvwxyz";

            foreach (var c in a)
            {
                keyValuePairs1.Add(c, 0);
                keyValuePairs2.Add(c, 0);
            }

            foreach (char c in s2)
            {
                keyValuePairs2[c] += 1;
            }

            foreach (char c in s1)
            {
                keyValuePairs1[c] += 1;
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (keyValuePairs1[i] != keyValuePairs2[i])
                    count = count + Math.Abs(keyValuePairs2[i] - keyValuePairs1[i]);
            }

            return count;
        }
        static int palindromeIndex(string s)
        {

            int n = s.Length;
            if (n < 3) return -1;
            int first = 0, last = 0;
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    first = i; last = j;
                    break;
                }
            }
            if (first != 0 || last != 0)
            {
                for (int i = first + 1, j = last; i < j; i++, j--)
                    if (s[i] == s[j]) continue;
                    else { first = last; break; }
            }
            if (first != 0 || last != 0) return first;
            else

                return -1;
        }

        static string twoStrings(string s1, string s2)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            int matchedChars = 0;
            foreach (var c in a)
            {
                if (s1.Contains(c) && s2.Contains(c))
                    matchedChars++;
            }
            return matchedChars != 0 ? "YES" : "NO";
        }
        static void separateNumbers(string s)
        {

            int grade = 1;
            int changegrading = 0;
            int stringLenth = s.Length;
            long second = 0;
            while (stringLenth / (grade * 2) != 0)
            {
                long first = getNumberFromString(s, 0, grade);
                if (first == -1) break;
                int i = grade;
                changegrading = 0;
                for (; i <= stringLenth - (grade + changegrading); i += grade + changegrading)
                {
                    if (first.ToString().Length != (first + 1).ToString().Length)
                    {
                        changegrading = changegrading + 1;
                    }

                    second = getNumberFromString(s, i, i + grade + changegrading);

                    if (second == -1) break;

                    if (second - first != 1) break;

                    first = second;
                }
                if (i == stringLenth)
                {
                    Console.WriteLine($"YES {getNumberFromString(s, 0, grade)}");
                    return;
                }

                grade++;
            }


            Console.WriteLine("NO");
        }
        static long getNumberFromString(string str, int indexFirst, int indexLast)
        {
            long result;
            try
            {
                if (str[indexFirst] == '0' && (indexLast - indexFirst) != 1) return -1;
                result = Convert.ToInt64(str.Substring(indexFirst, indexLast - indexFirst));
            }
            catch (Exception)
            {
                return -1;
            }
            return result;
        }

        static int theLoveLetterMystery(string s)
        {
            int count = 0;
            int j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                count += Math.Abs(s[i] - s[j]);
                j--;
            }
            return count;
        }

        static string[] weightedUniformStrings(string s, int[] queries)
        {
            Dictionary<char, int> keyValuePairsChars = new Dictionary<char, int> { { 'a',1} , { 'b',2}, { 'c',3},
                {  'd',4} ,{ 'e',5}, { 'f',6} , {'g',7 }, { 'h',8}, { 'i',9}, { 'j',10}, { 'k',11}, { 'l',12}, { 'm',13},
                { 'n',14}, {'o',15 }, { 'p',16}, { 'q',17}, { 'r',18}, { 's',19}, { 't',20}, { 'u',21}, { 'v',22}, { 'w',23},
                { 'x',24}, { 'y',25}, {'z',26 } };
            List<int> uniNumbers = new List<int>();
            string a = "abcdefghijklmnopqrstuvwxyz";
            string[] result = new string[queries.Length];
            int count = 0;
            int n = s.Length;
            for (int i = 0; i < n;)
            {
                char c = s[i];
                count = count + keyValuePairsChars[c];
                uniNumbers.Add(count);
                int j = i;
                while (j + 1 < s.Length && c == s[j + 1])
                {
                    count = count + keyValuePairsChars[c];
                    uniNumbers.Add(count);
                    j++;
                }
                i = j + 1;
                count = 0;
            }
            uniNumbers.Sort();
            for (int i = 0; i < queries.Length; i++)
            {
                if (ContainsTheNumber(uniNumbers, queries[i]))
                    result[i] = "Yes";
                else result[i] = "No";
            }
            return result;
        }
        static bool ContainsTheNumber(List<int> uniNumbers, int key)
        {
            uniNumbers.BinarySearch(key);
            int l = 0;
            int r = uniNumbers.Count() - 1;
            int middle = 0;
            while (l <= r)
            {
                middle = (l + r) / 2;
                if (key == uniNumbers[middle])
                {
                    return true;
                }
                else if (key < uniNumbers[middle])
                {
                    r = middle - 1;
                }
                else
                {
                    l = middle + 1;
                }
            }
            return false;
        }
        static string pangrams(string s)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < a.Length; i++)
            {
                if (s.Contains(a[i]) || s.Contains(b[i])) continue;
                else return "not pangram";
            }
            return "pangram";

        }
        static int marsExploration(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i = i + 3)
            {
                if (s[i] != 'S')
                    count++;
                if (s[i + 1] != 'O')
                    count++;
                if (s[i + 2] != 'S')
                    count++;
            }
            return count;
        }
        static string caesarCipher(string s, int k)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string encryptedstring = "";
            foreach (char c in s)
            {
                if (k > 26)
                {
                    k = k % 26;
                }
                if (a.Contains(c))
                {
                    if (c + k > 'z')
                        encryptedstring += (char)('a' + (c + k - 'z' - 1));
                    else encryptedstring += (char)(c + k);
                }
                else if (b.Contains(c))
                {
                    if (c + k > 'Z')
                        encryptedstring += (char)('A' + (c + k - 'Z' - 1));
                    else encryptedstring += (char)(c + k);
                }
                else encryptedstring += c;
            }
            return encryptedstring;
        }
        static int beautifulBinaryString(string b)
        {
            int count = 0;
            string binarystring = "010";
            string currentArray = b;
            for (int i = 0; i < currentArray.Length; i++)
            {
                if (b.Contains(binarystring))
                {
                    int x = b.IndexOf(binarystring);
                    b = b.Substring(x + 3);
                    count++;
                }

            }

            return count;
        }
        static int alternatingCharacters(string s)
        {
            if (s.Length < 2) return 0;
            if (s.Length == 2 && (s[0] != s[1])) return 2;
            int count = 0;
            char x = 'A';
            char y = 'B';

            for (int k = 0; k + 1 < s.Length; k++)
            {
                if (s[k] == s[k + 1]) count++;
            }
            return count;

        }

        static int gemstones(string[] arr)
        {
            bool contain = false;
            string a = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            foreach (char c in a)
            {
                int sizeOfarr = 0;
                foreach (string s in arr)
                {
                    if (s.Contains(c)) { contain = true; sizeOfarr++; }
                    else contain = false;
                }
                if (sizeOfarr == arr.Length && contain is true) count++;
            }

            return count;
        }

        static string funnyString(string s)
        {
            var reverse = s.ToCharArray().Reverse().ToArray();
            for (int i = 0; i + 1 < s.Length; i++)
            {
                if (Math.Abs(s[i] - s[i + 1]) == Math.Abs(reverse[i] - reverse[i + 1])) continue;
                else return "Not Funny";
            }
            return "Funny";

        }

        static string isValid(string s)
        {
            if (s.Length < 2) return "YES";
            Dictionary<char, int> list = new Dictionary<char, int>();
            for (char a = 'a'; a <= 'z'; a++)
            {
                list.Add(a, 0);
            }
            foreach (char c in s)
            {
                list[c] += 1;
            }
            if (IsAnyKeysHaveDifferentsValues(list)) return "YES";
            else return "NO";
        }
        static bool IsAnyKeysHaveDifferentsValues(Dictionary<char, int> list)
        {
            int state = list['a'];
            int count = -1;
            bool isanyDifferent = false;
            foreach (var item in list)
            {
                if (item.Value != 0 && state != item.Value)
                {
                    if (isanyDifferent) return false;
                    if (state - 1 == item.Value)
                    {
                        if (count > 0)
                        {
                            if (item.Value == 1)
                            {
                                isanyDifferent = true;
                                continue;
                            }
                            else return false;
                        }
                        state = item.Value;
                        isanyDifferent = true;
                    }
                    else if (state == item.Value - 1)
                    {
                        isanyDifferent = true;
                    }

                    else if (item.Value == 1)
                    {
                        isanyDifferent = true;
                    }
                    else return false;
                }
                count++;
            }
            return true;
        }


        static string isValids(string s)
        {
            if (s.Length < 2) return "YES";
            else if (s.Length == 2 && s[0] != s[1]) return "NO";
            Dictionary<char, int> list = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (list.ContainsKey(c))
                    list[c] += 1;
                else
                    list.Add(c, 1);
            }

            if (NumberOfkeysWithdiffValues(list) == 1)
            {
                if (IsValuesOfKeysAreDiffWithOne(list.Values.ToList()))
                    return "YES";
                else
                    return "NO";
            }
            return "NO";
        }
        public static int NumberOfkeysWithdiffValues(Dictionary<char, int> list)

        {
            int differentnumber = 0;
            int count = 0;
            List<int> valuesList = list.Values.ToList();
            for (int i = 0; i < valuesList.Count - 1; i++)
            {
                if (count > 1) break;
                if (valuesList[i] != valuesList[i + 1])
                {
                    differentnumber = valuesList[i + 1];
                    valuesList.RemoveAt(i + 1);
                    count++;
                    i = i - 1;
                }
                else if (((valuesList[i] == differentnumber) && count == 1))
                {
                    count = count + 2; break;
                }

            }

            return count;
        }
        public static bool IsValuesOfKeysAreDiffWithOne(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (Math.Abs(list[i + 1] - list[i]) == 1)
                { return true; }
            }
            return false;
        }


        public static int alternate(string s)
        {
            if (s.Length < 2) return 0;
            if (s.Length == 2 && (s[0] != s[1])) return 2;
            string a = "abcdefghijklmnopqrstuvwxyz";
            int maxi = 0;
            for (int i = 0; i < 26; i++)
            {
                for (int j = i + 1; j < 26; j++)
                {
                    char x = a[i];
                    char y = a[j];
                    string t = "";
                    for (int k = 0; k < s.Length; k++)
                    {
                        if (s[k] == x || s[k] == y)
                        {
                            t += s[k];
                        }
                    }
                    bool flag = true;
                    for (int f = 0; f + 1 < t.Length; f++)
                    {
                        if (t[f] == t[f + 1])
                        {
                            flag = false; break;
                        }
                    }
                    int ts = t.Length;
                    if ((flag) && (ts > 1)) maxi = Math.Max(maxi, ts);

                }
            }
            return maxi;
        }

        public static string RemoveCharOfString(string s, char c1)
        {
            s = s.Replace(c1, ' ');
            return Regex.Replace(s, @"\s+", String.Empty);
        }

        public static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int Numcount = 0;
            int lowcase = 0;
            int Upcase = 0;
            int spcase = 0;

            foreach (char c in password)
            {
                if (numbers.Contains(c))
                {
                    if (Numcount == 0)
                        Numcount++;
                }
                if (lower_case.Contains(c))
                {
                    if (lowcase == 0)
                        lowcase++;
                }
                if (upper_case.Contains(c))
                {
                    if (Upcase == 0)
                        Upcase++;
                }
                if (special_characters.Contains(c))
                {
                    if (spcase == 0)
                        spcase++;
                }

            }

            int minum = 4 - (Numcount + lowcase + Upcase + spcase);
            if (n >= 6)
            {
                return minum;
            }
            else
            {
                if ((n + minum) >= 6) { return minum; }
                else if ((n + minum) < 6) { return 6 - n; }
            }
            return minum;
        }
        public static string hackerrankInString(string s)
        {
            string HackerRank = "hackerrank";
            int j = 0;
            foreach (char c in s)
            {
                if (c == HackerRank[j])
                {
                    j++;
                }
                if (j == HackerRank.Length)
                {
                    return "YES";
                }
            }
            return "NO";

        }

        public static string hackerrankInStringTheBest(string s)
        {
            var hackerrank = new Queue<char>("hackerrank".ToCharArray());
            foreach (char c in s)
            {
                if (c == hackerrank.Peek())
                    hackerrank.Dequeue();

                if (hackerrank.Count == 0)
                    return "YES";
            }
            return "NO";


        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {
                int remainder = (x1 - x2) % (v2 - v1);

                if (remainder == 0)
                {
                    return "YES";
                }
            }
            return "NO";

        }

    }
}
