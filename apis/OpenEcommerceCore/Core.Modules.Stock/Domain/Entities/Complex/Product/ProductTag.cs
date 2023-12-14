namespace Core.Modules.Stock.Domain.Entities.Complex.Product;

internal class ProductTag
{
    public Guid Id { get; init; }
    public string Name { get; set; }
    
    // Relationships
    public List<Product> TaggedProducts { get; set; }

    private ProductTag()
    {}

    public static ProductTag Create(Guid id, string name)
    {
        return new ProductTag
        {
            Id = id,
            Name = name
        };
    }
}