using App.ShopCart;

namespace Test.ShopCart;
public class UnitTest
{
    private Item ItemShop { get; set; }
    private ShoppingCart ShoppingCart { get; set; }

    public UnitTest()
    {
        ItemShop = new Item("Shirt", 29.99, 1);
        ShoppingCart = new ShoppingCart();
    }

    [Fact]
    public void Check_InsertItemOnShoppingCart()
    {
        ShoppingCart.InsertItem(ItemShop);
        var item = ShoppingCart.Itens.FirstOrDefault(i => i.Name == ItemShop.Name);

        Assert.NotNull(item);
    }

    [Fact]
    public void Check_RemoveItemFromShoppingCart()
    {
        ShoppingCart.InsertItem(ItemShop);
        var item = ShoppingCart.Itens.First(i => i.Name == ItemShop.Name);

        bool itemRemoved = ShoppingCart.RemoveItem(item);

        Assert.True(itemRemoved);
    }

    [Fact]
    public void Check_ChangeQuantityItemOnShoppingCart()
    {
        ShoppingCart.InsertItem(ItemShop);
        int additionalQuantity = 2;
        ItemShop.Quantity += additionalQuantity;

        ShoppingCart.UpdateQuantityItem(ItemShop.Name, additionalQuantity);
        var item = ShoppingCart.Itens.First(i => i.Name == ItemShop.Name);

        Assert.Equal(ItemShop.Quantity, item.Quantity);
    }
}