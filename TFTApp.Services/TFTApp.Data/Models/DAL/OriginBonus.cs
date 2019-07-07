using System;
using System.Collections.Generic;

namespace TFTApp.Data.Models.DAL
{
    public partial class OriginBonus
    {
        public int BonusId { get; set; }
        public short Needed { get; set; }
        public string Effect { get; set; }
    }
}
