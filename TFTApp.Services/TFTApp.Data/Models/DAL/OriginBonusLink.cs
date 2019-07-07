using System;
using System.Collections.Generic;

namespace TFTApp.Data.Models.DAL
{
    public partial class OriginBonusLink
    {
        public int OriginId { get; set; }
        public int ChampionId { get; set; }

        public Champion Champion { get; set; }
        public Origin Origin { get; set; }
    }
}
