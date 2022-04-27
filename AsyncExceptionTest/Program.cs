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
        static void Main(string[] args)
        {
            try
            {
                ControllerTest controllerTest = new ControllerTest();
                controllerTest.GetValueAction();
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
