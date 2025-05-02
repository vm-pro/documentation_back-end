namespace Documentation_back_end.Domain
{
    enum UserRole
    {
        Admin,
        Operator,
        Developper,
        External
    }
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Matricule { get; set; }
        public string Role { get; set; } // Admin, User, etc.

        // Navigation properties
        public ICollection<Script>? Scripts { get; set; }
        
    }
}
