namespace DataAccess
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EmployeeDTO
    {
        [Required(ErrorMessage = "Çalışan adı boş bırakılamaz.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen bir tarih seçiniz.")]
        public DateTime HireDate { get; set; } = DateTime.Now;

        public string ContactInfo { get; set; } = string.Empty;
    }
}