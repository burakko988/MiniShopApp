using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EfCoreCardRepository : EfCoreGenericRepository<Card, MiniShopContext>, ICardRepository
    {
        public Card GetByUserId(string userId)
        {
            using (var context = new MiniShopContext())
            {
                return context.Cards.Include(i=>i.CardItems).ThenInclude(i=>i.Product).FirstOrDefault(i=>i.UserId==userId);
            }
        }
    }
}
