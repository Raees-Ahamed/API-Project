using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMP_Web_Hook_Test.Models
{
    public class TransactionSettledWebHookModel
    {
        public long AgentUserId { get; set; }
        public string Nonce { get; set; }
        [StringLength(200)]
        public string XRequestId { get; set; }

        public TransactionSettledWebHookModel()
        {

        }
    }
}
