using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace APP.Pages.Categories
{
    public class ShareViaEmail : PageModel
    {
        private readonly ILogger<ShareViaEmail> _logger;
        private readonly IEmailSender _emailSender;

        public ShareViaEmail(ILogger<ShareViaEmail> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public void OnGet()
        {
            _emailSender.SendEmailAsync("pcsureja.dev@gmail.com", "test .net 6 email", "testing");
        }
    }
}
