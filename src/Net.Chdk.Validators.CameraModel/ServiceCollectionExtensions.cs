using Microsoft.Extensions.DependencyInjection;
using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Validators.CameraModel
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCameraModelValidator(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddSingleton<IValidator<CameraModelInfo>, CameraModelValidator>();
        }
    }
}
