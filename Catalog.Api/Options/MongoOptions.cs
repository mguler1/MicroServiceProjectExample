using System.ComponentModel.DataAnnotations;

namespace Catalog.Api.Options
{
    public class MongoOptions
    {
        public string DatabaseName { get; set; } = default!;
       
        public string ConnectionString { get; set; } = default!;
    }
}
