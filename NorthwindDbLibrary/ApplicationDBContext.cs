using Microsoft.EntityFrameworkCore;
using System;

namespace NorthwindDbLibrary
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext() { }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        { }
    }
}
