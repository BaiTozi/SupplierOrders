namespace SupplierOrders.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
