using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_14_главы.attributes
{
    internal class DeveloperInfoAttribute : Attribute
    {
        public string NameDeveloper {  get; }
        public DateTime TimeDevelope {  get; }

        public DeveloperInfoAttribute() { }

        public DeveloperInfoAttribute(string nameDeveloper)
        {
            NameDeveloper = nameDeveloper;
        }
        public DeveloperInfoAttribute(string nameDeveloper, string timeDevelope)
        {
            NameDeveloper = nameDeveloper;
            TimeDevelope = DateTime.Parse(timeDevelope);
        }
    }
}
