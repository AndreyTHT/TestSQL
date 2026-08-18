namespace SQL
{
    internal record OrderProduct(
        int Id,
        int OrderId,
        int ProductId,
        int? Count,
        decimal? TotalPrice
    );
}