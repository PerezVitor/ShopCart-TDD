namespace App.ShopCart;
public class ShoppingCart
{
    public List<Item> Itens { get; set; }

    public ShoppingCart()
    {
        Itens = new List<Item>();
    }

    public void InsertItem(Item item)
    {
        var newItem = new Item(item.Name, item.Price, item.Quantity);
        Itens.Add(newItem);
    }

    public bool RemoveItem(Item item)
    {
        return Itens.Remove(item);
    }
}
