using System.Security.Claims;
using System.Threading.Tasks;
using InventoryWebApplication.Models.Database;
using InventoryWebApplication.Operations;
using InventoryWebApplication.Services.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApplication.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UsersService _usersService;

        public AuthenticationController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("auth")]
        public async Task<IActionResult> Authenticate([FromForm] string name, [FromForm] string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                return RedirectToFailedLogin();

            User user = await _usersService.GetByNameAndPassword(name, password);
            if (user is null) return RedirectToFailedLogin();

            ClaimsIdentity claimsIdentity = new(new Claim[]
            {
                new(ClaimTypes.Name, user.Name),
                new(ClaimTypes.Role, user.Role)
            }, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal claimsPrincipal = new(new[] { claimsIdentity });
            await HttpContext.SignInAsync(claimsPrincipal);

            return RedirectToAction("Index", "Home");
        }

        private IActionResult RedirectToFailedLogin()
        {
            return View("Login", new MessageOperation("Wrong username or password"));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("login")]
        public IActionResult Login()
        {
            return View(MessageOperation.Empty);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("register")]
        public IActionResult Register()
        {
            return View(MessageOperation.Empty);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IActionResult> Register([FromForm] string name, [FromForm] string password, [FromForm] string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                return View("Register", new MessageOperation("Please fill in all fields"));

            if (password != confirmPassword)
                return View("Register", new MessageOperation("Passwords do not match"));

            if (!UsersService.IsPasswordValid(password))
                return View("Register", new MessageOperation("Password must have at least 4 characters"));

            // Kiểm tra username trùng
            var existingUser = await _usersService.GetByName(name);
            if (existingUser != null)
                return View("Register", new MessageOperation("Username already exists"));

            var newUser = new User
            {
                Name = name,
                Password = password,
                Role = "User"
            };

            await _usersService.Create(newUser);

            return RedirectToAction("Login", "Authentication");
        }

        [HttpGet]
        [Authorize]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Authentication");
        }
    }
}
