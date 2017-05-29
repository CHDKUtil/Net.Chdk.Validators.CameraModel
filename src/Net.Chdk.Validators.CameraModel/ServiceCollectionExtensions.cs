using Microsoft.Extensions.DependencyInjection;
using Net.Chdk.Model.CameraModel;
using System;

namespace Net.Chdk.Validators.CameraModel
{
    public static class ServiceCollectionExtensions
    {
        [Obsolete]
        public static IServiceCollection AddCameraModelValidator(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddSingleton<IValidator<CameraModelInfo>, CameraModelValidator>();
        }
    }
}
