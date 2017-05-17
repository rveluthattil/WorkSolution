using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewTabbed.Models
{
    public class AuditModel
    {
        public int intAuditId { get; set; }
        public string strAuditName { get; set; }
        public DateTime dtmAuditDate { get; set; }
    }
}