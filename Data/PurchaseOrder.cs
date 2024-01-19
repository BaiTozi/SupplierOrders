namespace SupplierOrders.Data
{
    public class PurchaseOrder
    {
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
