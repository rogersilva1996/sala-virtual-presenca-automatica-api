using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.Services
{
    public class ServiceTest : IServiceTest
    {
        public int calc(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
