public class Player {

    public int Id { get; set; }
	public string? Name {get; set;}
	public string? ProfileImageUrl {get; set;}
	public virtual ICollection<Deck>? Decks {get; internal set;}
}