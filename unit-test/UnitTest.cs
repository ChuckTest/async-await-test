using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
