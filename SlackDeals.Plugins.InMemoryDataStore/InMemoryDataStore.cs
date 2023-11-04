using SlackDeals.Core;
using SlackDeals.UseCases.PluginInterfaces;

namespace SlackDeals.Plugins.DataStore.InMemory
{
    // All the code in this file is included in all platforms.
    public class InMemoryDataStore : IDataStore
    {
        public Task<List<Deal>> GetDeals()
        {
            var deals = new List<Deal> {
                new Deal
                {
                    Description = "$50 Chipotle eGift Card (Digital Delivery)",
                    FoundBy = "tunabreath",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 45,
                    OriginalPrice = 50,
                    Condition = "+ Free Shipping",
                    Merchant = "Best Buy",
                    Likes = 16,
                    Comments = 15,
                    DealImageUrl = "https://static.slickdealscdn.com/attachment/3/8/0/3/8/5/8/200x200/14462224.thumb",
                    DealFounderImageUrl = "https://static.slickdealscdn.com/images/avatar-25.png",
                    Type = "For you"
                },
                new Deal
                {
                    Description = "205-Piece Mega Construx Pokemon Pikachu 4\" Poseable Building Toy",
                    FoundBy = "dubba-low",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 8,
                    OriginalPrice = 21.99,
                    Condition = "",
                    Merchant = "Amazon",
                    Likes = 15,
                    Comments = 21,
                    DealImageUrl = "https://static.slickdealscdn.com/attachment/3/8/9/0/8/6/200x200/14467042.thumb",
                    DealFounderImageUrl = "https://static.slickdealscdn.com/attachment/avatar/3/8/9/0/8/6/25x25/avatar.static?dateline=1681157824",
                    Type = "Personalized"
                },
                new Deal
                {
                    Description = "Samsonite Omni PC Hardside Expandable Luggage 3-Piece Set(Black) for $189.99 + $6 Shipping",
                    FoundBy = "gbcue",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 189.99,
                    OriginalPrice = 299.99,
                    Condition = "& More + Free Shipping",
                    Merchant = "Home Depot",
                    Likes = 16,
                    Comments = 15,
                    DealImageUrl = "https://static.slickdealscdn.com/attachment/1/2/8/6/8/4/200x200/14447320.thumb",
                    DealFounderImageUrl = "https://static.slickdealscdn.com/attachment/avatar/1/2/8/6/8/4/25x25/avatar.static?dateline=1408565583",
                    Type = "For you"
                },
                new Deal
                {
                    Description = "1.32-Lb Optimum Nutrition Micronized Creatine Monohydrate Powder (Unflavored)",
                    FoundBy = "firejr33",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 22.70,
                    OriginalPrice = 35,
                    Condition = "w/ Subscribe & Save",
                    Merchant = "Amazon",
                    Likes = 12,
                    Comments = 9,
                    DealImageUrl = "https://static.slickdealscdn.com/attachment/1/6/0/8/9/5/2/200x200/14466232.thumb",
                    DealFounderImageUrl = "https://static.slickdealscdn.com/images/avatar-25.png",
                    Type = "Personalized"
                },
                new Deal
                {
                    Description = "Samsonite Evolve SE Hardside Expandable Luggage w/ Spinner Wheels: 28\" $89, 20\"",
                    FoundBy = "iconian",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 69,
                    OriginalPrice = 180,
                    Condition = "& More + Free Shipping",
                    Merchant = "BuyDig",
                    Likes = 15,
                    Comments = 21,
                    DealImageUrl = "https://slickdeals.net/attachment/9/5/3/2/3/200x200/14462131.thumb",
                    DealFounderImageUrl = "https://slickdeals.net/lp/wp-content/uploads/global/user.svg",
                    Type = "Personalized"
                },
                new Deal
                {
                    Description = "Acer Chromebook Plus 515 Laptop: i3-1215U, 15.6\" 1080p, 8GB RAM, 128GB UFS",
                    FoundBy = "SerenoG",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 269,
                    OriginalPrice = 399,
                    Condition = "+ Free Shipping",
                    Merchant = "Best Buy",
                    Likes = 15,
                    Comments = 21,
                    DealImageUrl = "https://slickdeals.net/attachment/7/1/4/9/0/7/4/200x200/14411866.thumb",
                    DealFounderImageUrl = "https://slickdeals.net/attachment/avatar/7/1/4/9/0/7/4/150x150/avatar.normal?dateline=1691600409",
                    Type = "Promoted"
                },                
                //new Deal
                //{
                //    Description = "",
                //    FoundBy = "",
                //    FoundTime = DateTime.Now,
                //    CurrentPrice = 0,
                //    OriginalPrice = 0,
                //    Condition = "",
                //    Merchant = "Amazon",
                //    Likes = 15,
                //    Comments = 21,
                //    DealImageUrl = "",
                //    DealFounderImageUrl = "",
                //    Type = "Personalized"
                //},
            };

            return Task.FromResult(deals);
        }
    }
}