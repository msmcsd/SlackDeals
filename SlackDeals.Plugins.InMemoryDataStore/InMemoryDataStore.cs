using SlackDeals.Core;
using SlackDeals.UseCases.PluginInterfaces;

namespace SlackDeals.Plugins.InMemoryDataStore
{
    // All the code in this file is included in all platforms.
    public class InMemoryDataStore : IDataStore
    {
        public List<Deal> GetDeals()
        {
            return new List<Deal> {
                new Deal
                {
                    Description = "Samsonite Omni PC Hardside Expandable Luggage 3-Piece Set(Black) for $189.99 + $6 Shipping",
                    FoundBy = "SmartTable7913",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 189.99,
                    OriginalPrice = 299.99,
                    Shipping = 6,
                    Merchant = "Woot!",
                    Likes = 16,
                    Comments = 15,
                    DealImageUrl = "https://slickdeals.net/f/17027914-samsonite-omni-pc-hardside-expandable-luggage-3-piece-set-black-for-189-99-6-shipping?src=frontpage_recombee&prop=rcmid-6d3f66c5a05b704909820ad4e72f1c37",
                    DealFounderImageUrl = "https://static.slickdealscdn.com/images/avatar-25.png",
                    Type = "For you"
                },
                new Deal
                {
                    Description = "Kamado Joe 18\" Classic Joe III Charcoal Grill w/ Cart & Side Shelves (Blaze Red)",
                    FoundBy = "leon98408",
                    FoundTime = DateTime.Now,
                    CurrentPrice = 1054,
                    OriginalPrice = 1999,
                    Shipping = 0,
                    Merchant = "Amazon",
                    Likes = 15,
                    Comments = 21,
                    DealImageUrl = "https://slickdeals.net/f/17029588-amazon-com-kamado-joe-kj15040921-classic-joe-iii-18-inch-charcoal-grill-with-cart-and-side-shelves-blaze-red-everything-else-1054-01?src=frontpage_recombee&prop=rcmid-6d3f66c5a05b704909820ad4e72f1c37",
                    DealFounderImageUrl = "https://static.slickdealscdn.com/images/avatar/sd/redesign/Hot-Deals.gif",
                    Type = "Personalized"
                },
            };
        }
    }
}