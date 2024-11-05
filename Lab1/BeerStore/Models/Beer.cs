namespace BeerStore.Models
{
  public class Beer
  {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Taste { get; set; }
  }
}
