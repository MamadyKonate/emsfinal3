using emsfinal3.Models;

namespace emsfinal3.ViewModels
{
    public class CurrentUser
    {
        public User GetLoggedInUser { get; set; } = new();
        public bool IsLoggedIn()
        {
            return GetLoggedInUser.IsUserLoggedIn;
                
        }
    }
}
