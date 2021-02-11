using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusic.Models
{
    public class MusicGenreViewModel
    {
        public List<Music> Music { get; set; }
        public SelectList Genres { get; set; }
        public string MusicGenre { get; set; }
        public string SearchString { get; set; }
    }
}
