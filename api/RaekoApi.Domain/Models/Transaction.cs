namespace RaekoApi.Domain.Models;
public class Transaction
{
    public required int Id { get; init; }
    public required int AccountId { get; init; }
    public required Account Account { get; init; } = null!;
    public int? CategoryId { get; init; }
    public Category? Category { get; init; }
    public required decimal Amount { get; init; }
    public required DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    public required string? Note { get; init; }
    public required DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
