using System;
using System.Collections.Generic;

namespace TFTApp.Data.Models.DAL
{
    public partial class ItemComponentStat
    {
        public int ItemComponentStatId { get; set; }
        public int ItemComponentId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }

        public ItemComponent ItemComponent { get; set; }
    }
}
