using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await_test
{
    public class MyAwaiter
    {

    }

    public class MyAwaitableClass
    {
        public MyAwaiter GetAwaiter()
        {
            return new MyAwaiter();
        }
    }
}
