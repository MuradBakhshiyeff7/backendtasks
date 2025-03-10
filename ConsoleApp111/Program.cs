namespace ConsoleApp111
{
    internal class Program
    {
        
        
            //static long Faktorial(int n)  task-1
            //{
            //    long fakt = 1;
            //    for (int i = 2; i <= n; i++) 
            //    {
            //        fakt *= i;
            //    }
            //    return fakt;
            //}

            //static long HasiliTap(int[] arr) task-2
            //{
            //    long hasil = 1;
            //    bool hasEven = false;

            //    foreach (int eded in arr)
            //    {
            //        if (eded % 2 == 0)
            //        {
            //            hasil *= eded;
            //            hasEven = true;
            //        }
            //    }

            //    return hasEven ? hasil : 0; 
            //}


            //static int CutEdedlerinCemi(int[] arr) task-3
            //{
            //    int cem = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 2 == 0)
            //        {
            //            cem += arr[i];
            //        }
            //    }

            //    return cem;
            //}



            //static string[] OrtaqElementler(string[] arr1, string[] arr2) task-4
            //{
            //    string ortak = "";

            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        for (int j = 0; j < arr2.Length; j++)
            //        {
            //            if (arr1[i] == arr2[j] && !ortak.Contains(arr1[i]))
            //            {
            //                ortak += arr1[i] + ",";
            //            }
            //        }
            //    }

            //    return ortak.Length > 0 ? ortak.TrimEnd(',').Split(',') : new string[0];
            //}

            //static long MassivlerinHasili(int[] arr1, int[] arr2) task-5
            //{
            //    long hasil = 1;

            //    for (int i = 0; i < arr1.Length; i++) hasil *= arr1[i];
            //    for (int i = 0; i < arr2.Length; i++) hasil *= arr2[i];

            //    return hasil;
            //}
            static void Main()
            {
                //Console.Write("Ədədi daxil edin: "); task-1
                //int eded = int.Parse(Console.ReadLine());

                //if (eded < 0)
                //{
                //    Console.WriteLine("Faktorial yalnız 0 və müsbət ədədlər üçün hesablanır.");
                //}
                //else
                //{
                //    Console.WriteLine($"{eded}! = {Faktorial(eded)}");
                //}



                //int[] numbers = { 3, 6, 2, 7, 4, 9, 8 }; task-2

                //long netice = HasiliTap(numbers);

                //Console.WriteLine("2-yə bölünən ədədlərin hasili: " + netice);



                //int[] numbers = { 3, 6, 2, 7, 4, 9, 8 }; task-3

                //int netice = CutEdedlerinCemi(numbers);

                //Console.WriteLine("Cüt ədədlərin cəmi: " + netice);

                //string[] array1 = { "alma", "armud", "banan", "çiyələk" };  task-4
                //string[] array2 = { "banan", "portağal", "alma", "üzüm" };

                //string[] ortaq = OrtaqElementler(array1, array2);

                //Console.WriteLine("Ortaq elementlər: " + string.Join(", ", ortaq));


                //int[] array1 = { 2, 3, 4 }; task-5
                //int[] array2 = { 1, 5, 6 };

                //Console.WriteLine("Hasil: " + MassivlerinHasili(array1, array2));
            }
        
    }
}
