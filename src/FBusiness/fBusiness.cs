using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FBusiness.Models;
using System.Net;

namespace FBusiness
{
    public class fBusiness
    {
        private readonly ILogger<fBusiness> _logger;

        public fBusiness(ILogger<fBusiness> logger)
        {
            _logger = logger;
        }

        [Function("fBusiness")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            var user = new User(1, "Walter", "walter@emeal.com", ["standard", "premium"]);

            _logger.LogInformation("C# HTTP trigger Template Function Fbusiness processed a request.");
            return new ObjectResult( user ){

            };
        }
    }
}
