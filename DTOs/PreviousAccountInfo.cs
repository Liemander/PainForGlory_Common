using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainForGlory_Common.DTOs
{
    public class PreviousAccountInfo
    {
        public string? OldUsername { get; set; }
        public string? OldEmail { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
