using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2020.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly2020.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }

        public GenreDto Genre { get; set; }
    }
}