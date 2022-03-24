using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseToList
{
    [MemoryDiagnoser]
    public class LinqTest
    {
        [Benchmark]
        public void NoToListTest()
        {
            var list = Enumerable.Range(0, 50000000);
            var filteredlist = list.Where(element => element % 100000 == 0);
            foreach (var element in filteredlist)
            {
                //some logic here
            }
            foreach (var element in filteredlist)
            {
                // some logic here
            }
            foreach (var element in filteredlist)
            {
                // some logic here
            }
        }
        [Benchmark]
        public void ToListTest()
        {
            var list = Enumerable.Range(0, 5000000);
            var filteredlist = list.Where(element => element % 10000 == 0).ToList();
            //ToList() method will execute the expression tree and get the result for future purpose.
            foreach (var element in filteredlist)
            {
                // some logic here
            }
            foreach (var element in filteredlist)
            {
                // some logic here
            }
            foreach (var element in filteredlist)
            {
                // some logic here
            }
        }
        public static void Main()
        {
            //Execute LinqTest class methods to check the benchmark
            var result = BenchmarkRunner.Run<LinqTest>();
            Console.ReadLine();
        }
    }
}
