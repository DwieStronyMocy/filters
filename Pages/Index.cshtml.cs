using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace filters.Pages
{
    public class IndexModel : PageModel
    {
        public System.Net.IPAddress ip { get; set; }
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
        public int testVriable { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public override Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            int a = 0;
            ip = HttpContext.Request.HttpContext.Connection.RemoteIpAddress;
            return Task.CompletedTask;

        }
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext pageContext)
        {
            int a = 1;
        }
        public override void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 2;
        }
        public void OnGet()
        {
            int a = 3;
        }
    }
}
