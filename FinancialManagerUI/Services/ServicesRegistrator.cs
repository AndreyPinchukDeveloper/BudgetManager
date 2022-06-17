using FinancialManagerUI.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialManagerUI.Services
{
    /// <summary>
    /// This registrator is register services in container
    /// </summary>
    static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()//register MainWindowViewModel
        ;//we put it here intentionally, that way give us pretty comftarble terms to add new mothods
    }
}
