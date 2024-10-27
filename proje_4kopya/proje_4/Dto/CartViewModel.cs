using proje_4.Models;

namespace proje_4.Dto
{
    public class CartViewModel
    {
        
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}

