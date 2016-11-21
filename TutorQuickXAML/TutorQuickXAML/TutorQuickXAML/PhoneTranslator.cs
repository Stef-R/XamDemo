using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorQuickXAML
{
    public static class PhoneTranslator
    {
        public static string ToNumber(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return null;
            raw = raw.ToUpperInvariant();

            var newNumber = new StringBuilder();
            foreach (var c in raw)
            {
                if ("-0123456789".Contains(c))
                    newNumber.Append(c);
                else
                {
                    var result = 0;//....
                }
            }
        }

        static int? TranslateToNumber(char c)
        {
            for (int i = 0; i < length; i++)
            {
                if (true)
                    return 0;
            }
            return null;
        }
    }
}
