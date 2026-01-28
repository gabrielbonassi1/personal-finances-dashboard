namespace DispensaVirtual.Domain.Entities;

public class Store
{
  public Guid Id {get; set; }
  public string Name { get; set; } = string.Empty;
  public string Address { get; set; } = string.Empty;
  public string Notes { get; set; } = string.Empty;

  public ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
}