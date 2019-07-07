﻿using System;
using System.Collections.Generic;

namespace TFTApp.Data.Models.DAL
{
    public partial class ItemLink
    {
        public int ItemFullId { get; set; }
        public int ItemComponentId { get; set; }

        public ItemComponent ItemComponent { get; set; }
        public ItemFull ItemFull { get; set; }
    }
}
