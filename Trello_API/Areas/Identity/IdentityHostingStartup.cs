using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Trello_API.Areas.Identity.Data;
using Trello_API.Data;

[assembly: HostingStartup(typeof(Trello_API.Areas.Identity.IdentityHostingStartup))]
namespace Trello_API.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TrelloDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TrelloDbContext>();
            });
        }
    }
}