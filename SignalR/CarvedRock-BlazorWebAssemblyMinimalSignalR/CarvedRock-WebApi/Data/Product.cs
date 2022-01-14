using System.ComponentModel.DataAnnotations;

namespace CarvedRock_WebApi.Data;

public class Product
{
    public int Id { get; set; }

    [Required, StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Range(0.0, (double)decimal.MaxValue)]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

    public string PhotoFileName { get; set; } = string.Empty;
}
