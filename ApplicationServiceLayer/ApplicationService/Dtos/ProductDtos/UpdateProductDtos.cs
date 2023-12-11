namespace ApplicationServiceLayer.ApplicationService.Dtos.ProductDtos;

public class UpdateProductDtos
{
    public Guid Id { get; set; }

    public string? ProductCode { get; set; }

    public string? Title { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }
}
