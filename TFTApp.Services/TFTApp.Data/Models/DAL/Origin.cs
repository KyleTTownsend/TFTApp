using System;
using System.Collections.Generic;

namespace TFTApp.Data.Models.DAL
{
    public partial class Origin
    {
        public Origin()
        {
            OriginBonusLink = new HashSet<OriginBonusLink>();
        }

        public int OriginId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ImgId { get; set; }

        public ICollection<OriginBonusLink> OriginBonusLink { get; set; }
    }
}
