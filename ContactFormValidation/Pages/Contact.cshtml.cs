using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ContactFormValidation.Pages
{
    public class ContactModel : PageModel
    {
        // bind these properties with the form

        [BindProperty]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = "";

        [BindProperty]
        public string? Phone { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; } = "";

        public string successMessage = "";
        public string errorMessage = "";

        public void OnGet()
        {

        }


        public void OnPost()
        {
            // check if validation was successful or not
            if (!ModelState.IsValid)
            {
                errorMessage = "Data Validation Failed, Fill all required fields";
                //then exit the method
                return;
            }

            successMessage = "We have recieved your message successfully. We will get in touch with you shortly";
            // clear the form
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Subject = "";
            Message = "";

            //apply the new values
            ModelState.Clear();

            //go to the page and display the error or success message
        }
    }
}