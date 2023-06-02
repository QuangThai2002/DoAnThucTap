using System.ComponentModel.DataAnnotations;

namespace DoAnThucTap.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }
    }

}
