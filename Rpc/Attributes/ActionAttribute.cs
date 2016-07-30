using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Attributes
{
    public class ActionAttribute : Attribute
    {
        public ActionAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
