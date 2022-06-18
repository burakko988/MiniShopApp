using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class CardModel
    {
        public int CardId { get; set; }
        public List<CardItemModel> CardItems { get; set; }
        public double TotalPrice()
        {
            return CardItems.Sum(i => i.Price * i.Quantity);
        }
    }

    public class CardItemModel
    {
        public int CardItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }

    }
}
