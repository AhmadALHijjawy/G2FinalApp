using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G2FinalApp.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientImg { get; set; }
        public string ClientRank { get; set; }
        public string FacebookAcc { get; set; }
        public string TwitterAcc { get; set; }
        public string LinkedinAcc { get; set; }
        public string Gmail { get; set; }
    }
}
