﻿using Catalog.Api.Features.Courses;
using Catalog.Api.Repositories;

namespace Catalog.Api.Features.Categories
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } = default!;
        public List<Course>? Courses { get; set; }
    }
}