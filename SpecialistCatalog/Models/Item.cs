﻿using System;

namespace SpecialistCatalog.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool Is_AISnaGT { get; set; }
        public bool Is_ITPRIS { get; set; }
        public bool Is_SII { get; set; }
    }
}