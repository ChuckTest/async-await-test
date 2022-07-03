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
            await h();
        }

        static async Task g()
        {
            await h();
        }

        static async Task h()
        {
            //await Task.Delay(1000);
            throw new NotImplementedException();
        }

        [Test]
        public void button1_Click()
        {
            try
            {
                f();
            }
            catch (Exception ex)
            {
                CustomConsole.WriteLine(ex.ToString());
            }
        }

        [Test]
        public void button2_Click()
        {
            try
            {
                g();
            }
            catch (Exception ex)
            {
                CustomConsole.WriteLine(ex.ToString());
            }
        }

        [Test]
        public void button3_Click()
        {
            try
            {
                GC.Collect();
            }
            catch (Exception ex)
            {
                CustomConsole.WriteLine(ex.ToString());
            }
        }
    }
}
