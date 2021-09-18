using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unit_test
{
    public class Coffee{}

    public class Egg{}

    public class Bacon{}

    public class Toast{}

    public class Juice{}

    [TestFixture]
    public class DemoTest
    {
        [Test]
        public void MainTest()
        {
            Coffee cup = PourCoffee();
            CustomConsole.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            CustomConsole.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            CustomConsole.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            CustomConsole.WriteLine("toast is ready");

            Juice oj = PourOJ();
            CustomConsole.WriteLine("oj is ready");
            CustomConsole.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            CustomConsole.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            CustomConsole.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            CustomConsole.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                CustomConsole.WriteLine("Putting a slice of bread in the toaster");
            }
            CustomConsole.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            CustomConsole.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            CustomConsole.WriteLine($"putting {slices} slices of bacon in the pan");
            CustomConsole.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                CustomConsole.WriteLine("flipping a slice of bacon");
            }
            CustomConsole.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            CustomConsole.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            CustomConsole.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            CustomConsole.WriteLine($"cracking {howMany} eggs");
            CustomConsole.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            CustomConsole.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            CustomConsole.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
