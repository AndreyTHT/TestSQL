namespace SQL
{
    internal record Order(
        int Id,
        string? UserId,
        decimal? TotalPrice,
        DateTime? OrderDate,
        string? DeliveryType,
        string? RecipientName,
        string? RecipientPhone,
        string? RecipientEmail,
        string? Address,
        string? Comment,
        List<Product> Products
    );
}