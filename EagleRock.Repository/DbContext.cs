using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//using RedisCacheDemo.Model;

namespace EagleRock.Repository
{
    using EagleRock.Repository.Models;
    using Microsoft.EntityFrameworkCore;

    
 
    public class TrafficSegmentContext : DbContext
    {
        public TrafficSegmentContext(DbContextOptions<TrafficSegmentContext> options) : base(options) { }
        public DbSet<TrafficSegment> TrafficSegments
        {
            get;
            set;
        }
    }
  
}
