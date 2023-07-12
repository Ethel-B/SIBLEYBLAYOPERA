namespace SIBLEYBLAYOPERA.Models
{
    public class UsersDTO
    {
        public required string FirstName { get; set; } = string.Empty;

        public required string MiddleName { get; set; } = string.Empty;

        public required string LastName { get; set; } = string.Empty;

        public required string Gender { get; set; } = string.Empty;

        public required string UserName { get; set; } = string.Empty;

        public  required string Password { get; set; } = string.Empty;
    }
}
