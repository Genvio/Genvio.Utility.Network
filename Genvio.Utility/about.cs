//NuGet path: dotnet pack --output ../nupkgs /p:NuspecFile=../Genvio.Utility.1.10.0.nuspec

using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Genvio.Utility
{
    public sealed class About
    {
        private static StringBuilder stringBuilder = new StringBuilder();
        private static Assembly thisAssembly = Assembly.GetEntryAssembly();

        public static string Version
        {
            get
            {
                stringBuilder.AppendFormat($"Genvio.Utility Assembly Version: {thisAssembly.GetName().Version.ToString()}\n");
                stringBuilder.AppendFormat($"Genvio.Utility File Version: {thisAssembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version}\n");
                stringBuilder.AppendFormat($"Genvio.Utility Assembly Informational Version: {thisAssembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}\n");

                return stringBuilder.ToString();
            }
        }

        public static string License
        {
            get
            {
                var resourceStream = thisAssembly.GetManifestResourceStream("Genvio.Utility.resources.license.txt");
                using (var reader = new StreamReader(resourceStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static string Info
        {
            get
            {
                var resourceStream = thisAssembly.GetManifestResourceStream("Genvio.Utility.resources.readme.txt");
                using (var reader = new StreamReader(resourceStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }

}