using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace async_await_test
{
    [TestFixture]
    public class MainTest
    {
        [Test]
        public void Test1()
        {

        }

        static async Task AwaitMyAwaitable()
        {
            MyAwaitableClass class1 = new MyAwaitableClass();
            await class1;

        }
    }
}
