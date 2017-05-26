using Net.Chdk.Model.CameraModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Net.Chdk.Validators.CameraModel
{
    sealed class CameraModelValidator : IValidator<CameraModelInfo>
    {
        public void Validate(CameraModelInfo cameraModel, string basePath)
        {
            if (cameraModel == null)
                throw new ArgumentNullException(nameof(cameraModel));

#if METADATA
            Validate(cameraModel.Version);
#endif
            Validate(cameraModel.Names);
        }

#if METADATA
        private static void Validate(Version version)
        {
            if (version == null)
                throw new ValidationException("Null version");

            if (version.Major < 1 || version.Minor < 0)
                throw new ValidationException("Invalid version");
        }
#endif

        private static void Validate(string[] names)
        {
            if (names == null)
                throw new ValidationException("Null names");

            if (names.Length == 0)
                throw new ValidationException("Empty names");

            if (names.Any(string.IsNullOrEmpty))
                throw new ValidationException("Missing name");
        }
    }
}
