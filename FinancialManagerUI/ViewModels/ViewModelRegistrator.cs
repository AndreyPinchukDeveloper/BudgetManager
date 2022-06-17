using Microsoft.Extensions.DependencyInjection;

namespace FinancialManagerUI.ViewModels
{
    /// <summary>
    /// This registrator is register view models in container
    /// </summary>
    static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
        ;//we put it here intentionally, that way give us pretty comftarble terms to add new mothods
    }
}
