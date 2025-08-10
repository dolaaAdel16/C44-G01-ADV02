using System.Collections;

namespace ADV02
{
    internal class Program
    {
        
        
        
           
            public static int SumOfArayList(ArrayList arrayList)
            {
                int sum = 0;
                if (arrayList is not null)
                {
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        sum += (int?)arrayList[i] ?? 0;
                        //Casting From Object [Reference Type ] To int [Value Type]
                        // UnBoxing => UnSafe Casting [May THrow EXception]
                    }



                }
                return sum;
            }



            //static void Main(string[] args)
            //{

            //    #region Non Generic Collection [Array list] 
            //    #region Example01
            //    // ArrayList arrayList = new ArrayList();
            //    //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Count}");
            //    //arrayList.Add(1);
            //    //arrayList.Add(2);
            //    //arrayList.AddRange(new int[] { 3 ,4});
            //    //Console.WriteLine("After Adding Elements To ArrayList ");
            //    //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Count}");
            //    //arrayList.Add(6);
            //    //Console.WriteLine("After Adding the Fifth Elements   ");
            //    //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Count}");
            //    //arrayList.TrimToSize();
            //    //// Realease | Deallocate | Delete | Free | UnsedBytes =12 Byte
            //    //Console.WriteLine("after Triming ");
            //    //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Count}");
            //    #endregion
            //    #region Example02
            //    //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
            //    //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Count}");
            //    //arrayList.Add(6);
            //    //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Count}");
            //    #endregion
            //    #region Example03
            //    //ArrayList arrayList = new ArrayList();
            //    //arrayList.Add(1); // Casting From int [valuetype] to object [reference type ] => Boxing
            //    //arrayList.Add(2);
            //    //arrayList.Add(3);
            //    //arrayList.Add(4);
            //    //arrayList.Add("Rana");
            //    // Compiler Can Not Enforce Type Safty
            //    //HetroGenous => 
            //    //int Result = SumOfArayList(arrayList);
            //    //Console.WriteLine($" The Result = {Result}");
            //    #endregion
            //    #endregion

            //    #region Generic-Collection[list]
            //    //List<int> Numbers = new List<int>();
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}"); //0
            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");//0

            //    //Numbers.Add(1);
            //    // Upon adding the first element to the list the capacity is
            //    // increased  to defaultCapacity
            //    // New Array Created At Heap With Size 4
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}");//1

            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");//4
            //    //Numbers.AddRange(new int[] {2,3,4});
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}"); //4

            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");//4
            //    //Numbers.Add(5);
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}");

            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");  
            //    //Numbers.TrimExcess();
            //    ////Create New Array Size = Count Of Element 
            //    //// New Array Size  = 5
            //    //// Old Array Unreacable
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}");

            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");

            //    //List<int> Numbers = new List<int>(5) { 1,2,3,4,5};
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}");

            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");
            //    //Numbers.Add(6);
            //    //Console.WriteLine($"Count Of ArrayList {Numbers.Count}");

            //    //Console.WriteLine($"Capacity Of ArrayList {Numbers.Capacity}");
            //    //Numbers[0] = 12345; // using Indexer As Setter
            //    //Numbers[9] = 1000; // invalid 
            //    //// Can Not Use Indexer For Adding
            //    //for (int i = 0; i < Numbers.Count; i++)
            //    //{
            //    //    Console.WriteLine(Numbers[i]); // Using Indexer As GEtter
            //    //}

            //    //foreach (int Number in Numbers)
            //    //{
            //    //    Console.WriteLine(Number);  
            //    //}

            //    //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //    //Console.WriteLine(Helper.SumList(Numbers));
            //    //Numbers.Add("Rana");
            //    #endregion

            //    #region List Methods
            //    //List<int> Numbers02  = new List<int>(4) { 1,2,3,4,5};
            //    //Numbers02.Add(1);   // Add one Element 
            //    //Numbers02.AddRange(new int[] { 2, 3 }); // Add Range Of Elements
            //    //Numbers02.Insert(3, 4); // Insert Element Into Specific Index InList
            //    //Numbers02.InsertRange(4, new int[] { 5, 6 });
            //    //Numbers02.Clear();// Remov All Element In List 
            //    //Console.WriteLine(Numbers02.BinarySearch(2));
            //    //Console.WriteLine(Numbers02.Contains(9));
            //    //Console.WriteLine(Numbers02.Capacity);
            //    //Console.WriteLine(Numbers02.EnsureCapacity(8)); // Increace Capacity But Check old Capacity First 
            //    //Console.WriteLine(Numbers02.IndexOf(1));
            //    //Console.WriteLine(Numbers02.LastIndexOf(1));
            //    //foreach (int i in Numbers02) 
            //    //{
            //    //    Console.WriteLine(i);
            //    //}
            //    #endregion

            //    #region LinkedList
            //    //LinkedList<int> Numbers = new LinkedList<int>();
            //    //Numbers.AddFirst(1);
            //    //Numbers.AddAfter(Numbers.First, 2);
            //    //Numbers.AddLast(3);

            //    #endregion

            //    #region Stack 
            //    //Stack<int> Numbers = new Stack<int>();
            //    //Numbers.Push(1);
            //    //Numbers.Push(2);
            //    //Numbers.Push(3);
            //    ////Numbers.Pop();
            //    //Console.WriteLine(Numbers.Pop());
            //    //Console.WriteLine(Numbers.Pop());
            //    //Console.WriteLine(Numbers.Pop());

            //    //Console.WriteLine(Numbers.Pop());
            //    //System.InvalidOperationException: Stack empty
            //    //Console.WriteLine(Numbers.TryPop(out int LastNumber));

            //    //foreach (int number in Numbers) 
            //    //{
            //    //    Console.WriteLine(number);
            //    //}
            //    #endregion

            //    #region Queue
            //    //Queue<int> Numbers = new Queue<int>();
            //    //Numbers.Enqueue(1);
            //    //Numbers.Enqueue(2);
            //    //Numbers.Enqueue(3);
            //    //Numbers.Dequeue();
            //    //Console.WriteLine(Numbers.Dequeue()); //1
            //    //Console.WriteLine(Numbers.Dequeue());//2
            //    //Console.WriteLine(Numbers.Dequeue());//3
            //    //Console.WriteLine(Numbers.TryDequeue(out int LastNumber));
            //    // Console.WriteLine(Numbers.Dequeue());
            //    //System.InvalidOperationException: Queue empty

            //    //foreach (int number in Numbers) 
            //    //{
            //    //    Console.WriteLine(number);
            //    //}


            //    #endregion

      
        ////////////////////////////////////////////////////////////////////
      

            

        // Assignment 
        static void Main(string[] args)
        {
            //1.

            /*
            int[] nums = { 1, 10, 30, 44, 55 };
            int queries = 2;
            HelperAssignmnet.CheckArray(nums, queries);
            */

            /////////////////////////////////////////////////////////////////////

            //2.

            /*

            int N = int.Parse(Console.ReadLine());


            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            bool isPalindrome = true;
            for (int i = 0; i < N / 2; i++)
            {
                if (arr[i] != arr[N - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome ? "YES" : "NO");

            */


            /////////////////////////////////////////////////////////////////////



            //3.

            /*

            Queue queue = new Queue();

            for (int i = 1; i <= 15; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("Queue Before Reverse");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");


            queue = HelperAssignment.ReverseQueue(queue);
            Console.WriteLine("Queue After Reverse");

            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }


            */




            ///////////////////////////////////////////////////



            //5. 

            /*

            int[] nums = { 1, 2, 3, 2, 4, 4, 3, 2 };

            nums = HelperAssinment.RemoveDuplicate(nums);
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }

            */


            /////////////////////////////////////////////////////////////////////


            //6.

            /*

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 11, 13 };

            HelperAssinment.RemoveAllOddNumbers(list);

            Console.WriteLine(string.Join(" ", list));

            */

            /////////////////////////////////////////////////////////////////////



            //7. 

            /*
            HelperAssignment.CreateQueue();
            */


            //////////////////////////


            //9.

            /*

            int[] array1 = { 1, 2, 3, 4, 4 };
            int[] array2 = { 10, 4, 4 };

            int[] result = HelperAssignment.FindIntersection(array1, array2);

            Console.WriteLine($"Intersection: [" + string.Join(", ", result) + "]");

            */


            /////////////////////////////////////////////////////////////////////






            //ArrayList arrList = new ArrayList() { 1, 2, 3, 7, 5 };
            //int target = 12;
            //int[]? result = HelperAssignment.FindTarget(arrList, target);

            //foreach (int item in result)
            //{
            //    Console.Write(item + " ");
            //}



            /////////////////////////////////////////////////////////////////////





        }
    }

}


