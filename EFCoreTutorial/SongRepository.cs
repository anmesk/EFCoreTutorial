using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFCoreTutorial
{
    public class SongRepository
    {
        private MusicContext db;

        public SongRepository(MusicContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Songs.Count();
        }
    }
}
