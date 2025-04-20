using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainForGlory_Common.DTOs
{
    public class UpdateAccount
    {
        public string? NewUsername { get; set; }
        public string? NewEmail { get; set; }
        public string? NewPassword { get; set; }
        public string CurrentPassword { get; set; } = string.Empty;
    }
}

