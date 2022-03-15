using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class AdvertDetailDTO : IDto
    {
        public int AdvertId { get; set; }
        public string AdvertName { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime AdvertDate { get; set; }
        public bool IsSold { get; set; }
    }
}
