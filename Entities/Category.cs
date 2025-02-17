namespace Practice.Entities;

public class Category:BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public virtual ICollection<Product> Products { get; set; } = [];
}