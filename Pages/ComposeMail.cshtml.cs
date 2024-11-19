using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ComposeMailModel : PageModel
{
    private readonly EmailService _emailService;

    public ComposeMailModel(EmailService emailService)
    {
        _emailService = emailService;
    }

    [BindProperty]
    public string Recipient { get; set; }
    [BindProperty]
    public string Subject { get; set; }
    [BindProperty]
    public string Body { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            try
            {
                // ใช้ EmailService เพื่อส่งอีเมล
                await _emailService.SendEmailAsync("celesetailsoftwere@gmail.com", Recipient, Subject, Body);
                TempData["SuccessMessage"] = "Email sent successfully!";
                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Failed to send email: {ex.Message}");
            }
        }

        return Page();
    }
}