namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            // There are 3 execution paths (scenarios) Admin, same user made reservation and someone else trying.
            return (user.IsAdmin || MadeBy == user); 
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}