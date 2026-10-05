namespace STB_backend.DTOs
{
    public class UserCreateDTO
    {
        /*
        private int userId;
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private int creditBalance;
        private enum UserType { ADMIN, USER}
        private enum PartnerTier { NONE, SILVER, GOLD, PLATINUM }
        private decimal discountRate;
        private DateOnly createdAt;
        private DateOnly updatedAt;
        private bool IsDeleted;
        private DateOnly deletedAt;
        */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
