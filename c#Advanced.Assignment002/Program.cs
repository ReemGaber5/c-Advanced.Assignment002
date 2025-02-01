using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace c_Advanced.Assignment002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Console.WriteLine("Enter the size of the array and number of queries :");
            //string[] Input = Console.ReadLine().Split();
            //int N=int.Parse(Input[0]);
            //int Q=int.Parse(Input[1]);


            //Console.WriteLine("Enter the array elements:");
            //int[] arrelemnts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //for (int i = 0; i < Q; i++)
            //{
            //    Console.WriteLine("Enter the query value X:");
            //    int X = int.Parse(Console.ReadLine());
            //    int count = 0;

            //    foreach (int num in arrelemnts)
            //    {
            //        if (num > X)
            //            count++;
            //    }
            //    Console.WriteLine(count);
            //}
            #endregion

            #region Question2
            //Console.Write("Enter array size: ");

            //int N = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Number want to check it: ");
            //string number = Console.ReadLine();

            //string reversed = ReverseString(number);

            //if (number == reversed)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region Question3
            //Queue<int> q= new Queue<int>();
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);

            //Console.WriteLine("queeu before reverse : " + string.Join(", ", q));

            //ReverseQueueElemnts(q);

            //Console.WriteLine("queeu After reverse : " + string.Join(", ", q));



            #endregion

            #region Question5
            //int[] array = { 1, 3, 5, 3, 7, 1, 9, 3 };
            //Console.WriteLine("Array with duplicates: " + string.Join(", ", array));


            //int[] uniqueArr = RemoveDuplicated(array);

            //Console.WriteLine("Array without duplicates: " + string.Join(", ", uniqueArr));


            #endregion

            #region Question6
            //ArrayList nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if ((int)nums[i] % 2 != 0)  
            //    {
            //        nums.RemoveAt(i);  
            //        i--; 
            //    }
            //}
            //int[] resultArray = (int[])nums.ToArray(typeof(int));
            //Console.WriteLine("ArrayList without odd numbers: " + string.Join(", ", resultArray));

            #endregion

            #region Question7
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Elements in the queue:" + string.Join(", ", queue));

            #endregion

            #region Question8

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);

            //Console.WriteLine("enter the number you want to search for :");
            //int target = int.Parse(Console.ReadLine());

            //SearchInStack(stack, target);
            #endregion

            


        }


        #region Question2
        //static string ReverseString(string str)
        //{
        //    char[] arr = str.ToCharArray();
        //    Array.Reverse(arr);
        //    return new string(arr);
        //}
        #endregion

        #region Question3

        //static void ReverseQueueElemnts(Queue<int> q)
        //{
        //    Stack<int> s = new Stack<int>();
        //    while (q.Count > 0)
        //    {
        //        s.Push(q.Dequeue());
        //    }

        //    while (s.Count > 0)
        //    {
        //        q.Enqueue(s.Pop());
        //    }
        //}

        #endregion

        #region Question5

        //static int[] RemoveDuplicated(int[] arr )
        //{
        //    List<int> uniqueNums = new List<int>();
        //    foreach(int n in arr)
        //    {
        //        if(!uniqueNums.Contains(n)) 
        //          uniqueNums.Add(n);
        //    }
        //    return uniqueNums.ToArray();
        //}
        #endregion


        #region Question8

        //static void SearchInStack(Stack<int> s, int target)
        //{
        //    int count = 0;

        //    Stack<int> temp = new Stack<int>();

        //    while (s.Count > 0)
        //    {
        //        int current = s.Pop(); 
        //        count++; 

        //        if (current == target)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {count}");
        //            return;
        //        }
        //        temp.Push(current);
        //    }
        //    Console.WriteLine("Target was not found");

        //}


        #endregion

    }
}
