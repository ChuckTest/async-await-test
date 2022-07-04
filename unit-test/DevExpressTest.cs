using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unit_test
{
    //https://www.cnblogs.com/chucklu/p/16437480.html
    //https://supportcenter.devexpress.com/ticket/details/t372965/asynccommand-exception-handling
    [TestFixture]
    public class DevExpressTest
    {
        void Go()
        {
            try
            {
                Refresh().ContinueWith((t) => { });
            }
            catch
            {
                Console.WriteLine("Exception caught in Go()");
                throw;
            }
        }

        async Task Refresh()
        {
            try
            {
                //await Task.Delay(2000);
                throw new Exception("Test exception");
            }
            catch
            {
                Console.WriteLine("Exception caught in Refresh()");
                throw;
            }
        }

        async void Go1()
        {
            try
            {
                await Refresh();
            }
            catch
            {
                Console.WriteLine("Exception caught in Go1() with await");
            }
        }

        [Test]
        public void Test2022_0704_001()
        {
            Go();
        }

        [Test]
        public void Test2022_0704_002()
        {
            Go1();
        }
    }

}
