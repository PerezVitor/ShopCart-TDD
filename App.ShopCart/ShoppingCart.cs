using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
