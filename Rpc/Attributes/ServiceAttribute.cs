using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Attributes
{
    public class ServiceAttribute : Attribute
    {
        public ServiceAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
