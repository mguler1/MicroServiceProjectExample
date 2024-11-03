using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Api.Repositories
{
    public class BaseEntity
    {
        [BsonElement("_id")] public Guid Id { get; set; }
    }
}
