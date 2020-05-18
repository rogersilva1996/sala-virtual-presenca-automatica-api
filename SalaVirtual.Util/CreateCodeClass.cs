using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaVirtual.Util
{
    public class CreateCodeClass
    {

        public string CodeClass()
        {
            var chars = "abcdefghijklmnopqrstuvxz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 6)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
