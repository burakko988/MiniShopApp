using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using System.Linq;

namespace MiniShopApp.WebUI.Controllers
{
    public class CardController : Controller
    {
       
            private ICardService _cardService;
        private UserManager<User> _userManager;
        public CardController(ICardService cardService, UserManager<User> userManager)
        {
            _cardService = cardService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var card = _cardService.GetCardByUserId(userId);
            return View(new CardModel()
            {
                CardId = card.Id,
                CardItems= card.CardItems.Select(i=>new CardItemModel()
                {
                    CardItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price =(decimal)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList()
            });
        }
    }
}
