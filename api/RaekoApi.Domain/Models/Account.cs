namespace RaekoApi.Domain.Models;

public class Account 
{
    public required int Id { get; init; }
    public required string Name { get; init; } = ""; 
    public required string Currency { get; init; } = "SEK";
}
