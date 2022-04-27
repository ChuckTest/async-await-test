using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExceptionTest
{
    class ControllerTest
    {
        public double GetValueAction()
        {
            return this.GetValue().Result;
        }

        public async Task<double> GetValue()
        {
            return await this.GetValue2().ConfigureAwait(false);
        }

        public async Task<double> GetValue2()
        {
            throw new InvalidOperationException("Couldn't get value!");
        }
    }
}
