using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nlayer.Core.DTOs;
using System.Security.Cryptography.X509Certificates;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };

            

        }
    }
}