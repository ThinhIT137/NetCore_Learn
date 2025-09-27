using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int Id { get; set; } // Mã sinh viên

    [Required(ErrorMessage = "Họ tên bắt buộc phải nhập")]
    [RegularExpression(@"^[\p{L}\s]{4,100}$", ErrorMessage = "Tên tối đa 4 ký tự tối thiểu 100")]
    public string Name { get; set; } // Họ tên

    [Required(ErrorMessage = "Email bắt buộc phải nhập")]
    [RegularExpression(@"[A-Za-z0-9._%+-]+@[Gg][Mm][Aa][Ii][Ll].[Cc][Oo][Mm]",
        ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; } // Email

    [Required(ErrorMessage = "Mật khẩu bắt buộc phải nhập")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9]).{8,}$", ErrorMessage = "Mật khẩu gồm chữ thường chữ hoa số và kí tự đặc biệt tối thiểu là 8 ký tự")]
    //[StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu tối thiểu 8 ký tự")]
    public string Password { get; set; } // Mật khẩu

    [Required(ErrorMessage = "Ngành học bắt buộc phải chọn")]
    public string? Branch { get; set; } // Ngành học (enum)

    [Required(ErrorMessage = "Giới tính bắt buộc phải chọn")]
    public Gender? Gender { get; set; } // Giới tính (enum)

    public bool IsRegular { get; set; } // Hệ: true = chính quy, false = phi chính quy

    [Required(ErrorMessage = "Địa chỉ bắt buộc phải nhập")]
    [DataType(DataType.MultilineText)]
    public string Address { get; set; } // Địa chỉ

    [Required(ErrorMessage = "Ngày sinh bắt buộc phải nhập")]
    [Range(typeof(DateTime), "1/1/1963", "12/31/2005",
        ErrorMessage = "Ngày sinh phải từ 01/01/1963 đến 31/12/2005")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; } // Ngày sinh
    [Required(ErrorMessage = "Điểm bắt buộc phải nhập")]
    [RegularExpression(@"^[0-9](./[0-9])?$")]
    [Range(0, 10, ErrorMessage = "Điểm phải từ 0 đến 10")]
    public float? Diem { get; set; } // Điểm
}

public enum Branch
{

}

public enum Gender
{
    Nam,
    Nu
}
