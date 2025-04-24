namespace ShopMax.Business.Models;

public abstract class Entity
{
	public int Id { get; set; }
	public string Name { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
}
