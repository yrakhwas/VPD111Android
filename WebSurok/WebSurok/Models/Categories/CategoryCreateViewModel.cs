﻿namespace WebSurok.Models.Categories
{
    public class CategoryCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
