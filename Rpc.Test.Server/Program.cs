using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Test.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost();
            host.Register(typeof(ITestService));
            host.Open();
        }
    }
}
