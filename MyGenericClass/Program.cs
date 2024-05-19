using System;
namespace MyGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            myGeneric<double> doubles = new myGeneric<double>(); // <T> Only Struct! (value type)


            for (int i = 0; i < 10; i++)
            {
                doubles.Add(i);

            }

            //indexer
            var value = doubles[0];


            //Filter
            var list2 = doubles.Where2(x => x > 5);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
