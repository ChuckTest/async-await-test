using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unit_test
{
    [TestFixture]
    public class Demo2Test
    {
        [Test]
        public async Task MainTest()
        {
            Coffee cup = PourCoffee();
            CustomConsole.WriteLine("coffee is ready");

            Egg eggs = await FryEggsAsync(2);
            CustomConsole.WriteLine("eggs are ready");

            Bacon bacon = await FryBaconAsync(3);
            CustomConsole.WriteLine("bacon is ready");

            Toast toast = await ToastBreadAsync(2);
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

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                CustomConsole.WriteLine("Putting a slice of bread in the toaster");
            }
            CustomConsole.WriteLine("Start toasting...");
            await Task.Delay(3000);
            CustomConsole.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            CustomConsole.WriteLine($"putting {slices} slices of bacon in the pan");
            CustomConsole.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                CustomConsole.WriteLine("flipping a slice of bacon");
            }
            CustomConsole.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            CustomConsole.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            CustomConsole.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            CustomConsole.WriteLine($"cracking {howMany} eggs");
            CustomConsole.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
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
