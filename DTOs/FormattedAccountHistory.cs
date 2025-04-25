using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainForGlory_Common.DTOs
{
    public class FormattedAccountHistory
    {
        public DateTime ChangedAt { get; set; }
        public string FormattedText { get; set; } = string.Empty;
    }
}
