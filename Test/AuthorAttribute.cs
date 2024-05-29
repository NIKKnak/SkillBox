using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public double Version { get; set; }
        public AuthorAttribute(string name,double version)
        {
            this.Name = name;
            this.Version = version;
        }


    }
}
