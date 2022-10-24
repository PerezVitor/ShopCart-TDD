namespace App.ShopCart;
public class Item
{
    public Item(string name, double price, int quantity)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}