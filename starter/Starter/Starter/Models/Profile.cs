namespace Starter.Models
{
    public class Profile
    {
        public string Type => "Profile";
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Id { get; set; }
    }
}