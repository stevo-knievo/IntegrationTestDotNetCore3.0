using System.Collections.Generic;
using WebApi.Data;
using WebApi.Data.Entities;

namespace WebApi.Tests.Helpers
{
    public static class Utilities
    {
        #region snippet1
        public static void InitializeDbForTests(ApplicationDbContext db)
        {
            db.Artists.AddRange(GetSeedingArtists());
            db.SaveChanges();
        }
        
        public static List<Artists> GetSeedingArtists()
        {
            return new List<Artists>()
            {
                new Artists(){ ArtistId = 1, Name = "Foo" },
                new Artists(){ ArtistId = 2, Name = "Bar" }
            };
        }
        #endregion
    }
}