namespace Core.Modules.Stock.Domain.Entities.Product.ProductDetails;

internal class TechnicalDetail 
{
    public Guid Id { get; init; }
    public Product Product { get; init; }
    public int ShowOrder { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public MeasureUnit? MeasureUnit { get; set; }
    
    private TechnicalDetail()
    {}
    
    public static TechnicalDetail Create(
        Product product, 
        int showOrder,
        string name,
        string value, 
        MeasureUnit? measureUnit)
    {
        return new TechnicalDetail
        {
            Id = Guid.NewGuid(),
            Product = product,
            ShowOrder = showOrder,
            Name = name,
            Value = value,
            MeasureUnit = measureUnit
        };
    }
}