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
    public class UnitTest
    {
        private async void button1_Click()
        {
            await DoSomethingAsync();
        }

        private async Task DoSomethingAsync()
        {
            await Task.Delay(3000); // simulate job

            CustomConsole.WriteLine("DoSomethingAsync is done");

            await DoSomething2Async();
        }

        private async Task DoSomething2Async()
        {
            await Task.Delay(3000); // simulate job

            CustomConsole.WriteLine("DoSomething2Async is done");
        }

        [Test]
        public void Test2022_0705_001()
        {
            button1_Click();
            CustomConsole.WriteLine("Hello world");
        }

        [Test]
        public void Test2022_0705_002()
        {
            var threadCount = 5;
            var batchSize = 30;
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < threadCount; i++)
            {
                tasks.Add(ExecuteActionOrderV9( i, batchSize));
            }

            string result = string.Empty;
            if (tasks.Count > 0)
            {
                Task.WaitAll(tasks.ToArray());
                var taskT = tasks.Select(x => ((Task<string>)x));
                result = string.Join(Environment.NewLine, taskT.Select(x => x.Result));
            }

            Console.WriteLine(result);
        }

        public async Task<string> ExecuteActionOrderV9(int index, int batchSize)
        {
            var val = await Task.Run(async () =>
            {
                //Console.WriteLine($"");
                var threadCount = 5;
                var sleepTime = (threadCount - index) * 1000;
                await Task.Delay(sleepTime);

                string str = $"{nameof(index)} = {index}, ThreadId = {Thread.CurrentThread.ManagedThreadId}, {DateTime.Now:yyyy-MM-dd HH:mm:ss.fffzzz}";
                return str;
            });
            return val;
        }
    }
}
