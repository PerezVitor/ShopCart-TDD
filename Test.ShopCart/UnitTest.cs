namespace Test.ShopCart;
public class UnitTest
{
    [Fact]
    public void Check_InsertItemOnShopCart()
    {
        //AAA
        //Arrange
        var item = new Item("Shirt", 29.99, 1);
        var shopCart = new ShopCart();

        //Act
        shopCart.InsertItem(item);

        //Assert
        Assert.Contains(item, shopCart.Itens);
    }
}