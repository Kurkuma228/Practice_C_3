using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_14_главы.attributes
{
    internal class DeveloperInfoForBankAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string OrganizationName { get; }
        public DeveloperInfoForBankAttribute() {}
        public DeveloperInfoForBankAttribute(string developerName, string organizationName)
        {
            DeveloperName = developerName;
            OrganizationName = organizationName;
        }
    }
}
