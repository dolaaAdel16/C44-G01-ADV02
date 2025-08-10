using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
    internal class HelperAssignment
    {
        public static void CheckArray(int[] numbers, int queries)
        {
            for (int i = 0; i < queries; i++)
            {
                int num;
                do
                {
                    Console.WriteLine("Please Enter X");
                }
                while (!int.TryParse(Console.ReadLine(), out num));

                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (num < numbers[j])
                        count++;
                }
                Console.WriteLine($"There is {count} numbers is greater than X");
            }
        }



        //3.
        public static Queue ReverseQueue(Queue queue)
        {
            Stack stack = new Stack();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }



        //5. 

        public static int[] RemoveDuplicate(int[] array)
        {
            HashSet<int> values = new HashSet<int>(array);

            array = values.ToArray();
            return array;
        }

        //6.

        public static void RemoveAllOddNumbers(List<int> list)
        {
            list.RemoveAll(num => num % 2 != 0);
        }



        //7.

        public static void CreateQueue()
        {
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }


        //9.

        public static int[] FindIntersection(int[] array1, int[] array2)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();


            foreach (int num in array1)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            List<int> intersection = new List<int>();


            foreach (int num in array2)
            {
                if (countMap.ContainsKey(num) && countMap[num] > 0)
                {
                    intersection.Add(num);
                    countMap[num]--;
                }
            }

            return intersection.ToArray();
        }



        //10.

        public static int[]? FindTarget(ArrayList arrlist, int target)
        {
            int count = arrlist.Count;
            int[] arr = (int[])arrlist.ToArray(typeof(int));

            for (int i = 0; i < count; i++)
            {
                int sum = 0;
                for (int j = i; j < count; j++)
                {
                    sum += arr[j];
                    if (sum == target)
                    {
                        int[] result = new int[j - i + 1];
                        Array.Copy(arr, i, result, 0, j - i + 1);
                        return result;
                    }
                }
            }
            return null;
        }
    }
}
