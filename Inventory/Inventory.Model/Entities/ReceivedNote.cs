

namespace Inventory.Model.Entities
{
    public class ReceivedNote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PurchaseOrderId { get; set; }
        public DateTimeOffset GRNDate { get; set; }
        public string VendorNumber { get; set; }
        public string vendorInvoiceNumber { get; set; }
        public int WareHouseId { get; set; }
        public bool IdFullReceive { get; set; }

    }
}
