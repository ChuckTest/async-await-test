using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unit_test
{
    //https://stackoverflow.com/questions/12144077/async-await-when-to-return-a-task-vs-void
    [TestFixture]
    class ExceptionTest
    {
        static async void f()
        {
            try
            {
                await h();
            }
            catch
            {
                CustomConsole.WriteLine("Exception caught in f()");
                throw;
            }
        }

        static async Task g()
        {
            try
            {
                await h();
            }
            catch
            {
                CustomConsole.WriteLine("Exception caught in g()");
                throw;
            }
        }

        static async Task h()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void button1_Click()
        {
            try
            {
               f();
            }
            catch
            {
                CustomConsole.WriteLine("Exception caught in button1_Click()");
            }
        }

        [Test]
        public async Task button2_Click()
        {
            try
            {
                await g();
            }
            catch
            {
                CustomConsole.WriteLine("Exception caught in button2_Click()");
            }
        }

        [Test]
        public void button3_Click()
        {
            try
            {
                GC.Collect();
            }
            catch
            {
                CustomConsole.WriteLine("Exception caught in button3_Click()");
            }
        }
    }
}
