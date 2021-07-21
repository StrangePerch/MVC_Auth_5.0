using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVC_Auth_5._0.Resourses;

namespace MVC_Auth_5._0.Models
{
    public class Book
    {
        [Required]
        public Guid Id { get; set; }
        [Required, MinLength(2, ErrorMessageResourceName = "TitleLengthError", ErrorMessageResourceType = typeof(Resource)), MaxLength(100)]
        [Display(Name = "Books Title", ShortName = "Title", Order = 0)]
        public string Title { get; set; }
        [Display(Name = "Books Description", ShortName = "Description", Order = 1)]
        public string Description { get; set; }
        public HashSet<string> Codes { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime DatePublished { get; set; }
        
        [DataType(DataType.ImageUrl)]
        public Uri CoverImageUrl { get; set; }

        public HashSet<Author> Authors { get; set; }
    }

    public class Author
    {
        public Guid Id { get; set; }
        [Required, MinLength(2)]
        public string Name { get; set; }    
        
        [EmailAddress]
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public HashSet<Book> Books { get; set; }
    }

}