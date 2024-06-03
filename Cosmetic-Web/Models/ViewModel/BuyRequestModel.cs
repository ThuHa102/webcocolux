using System.ComponentModel.DataAnnotations;

namespace Cosmetic_Web.Models.ViewModel
{
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? ProductName { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
    }

    public class BuyRequestModel
    {
        public int CouponId { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public List<ProductInfo>? Products { get; set; } // Thay đổi kiểu dữ liệu của Products
    }
}
