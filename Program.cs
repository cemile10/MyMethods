using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;

class ArrayMethods
{
   // min :
   public static int Min(int[] arr)
    {
        int min = arr[0];
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i]<min)
            {
                min = arr[i];
            }
           
        }
        return min;
    }
    // max :
    public static int Max(int[] arr)
    {
        int max= arr[0];
        for(int i = 0;i < arr.Length;i++)
        {
            if (arr[i]>max) 
            {
                max= arr[i];
            }
        }
        return max;
    }

    // count :

    public static int Count(int[] arr)
    {
        
        int counter = 0;
        for(int i=0;i<arr.Length; i++)
        {
            counter++;
        }
        return counter;
    }

    // average 

    public static int Average(int[] arr)
    {
        int sum = 0;
        for(int i=0; i<arr.Length; i++)
        {
            sum += arr[i];
        }
        return (sum/arr.Length);
    }


    // reverse :
    public static int[] Reverse(int[] arr)
    {

        for (int i = 0; i < (arr.Length / 2); i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
      
        return arr;
    }

    // remove :
    public static void Remove(int[] arr,int number)
    {
        bool test=false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                arr[i] = 0;
                Console.WriteLine(number + " ededi arrayden xaric edildi");
                test = true;
                break;
            }
        }
        if(!test)
        {
            Console.WriteLine("arrayde bele bir eded yoxdur");
        }
    }

   

    // clear :
    public static void Clear(int[] arr)
    {
       
        for(int i=0; i<arr.Length;i++)
        {
            arr[i] = 0;
        }
    }

    // contains :
    public static bool Contains(int number, int[] arr)
    {
       
       for(int i=0; i<arr.Length;i++)
        {
            if (arr[i] == number)
            {
                return true;
            }
        }
       return false;
    }

    // concat :

    public static int[] Concat(int[] arr1, int[] arr2)
    {
        int[] arr3=new int[arr1.Length+arr2.Length];
        for(int i = 0; i < arr1.Length; i++)
        {
            arr3[i] = arr1[i];
        }
        for(int j=0; j<arr2.Length; j++)
        {
            arr3[arr1.Length + j] = arr2[j];
        }
        return arr3;
    }



}




namespace MyProgram
{
    class MetodYoxlamalari
    {
        static void Main(string[] args)
        {
   
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("minumum " + ArrayMethods.Min(array));

            Console.WriteLine("Maksimum : " + ArrayMethods.Max(array));

            Console.WriteLine("array element sayi  " + ArrayMethods.Count(array));

            Console.WriteLine("arrayin ortalamasi " + ArrayMethods.Average(array));

            Console.WriteLine("tersine array :");
            int[] arr2 = (ArrayMethods.Reverse(array));
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }


            Console.WriteLine();

            ArrayMethods.Remove(array,3);

            bool contains = ArrayMethods.Contains(10, array);
            Console.WriteLine("10 ededi arrayde var? " + contains);

          
            
            int[] array2 = { 11,12,13};
           int [] concat_array=ArrayMethods.Concat(array, array2);
            Console.WriteLine("concat olunmus array :");
            for (int i = 0; i < concat_array.Length; i++)
            {
                Console.Write(concat_array[i]+ " ");
            }


            ArrayMethods.Clear(array);


        }
    }
}
