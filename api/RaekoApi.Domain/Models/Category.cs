using RaekoApi.Domain.Enums;

namespace RaekoApi.Domain.Models;
public class Category
{
    public required int Id { get; init; }
    public required string Name { get; init; } = "";
    public required CategoryType Type { get; init; } = CategoryType.Expense;
}