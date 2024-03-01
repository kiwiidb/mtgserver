public class Player {

    public int Id { get; set; }
	public string? Name {get; set;}
	public virtual ICollection<Deck>? Decks {get; internal set;}
}