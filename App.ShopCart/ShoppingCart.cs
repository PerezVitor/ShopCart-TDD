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
        Itens.Add(item);
    }

    public bool RemoveItem(Item item)
    {
        return Itens.Remove(item);
    }
}
