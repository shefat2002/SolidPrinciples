namespace SRP
{
    public class UserService
    {
        public UserService() { } //Q. Why do we create that empty constructor?

        ////SRP - Voilate 
        ////<---------------------------------------------->
        ///
        //public void UserRegistration(string name, string email)
        //{
        //    Console.WriteLine($"User {name} is successfully registered");

        //    Console.WriteLine($"Sending email to {email}");
        //}

        ////<----------------------------------------------->


        // SRP
        private readonly EmailService _emailService = new();
        public UserService(EmailService emailService)
        {
            _emailService = emailService;
        } 
        public void UserRegistration(string name, string email)
        {
            Console.WriteLine($"User {name} is successfully registered");

            _emailService.SendEmail(email);
        }

    }
}
