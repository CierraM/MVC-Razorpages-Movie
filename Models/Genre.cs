using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
    

    }
}