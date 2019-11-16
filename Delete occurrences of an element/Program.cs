using System;
using System.Collections;
using System.Linq;

// Enough is enough!
// Alice and Bob were on a holiday. Both of them took many pictures of the places they've been, and now they want to show Charlie their entire collection. However, Charlie doesn't like this sessions, since the motive usually repeats. He isn't fond of seeing the Eiffel tower 40 times. He tells them that he will only sit during the session if they show the same motive at most N times. Luckily, Alice and Bob are able to encode the motive as a number. Can you help them to remove numbers such that their list contains each number only up to N times, without changing the order?

// Task
// Given a list lst and a number N, create a new list that contains each number of lst at most N times without reordering. For example if N = 2, and the input is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].

// Example
// Kata.DeleteNth (new int[] {20,37,20,21}, 1) // return [20,37,21]
// Kata.DeleteNth (new int[] {1,1,3,3,7,2,2,2,2}, 3) // return [1, 1, 3, 3, 7, 2, 2, 2]

namespace Delete_occurrences_of_an_element
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(DeleteNth(new int[] { 1, 2, 3, 4, 5 }, 1));
          }

          public static int[] DeleteNth(int[] arr, int x)
          {
               int[] Count;
               ArrayList results = new ArrayList();


               foreach (int i in arr)
               {
                    int[] q = Array.FindAll(arr, i);


                    if (q.Count <= x)
                    {
                         results.Insert(results.Count + 1, i);
                    }
               }

               //    foreach character in arr in it appears less or equal than x times in returnArray then add else skip

               //  foreach (int i in arr){
               //      int Count = arr.findall(i);
               // }

               return results;
          }


          public static void t()
          {
               int[] a = new int;

               a.Append(1);



          }

     }


}
