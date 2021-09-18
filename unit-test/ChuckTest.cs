using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unit_test
{
    [TestFixture]
    public class ChuckTest
    {
        [Test]
        public async Task Test20210918_001()
        {
            Console.WriteLine($"in time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}"); 
            await GetNumber();
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}===");
            Console.WriteLine($"out time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
        }

        public async Task GetNumber()
        {
            await Task.Delay(5000);
        }
    }
}
