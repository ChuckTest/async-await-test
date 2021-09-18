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
            await GetNumber().ConfigureAwait(false);
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}===");
            Console.WriteLine($"out time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
        }

        public async Task GetNumber()
        {
            await Task.Delay(5000);
        }

        [Test]
        public async Task Test20210918_002()
        {
            await MyMethodAsync();
        }

        public async Task MyMethodAsync()
        {
            Console.WriteLine($"chuck1 time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            Console.WriteLine($"chuck2 time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
            //int result = await longRunningTask;
            await longRunningTask;
            Console.WriteLine($"chuck3 time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
            //use the result 
            //Console.WriteLine(result);
            Console.WriteLine($"chuck4 time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
        }

        public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            await Task.Delay(3000); // 3 seconds delay
            return 1;
        }
    }
}
