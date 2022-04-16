namespace WeatherApp.Models
{
    public class User
    {
        private int Id { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        
        }

    }
}
