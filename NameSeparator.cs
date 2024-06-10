using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorica_Residences_Rental_Management_System
{
    internal class NameSeparator
    {
        public NameSeparator() { }
        public string GetLastNameFromFullName(string fullName)
        {
            var parts = fullName.Split(',');
            return parts[0].Trim();
        }

        public string GetFirstNameFromFullName(string fullName)
        {
            var parts = fullName.Split(',');
            if (parts.Length > 1)
            {
                var nameParts = parts[1].Trim().Split(' ');
                return nameParts[0];
            }
            return string.Empty;
        }

        public string GetMiddleNameFromFullName(string fullName)
        {
            var parts = fullName.Split(',');
            if (parts.Length > 1)
            {
                var nameParts = parts[1].Trim().Split(' ');
                return nameParts.Length > 1 ? nameParts[1] : string.Empty;
            }
            return string.Empty;
        }
    }
}
