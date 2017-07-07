using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureKeyVault.Config
{
    public class AppConfiguration
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string HumanKode { get; set; }
    }
}
