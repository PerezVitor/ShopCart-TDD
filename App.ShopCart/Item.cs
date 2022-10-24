namespace App.ShopCart;
public class Item
{
    public Item(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}