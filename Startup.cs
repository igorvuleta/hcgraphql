using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate.AspNetCore;
using HotChocolate;
using hcgraphqlnew.Models;
using hcgraphqlnew.Types;
using hcgraphqlnew.Repository.ProductsRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using HotChocolate.AspNetCore.Voyager;
using hcgraphqlnew.Repository.CategoriesRepository;
using hcgraphqlnew.Repository.CustomersRepository;
using hcgraphqlnew.Repository.OrdersRepository;
using hcgraphqlnew.Repository.OrderDetailsRepository;
using hcgraphqlnew.Repository.SuppliersRepository;
using hcgraphqlnew.Repository.ShippersRepository;
using hcgraphqlnew.Repository.EmployeesRepository;
using hcgraphqlnew.Repository.TerritoriesRepository;
using hcgraphqlnew.Repository.RegionRepository;
using hcgraphqlnew.Repository.EmployeeTerritoriesRepository;
using hcgraphqlnew.Repository.CustomerDemographicsRepository;
using hcgraphqlnew.Repository.CustomerCustomerDemoRepository;

namespace hcgraphqlnew
{
    public class Startup
    {
      // This method gets called by the runtime. Use this method to add services to the container.
      // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
      public Startup(IConfiguration configuration)
      {
         Configuration = configuration;
      }

      public IConfiguration Configuration { get; }
      public void ConfigureServices(IServiceCollection services)
        {
         // If you need dependency injection with your query object add your query type as a services.
          //services.AddSingleton<Query>();

         services.AddTransient<IProductsRepository, ProductsRepository>();
         services.AddTransient<ICategoriesRepository, CategoriesRepository>();
         services.AddTransient<ICustomersRepository, CustomersRepository>();
         services.AddTransient<IOrdersRepository, OrdersRepository>();
         services.AddTransient<IOrderDetailsRepository, OrderDetailsRepository>();
         services.AddTransient<ISuppliersRepository, SuppliersRepository>();
         services.AddTransient<IShippersRepository, ShippersRepository>();
         services.AddTransient<IEmployeesRepository, EmployeesRepository>();
         services.AddTransient<ITerritoriesRepository, TerritoriesRepository>();
         services.AddTransient<IRegionRepository, RegionRepository>();
         services.AddTransient<IEmployeeTerritoriesRepository, EmployeeTerritoriesRepository>();
         services.AddTransient<ICustomerDemographicsRepository, CustomerDemographicsRepository>();
         services.AddTransient<ICustomerCustomerDemoRepository, CustomerCustomerDemoRepository>();
         services.AddDbContext<northwindContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("NorthWind"))); ;
            // enable InMemory messaging services for subscription support.
            // services.AddInMemorySubscriptionProvider();

            // this enables you to use DataLoader in your resolvers.
            services.AddDataLoaderRegistry();

         // Add GraphQL Services
         services.AddGraphQL(sp => SchemaBuilder.New()
             // enable for authorization support
             // .AddDirectiveType<AuthorizeDirectiveType>()
             .AddQueryType<QueryType>()
             .AddServices(sp)
             .Create());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app

             .UseWebSockets()
             .UseGraphQL()
             .UseVoyager()
             .UsePlayground();
      }
    }
}
