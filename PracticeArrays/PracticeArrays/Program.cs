/***
1. When to use String vs. StringBuilder in C# ?
If a string can change then using a StringBuilder is the best option.

2. What is the base class for all arrays in C#?
The Array class

3. How do you sort an array in C#?
Array.Sort
4. What property of an array object can be used to get the total number of elements in
an array?
Array.Length
5. Can you store multiple data types in System.Array?
No
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
CopyTo : just copy the elements to another array
Clone : return a whole new array which contains  all the elements of original array
***/

using System.Collections;

namespace Practice_Arrays
{

    public static class program
    {
        public static void Main(String[] args)
        {
            int[] primes = new int[1000];
            //1.
            // Copying_an_Array();
            //2.
            //Manage_list();
            //3.
            //primes = FindPrimesInRange(1, 100);

            //int[] arr = new int[] {1,2,3,4,5};

            //4.
            //primes = rotateArray(arr, 3);
            //Console.WriteLine(String.Join(",", primes));

            //5.
            //int[] arr = new int[] { 1, 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            //primes = largestSequence(arr);
            //Console.WriteLine(String.Join(",", primes));
            //7.
            //int[] arr = new int[] { 1, 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            // frequent(arr);

            //1.
            //reverse(s);

            //2.
            // String s = "C# is not C++, and PHP is not Delphi!"
            //reWords(s);

            //3.
            //String s = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            //pali(s);

            //4.
            String s = "https://www.apple.com/iphone";
            parse(s);





        }
        /*1.Copying an Array*/

        public static void Copying_an_Array()
        {
            int[] orignal = new int[] {1,2,3,4,5,6,7,8,9,0 };
            int[] copy = new int[orignal.Length];

            Console.Write("The Orignal Array:");

            for (int i = 0; i < orignal.Length; i++)
            {
                Console.Write($" {orignal[i]}");
                copy[i] = orignal[i];
            }
            Console.WriteLine();

            Console.Write("The Copy Array is:");

            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write($" {copy[i]}");
            }
        }

        public static void Manage_list()
        {
            var arlist = new ArrayList();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                String input = Console.ReadLine();
                if(input == "--")
                {
                    arlist.Clear();
                    Console.WriteLine("Clear List!");
                    continue;
                }
                String element = input.Split(' ')[1];
                input = input.Split(' ')[0];
                if (input == "-")
                {
                    arlist.Remove(element);
                }
                else if (input == "+")
                {
                    arlist.Add(element);

                }else
                {
                    Console.WriteLine("Invalid command");
                }
                Console.Write("Current List:");
                for(int i = 0; i < arlist.Count; i++)
                {
                    Console.Write($" {arlist[i]}");
                }
                Console.WriteLine("");
            }

        }

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            bool[] primes = new bool[endNum + 1];
            //int[] ans  = new int[] {};
            List<int> ans = new List<int>();
            int n = 0;
            for(int i = startNum; i <= endNum; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                if (primes[i] == false)
                {
                    ans.Add(i);
                    for (int j = i; j < endNum; j = j + i)
                    {

                        primes[j] = true;
                    }

                }

               
            }
            int[] s = ans.ToArray();
            return s;
        }

        public static int[] rotateArray(int[] arr, int num)
        {
            int[] ans = new int[arr.Length];

            for(int j = 1; j < num+1; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int target = i - j;
                    if (target < 0)
                        target += arr.Length;
                    ans[i] += arr[target];
                }
            }
            return ans;
            
        }

        public static int[] largestSequence(int[] arr)
        {
            int maxx = 1;
            int cur = arr[0];
            
            int temp = 1;
            int target = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == cur)
                {
                    temp++;
                    if (temp > maxx)
                    {
                        maxx = temp;
                        target = arr[i];
                    }
                }
                else
                {
                    temp = 1;
                    cur = arr[i];

                }
            }

            int[] ans = Enumerable.Repeat(target, maxx).ToArray();


            return ans;

        }

        public static void frequent(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map[arr[i]] = 1;
                }
            }
            var maxValue = map.Values.Max();
            List<int> ans = new List<int>();

            for(int i = 0; i < map.Count; i++)
            {
                var item = map.ElementAt(i);
                if(item.Value == maxValue)
                {
                    ans.Add(item.Key);
                }
            }

            if (ans.Count == 1)
            {
                Console.WriteLine("The number {0} is the most frequent (occurs {1} times)", ans[0], maxValue);
            }
            else
            {
                Console.Write("The number {0} is the most frequent (occurs {1} times). The leftmost of them is {2}.", String.Join(",", ans), maxValue, ans[0]);
            }

        }


        public static void reverse(String str)
        {

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new String(charArray));
        }

        public static void reWords(string str)
        {
            char[] sep = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
            List<string> ans = new List<string>();

            char[] charArr = str.ToCharArray();
            string temp = "";
            foreach (char ch in charArr)
            {
                

                if (sep.Contains(ch))
                {
                    ans.Add(temp);
                    temp = "";
                    temp += ch;
                    ans.Add(temp);
                    temp = "";
                }
                else
                {
                    temp += ch;
                }
            }
            String[] s = ans.ToArray();
            int first = 0;
            int end = s.Length-1;
            
            while (first <= end)
            {
               
                if (s[first] == "" || sep.Contains(s[first][0]))
                {
                    first++;
                    continue;
                }
                if (s[end] == "" ||sep.Contains(s[end][0]))
                {
                    end--;
                    continue;
                }

                temp = s[first];
                s[first] = s[end];
                s[end] = temp;
                first++;
                end--;
            }
            Console.WriteLine(String.Join("", s));
        }

        public static void pali(string str)
        {
            char[] sep = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
            String[] strings = str.Split(sep);

            foreach(string s in strings)
            {
                if(s == new string(s.Reverse().ToArray()))
                {
                    Console.Write($"{s} ");
                }
            }

        }

        public static void parse(string str)
        {
            string p = "";
            string s = "";
            string r = "";

            string[] strings = str.Split('/');

            if (strings[0].Contains(':'))
            {
                p = strings[0].Remove(strings[0].Length - 1);
                s = strings[2];

            }
            else
            {
                s = strings[0];
            }

            if (strings.Length >3)
            {
                r = strings[3];
            }

            Console.WriteLine("[protocal] = {0}  [server] = {1}   [resource] = {2}",p,s,r);


        }



    }
}


