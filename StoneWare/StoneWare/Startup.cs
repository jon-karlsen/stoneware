using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StoneWare.Data;
using StoneWare.Models;

namespace StoneWare
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<StoneWareContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("StoneWare")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            SeedDb(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

        private void SeedDb(IApplicationBuilder app)
        {
            // ReSharper disable once ConvertToUsingDeclaration
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<StoneWareContext>())
                {
                    PopulateOperatingSystem(context);

                    PopulateVersionNumber(context);

                    PopulateProduct(context);

                    PopulateStatus(context);

                    PopulateProductVersionOs(context);
                }
            }
        }

        private static void PopulateProductVersionOs(StoneWareContext context)
        {
            if (!context.ProductVersionOs.Any())
            {
                context.ProductVersionOs.AddRange(new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Linux
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Linux
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
                        OperatingSystemId = (int) OperatingSystemEnum.Linux
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneTwo,
                        OperatingSystemId = (int) OperatingSystemEnum.WindowsMobile
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneThree,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneThree,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneThree,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.DayTraderWannabe,
                        VersionNumberId = (int) VersionNumberEnum.OneThree,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.InvestmentOverlord,
                        VersionNumberId = (int) VersionNumberEnum.TwoOne,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Linux
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Linux
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.WindowsMobile
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.WorkoutPlanner,
                        VersionNumberId = (int) VersionNumberEnum.TwoZero,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneZero,
                        OperatingSystemId = (int) OperatingSystemEnum.WindowsMobile
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.MacOS
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Windows
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.Android
                    },
                    new ProductVersionOs
                    {
                        ProductId = (int) ProductEnum.SocialAnxietyPlanner,
                        VersionNumberId = (int) VersionNumberEnum.OneOne,
                        OperatingSystemId = (int) OperatingSystemEnum.iOS
                    }
                );

                context.Database.OpenConnection();
                
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.ProductVersionOs ON");
                
                context.SaveChanges();
                
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.ProductVersionOs OFF");
                
                context.Database.CloseConnection();
            }
        }

        private static void PopulateStatus(StoneWareContext context)
        {
            if (!context.Status.Any())
            {
                context.Status.AddRange(new Status
                    {
//                                Id = 1,
                        Name = "Open"
                    },
                    new Status
                    {
//                                Id = 2,
                        Name = "Resolved"
                    });

                context.SaveChanges();
            }
        }

        private static void PopulateProduct(StoneWareContext context)
        {
            if (!context.Product.Any())
            {
                context.Product.AddRange(new Product
                    {
//                                Id = (int) ProductEnum.DayTraderWannabe,
                        Name = "Day Trader Wannabe"
                    },
                    new Product
                    {
//                                Id = (int) ProductEnum.InvestmentOverlord,
                        Name = "Investment Overlord"
                    },
                    new Product
                    {
//                                Id = (int) ProductEnum.WorkoutPlanner,
                        Name = "Workout Planner"
                    },
                    new Product
                    {
//                                Id = (int) ProductEnum.SocialAnxietyPlanner,
                        Name = "Social Anxiety Planner"
                    });

                context.SaveChanges();
            }
        }

        private static void PopulateVersionNumber(StoneWareContext context)
        {
            if (!context.VersionNumber.Any())
            {
                context.VersionNumber.AddRange(new VersionNumber
                    {
//                                Id = (int) VersionNumberEnum.OneZero,
                        Description = "1.0"
                    },
                    new VersionNumber
                    {
//                                Id = (int) VersionNumberEnum.OneOne,
                        Description = "1.1"
                    },
                    new VersionNumber
                    {
//                                Id = (int) VersionNumberEnum.OneTwo,
                        Description = "1.2"
                    },
                    new VersionNumber
                    {
//                                Id = (int) VersionNumberEnum.OneThree,
                        Description = "1.3"
                    },
                    new VersionNumber
                    {
//                                Id = (int) VersionNumberEnum.TwoZero,
                        Description = "2.0"
                    },
                    new VersionNumber
                    {
//                                Id = (int) VersionNumberEnum.TwoOne,
                        Description = "2.1"
                    });

                context.SaveChanges();
            }
        }

        private static void PopulateOperatingSystem(StoneWareContext context)
        {
            if (!context.OperatingSystem.Any())
            {
                context.OperatingSystem.AddRange(
                    new OperatingSystem
                    {
//                                Id = (int) OperatingSystemEnum.Linux,
                        Name = "Linux"
                    },
                    new OperatingSystem
                    {
//                                Id = (int) OperatingSystemEnum.MacOS,
                        Name = "MacOS"
                    },
                    new OperatingSystem
                    {
//                                Id = (int) OperatingSystemEnum.Windows,
                        Name = "Windows"
                    },
                    new OperatingSystem
                    {
//                                Id = (int) OperatingSystemEnum.Android,
                        Name = "Android"
                    },
                    new OperatingSystem
                    {
//                                Id = (int) OperatingSystemEnum.iOS,
                        Name = "iOS"
                    },
                    new OperatingSystem
                    {
//                                Id = (int) OperatingSystemEnum.WindowsMobile,
                        Name = "Windows Mobile"
                    });

                context.SaveChanges();
            }
        }

        private enum OperatingSystemEnum
        {
            Linux = 1,
            MacOS = 2,
            Windows = 3,
            Android = 4,
            iOS = 5,
            WindowsMobile = 6
        }

        private enum VersionNumberEnum
        {
            OneZero = 1,
            OneOne = 2,
            OneTwo = 3,
            OneThree = 4,
            TwoZero = 5,
            TwoOne = 6
        }

        private enum ProductEnum
        {
            DayTraderWannabe = 1,
            InvestmentOverlord = 2,
            WorkoutPlanner = 3,
            SocialAnxietyPlanner = 4
        }
    }
}