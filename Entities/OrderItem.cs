namespace Practice.Entities;

public class OrderItem:BaseEntity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public virtual Order Order { get; set; } = null!;
    public virtual Product Product { get; set; }= null!;
}