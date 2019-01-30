using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    public static class ExtensionClass
    {
        public static int GetAge(this DateTime? birthdate)
        {
            if (!birthdate.HasValue)
            {
                return -1;
            }
            
            var today = DateTime.Today;
            
            var age = today.Year - birthdate.Value.Year;
            if (birthdate > today.AddYears(-age)) age--;

            return age;
        }
    }
}
