using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorial.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
