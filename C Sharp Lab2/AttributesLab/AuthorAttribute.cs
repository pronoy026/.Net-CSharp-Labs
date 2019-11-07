using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesLab
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    class AuthorAttribute : Attribute
    {
        private string Name;
        public double Version { get; set; }
        public AuthorAttribute(string name)
        {
            this.Name = name;
            Version = 1.1;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
