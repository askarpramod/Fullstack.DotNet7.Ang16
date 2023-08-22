﻿namespace CodeP.DotNet7.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Content { get; set; }
        public string FeaturedImgUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Auther { get; set; }
        public bool IsVisible { get; set; }
    }
}