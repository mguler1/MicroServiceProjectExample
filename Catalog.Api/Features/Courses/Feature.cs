using Catalog.Api.Repositories;

namespace Catalog.Api.Features.Courses
{
    public class Feature:BaseEntity
    {
        public int Duration { get; set; }
        public float Rating { get; set; }
        public string EducatorFullName { get; set; } = default!;
    }
}
