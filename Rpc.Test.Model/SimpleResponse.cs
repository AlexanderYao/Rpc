using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Test.Model
{
    public class SimpleResponse
    {
        public bool IsSuccess { get; set; }
        public Exception Error { get; set; }
        public string ErrorDesc { get; set; }
    }
}
