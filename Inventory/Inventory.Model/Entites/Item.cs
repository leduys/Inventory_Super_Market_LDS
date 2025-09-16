using Inventory.Service.EnumShares;

namespace Inventory.Model.Entites
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AvailQuantity { get; set; }
        public EnumStatusItem Status { get; set; }
    }
}
