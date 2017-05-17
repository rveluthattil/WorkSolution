using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewTabbed.Models
{
    public class TransactionModel
    {
        public int intTransactionId { get; set; }
        public string strTransactionName { get; set; }
        public DateTime dtmTransactionDate { get; set; }
    }
}