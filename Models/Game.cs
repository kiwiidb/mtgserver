public class Game
{
    public int Id { get; set; }
    public string? Winner { get; set; }
    public string? Player2 { get; set; }
    public string? Player3 { get; set; }
    public string? Player4 { get; set; }
    
    public string? WinningDeck { get; set; }
    public string? Deck2 { get; set; }
    public string? Deck3 { get; set; }
    public string? Deck4 { get; set; }
    public string? WinningDeckCommander { get; set; }
    public string? Deck2Commander { get; set; }
    public string? Deck3Commander { get; set; }
    public string? Deck4Commander { get; set; }
    
    public int DurationMinutes { get; set; }
    public string? Description { get; set; }
	public DateTime? CreatedAt { get; set; }
}
