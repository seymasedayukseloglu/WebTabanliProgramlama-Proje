namespace Florals.Models;

public class Product
{
    public int ID { get; set; }
    public string ProductName { get; set; } = "";
    public string Category { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public string StockStatus { get; set; } = "";
    public decimal? Rating { get; set; } 
    public string Fragrance { get; set; } = "";
    public string ImagePath { get; set; } = "";
}
