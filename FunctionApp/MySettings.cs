using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    public class MySettings
    {
        public required string SqlConnection { get; set; }

        public required string KeyVaultUrl { get; set; }
    }
}
