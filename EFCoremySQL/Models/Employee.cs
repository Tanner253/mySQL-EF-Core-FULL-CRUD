namespace EFCoremySQL.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        [StringLength(maximumLength:100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [StringLength(maximumLength:100, MinimumLength = 2)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is Required")]
        [StringLength(maximumLength: 15, MinimumLength = 10)]
        public string Phone { get; set; }

        [StringLength(maximumLength: 100)]
        public string? Address { get; set; }

    }
}
