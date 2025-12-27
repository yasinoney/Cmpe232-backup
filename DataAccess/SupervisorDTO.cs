namespace DataAccess
{
    using System.ComponentModel.DataAnnotations;

    public class SupervisorDTO
    {
        [Required(ErrorMessage = "Lütfen bir personel seçiniz.")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;
    }
}