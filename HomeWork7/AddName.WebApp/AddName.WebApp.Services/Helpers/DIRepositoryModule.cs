using AddName.WebApp.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using AddName.WebApp.DomainModels.Models;
using AddName.WebApp.DataAccess.Repositories.CashRepositories;

namespace AddName.WebApp.Services.Helpers
{
    public static class DIRepositoryModule
    {

        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            //StaticDBRepositories
            services.AddTransient<IRepositories<Name>,NameRepository>();
            services.AddTransient<IRepositories<Feedback>,FeedbackRepository>();

            //EntetyRepositories dependencies





            return services;

        }

    }
}
