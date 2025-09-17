
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inventory.Model.Entities

namespace Inventory.Repository.Response
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MeasureUnit> MeasureUnits { get; set; }
        public DbSet<NumberSequence> NumberSequences { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentReceive> PaymentReceives { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PaymentVoucher> PaymentVouchers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurChaseOrderLine> PurChaseOrderLines { get; set; }
        public DbSet<PurchaseType> PurchaseTypes { get; set; }
        public DbSet<ReceivedNote> ReceivedNotes { get; set; }
        public DbSet<SaleOrder> SaleOrders { get; set; }
        public DbSet<SaleOrderLine> SaleOrderLines { get; set; }
        public DbSet<SaleType> SaleTypes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentTypeId> ShipmentTypeIds { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
    }
}
