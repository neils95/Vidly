
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
		
		[Required]
        public string Name { get; set; }
		
		[Required]
		public DateTime? ReleaseDate { get; set; }

		[Required]
		public DateTime? DateAdded { get; set; }

		[Required]
		public byte NumberInStock  { get; set; }

		//Foreign key
	
		[Required]
		public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}