using System;
using Microsoft.CodeAnalysis;

namespace proje_4.Models
{
	public class ProductCategory
	{
		
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; }
    
	}
}

