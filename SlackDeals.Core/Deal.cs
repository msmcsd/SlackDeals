using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SlackDeals.Core
{
    // All the code in this file is included in all platforms.
    public class Deal       
    {
        public ObjectId Id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("found_by")]
        public string FoundBy { get; set; }

        [BsonElement("found_time")]
        public DateTime FoundTime { get; set; }

        [BsonElement("current_price")]
        public double CurrentPrice { get; set; }

        [BsonElement("orig_price")]
        public double OriginalPrice { get; set; }

        [BsonElement("shipping")]
        public float Shipping { get; set; }

        [BsonElement("merchant")]
        public string Merchant { get; set; }

        [BsonElement("like_count")]
        public int Likes { get; set; }

        [BsonElement("coment_count")]
        public int Comments { get; set; }

        [BsonElement("image_url")]
        public string DealImageUrl { get; set; }

        [BsonElement("founder_image_url")]
        public string DealFounderImageUrl { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }
    }
}