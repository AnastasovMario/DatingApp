using System.Security.Cryptography;
using System.Text;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController(DataContext context) : BaseApiController
{

    [HttpPost("register")] // account/register 
    public async Task<ActionResult<AppUser>> Register(string username, string password)
    {
        using var hmac = new HMACSHA512(); // Once the class is out of scope, it will call the .Dispose()

        var user = new AppUser()
        {
            UserName = username,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)), // Hash the password
            PasswordSalt = hmac.Key // salt our password
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        return user;
    }
}
