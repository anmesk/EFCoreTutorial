using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EFCoreTutorial.Tests
{
    public class SongRepositoryTests
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new MusicContext();
            var underTest = new SongRepository(db);

            var count = underTest.Count();

            Assert.Equal(0, count);
        }
    }
}
