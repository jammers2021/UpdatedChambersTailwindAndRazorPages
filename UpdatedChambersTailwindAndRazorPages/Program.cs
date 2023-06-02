//using UpdatedChambersTailwindAndRazorPages.ClassLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services;

namespace UpdatedChambersTailwindAndRazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IStatsGenerationMethod, StatsGenerationMethod>();
            builder.Services.AddScoped<ICharacterFactory, CharacterFactory>();
            builder.Services.AddScoped<IChosenClassSelection, ChosenClassSelection>();
            builder.Services.AddScoped<IArmorClassCalculations, ArmorClassCalculations>();
            builder.Services.AddScoped<IModifiers, Modifiers>();
            builder.Services.AddScoped<IHitPointCalculation, HitPointCalculation>();
            builder.Services.AddScoped<ISpeciesSelection, SpeciesSelection>();
			builder.Services.AddHttpClient("DiscGolfAPI", client =>
			client.BaseAddress = new Uri(builder.Configuration["Urls:DiscGolf"])
			);
			
			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}