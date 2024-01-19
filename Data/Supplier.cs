namespace SupplierOrders.Data
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
