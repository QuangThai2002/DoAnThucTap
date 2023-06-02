using System.ComponentModel.DataAnnotations;

namespace DoAnThucTap.Models
{
    public class Daughihinh
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên Đầu ghi là bắt buộc.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nhãn hiệu là bắt buộc.")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Độ phân giải là bắt buộc.")]
        public string Resolution { get; set; }

        [Required(ErrorMessage = "Giá bán là bắt buộc.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Số lượng là bắt buộc.")]
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
