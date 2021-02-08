﻿using System;

namespace RealPage.RealEstateProperties.Entity
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Owner { get; set; }
        public int RoomCount { get; set; }
        public DateTime DateOnMarket { get; set; }
        public int PropertyTypeId { get; set; }
        public PropertyType  PropertyType { get; set; }
    }
}