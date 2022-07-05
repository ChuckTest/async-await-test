using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExceptionTest
{
    class Program
    {
        private static async void button1_Click()
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffzzz} enter button1_Click");
            await DoSomethingAsync();
        }

        private static async Task DoSomethingAsync()
        {
            await Task.Delay(2000); // simulate job

            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffzzz} DoSomethingAsync is done");

            await DoSomething2Async();
        }

        private static async Task DoSomething2Async()
        {
            await Task.Delay(1000); // simulate job

            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fffzzz} DoSomething2Async is done");
        }

        static void Main(string[] args)
        {
            try
            {
                //ControllerTest controllerTest = new ControllerTest();
                //controllerTest.GetValueAction();
                button1_Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Demystify());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
