namespace SQL
{
    internal record Product(
        int Id,
        string? Article,
        string? Name,
        string? Image,
        int? CategoryId,
        decimal? Price,
        int? Count
    );
}