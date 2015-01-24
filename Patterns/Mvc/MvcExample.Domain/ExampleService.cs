using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcExample.Domain
{
    public class ExampleService : IGetExamples
    {
        public string Get()
        {
            return "Test Data";
        }
    }
}
