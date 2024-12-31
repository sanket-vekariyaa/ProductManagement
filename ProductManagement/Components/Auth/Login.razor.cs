using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using ProductManagemnt.Model;

namespace ProductManagement.Components.Auth
{
    public partial class Login : ComponentBase
    {
        private AuthModel loginModel = new AuthModel();
        private bool loginFailed = false;

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private void HandleLogin()
        {
            // Replace this with actual login logic 
            if (loginModel.Username == "admin" && loginModel.Password == "password") // Example credentials
            {
                // Login successful - Redirect to another page (e.g., Home or Dashboard)
                NavigationManager.NavigateTo("/dashboard"); // Replace with your desired URL
            }
            else
            {
                // Login failed - Show error message
                loginFailed = true;
            }
        }
    }
}
