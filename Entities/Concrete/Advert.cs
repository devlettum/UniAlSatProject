using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Advert : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string AdvertName { get; set; }
        public string Description { get; set; }
        public DateTime AdvertDate { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        public int UserId { get; set; }
    }
}
