using System;
using System.Collections.Generic;

namespace TFTApp.Data.Models.DAL
{
    public partial class ClassBonusLink
    {
        public int ClassId { get; set; }
        public int ClassBonusId { get; set; }

        public Class Class { get; set; }
        public ClassBonus ClassBonus { get; set; }
    }
}
