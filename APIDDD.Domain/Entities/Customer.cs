namespace APIDDD.Domain.Entities
{
    public class Customer : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationbDate { get; set; }
        public bool IsActive { get; set; }
    }
}
