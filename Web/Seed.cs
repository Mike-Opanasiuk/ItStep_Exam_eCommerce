using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Shared;

namespace Web;

public static partial class WebApplicationExtensions
{
    public static void UseSeed(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var roleManager = scope.ServiceProvider.GetService<RoleManager<RoleEntity>>();

            Seed(roleManager!).Wait();
        }
    }

    private static async Task Seed(RoleManager<RoleEntity> roleManager)
    {
        await SeedCustomerRole(roleManager);
    }

    private static async Task SeedCustomerRole(RoleManager<RoleEntity> roleManager)
    {
        var customerRoleName = AppSettings.Roles.Customer; 
        
        var customerRole = new RoleEntity(customerRoleName);

        var customerRoleIsNotExists = !await roleManager.RoleExistsAsync(customerRoleName);
        
        if (customerRoleIsNotExists)
        {
            await roleManager.CreateAsync(customerRole);
        }
    }
}