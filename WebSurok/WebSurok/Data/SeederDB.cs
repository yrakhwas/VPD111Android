using Microsoft.EntityFrameworkCore;
using WebSurok.Data.Entities;

namespace WebSurok.Data
{
    public static class SeederDB
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MyAppContext>();
                context.Database.Migrate();

                if (!context.Categories.Any())
                {
                    var kovbasy = new CategoryEntity
                    {
                        Name = "Ковбаси",
                        Description = "Хороші і довго ковбаси"
                    };
                    var vsutiy = new CategoryEntity
                    {
                        Name = "Взуття",
                        Description = "Гарне взуття із гарнатуєю 5 років." +
                        "Можна нирять під воду."
                    };
                    context.Categories.Add(kovbasy);
                    context.Categories.Add(vsutiy);
                    context.SaveChanges();
                }
            }
        }
    }
}
