using App.ShopCart;

namespace Test.ShopCart;
public class UnitTest
{
    [Fact]
    public void Check_InsertItemOnShoppingCart()
    {
        //Arrange
        var item = new Item("Shirt", 29.99, 1);
        var shopCart = new ShoppingCart();

        //Act
        shopCart.InsertItem(item);

        //Assert
        Assert.Contains(item, shopCart.Itens);
    }
}