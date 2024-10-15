namespace Practice.Entities;

public class Product:BaseEntity
{
    public string Name { get; set; }= null!;
    public string Description { get; set; }= null!;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }= null!;
}