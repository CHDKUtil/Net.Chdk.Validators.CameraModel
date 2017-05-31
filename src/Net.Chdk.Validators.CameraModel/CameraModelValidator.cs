using Net.Chdk.Model.CameraModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;

namespace Net.Chdk.Validators.CameraModel
{
    [Obsolete]
    sealed class CameraModelValidator : Validator<CameraModelInfo>
    {
        protected override void DoValidate(CameraModelInfo cameraModel, string basePath, IProgress<double> progress, CancellationToken token)
        {
#if METADATA
            Validate(cameraModel.Version);
#endif
            Validate(cameraModel.Names);
        }

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
