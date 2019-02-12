using System;
using Liftoff.Areas.Identity.Data;
using Liftoff.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Liftoff.Areas.Identity.IdentityHostingStartup))]
namespace Liftoff.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LiftoffContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LiftoffContextConnection")));

                services.AddDefaultIdentity<LiftoffUser>()
                    .AddEntityFrameworkStores<LiftoffContext>();
            });
        }
    }
}