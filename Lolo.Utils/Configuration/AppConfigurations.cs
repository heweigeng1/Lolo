using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Lolo.Utils.Configuration
{
    public static class AppConfigurations
    {
        private static readonly ConcurrentDictionary<string, IConfigurationRoot> _configurationCache;

        static AppConfigurations()
        {
            _configurationCache = new ConcurrentDictionary<string, IConfigurationRoot>();
        }

        public static IConfigurationRoot Get(string path, string environmentName = null, bool addUserSecrets = false)
        {
            var cacheKey = path + "#" + environmentName + "#" + addUserSecrets;
            return _configurationCache.GetOrAdd(
                cacheKey,
                _ => BuildConfiguration(path, environmentName, addUserSecrets)
            );
        }

        public static IConfigurationRoot Get(string path, string filename)
        {
            var cacheKey = path + "#" + filename + "#";
            return _configurationCache.GetOrAdd(
                cacheKey,
                _ => BuildConfiguration(path, filename)
            );
        }

        public static IConfigurationRoot Get(string path, string[] filenames)
        {
            var cacheKey = path + "#" + filenames.Length + "#";
            return _configurationCache.GetOrAdd(
                cacheKey,
                _ => BuildConfiguration(path, filenames)
            );
        }


        private static IConfigurationRoot BuildConfiguration(string path, string environmentName = null, bool addUserSecrets = false)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            if (!string.IsNullOrWhiteSpace(environmentName))
            {
                builder = builder.AddJsonFile($"appsettings.{environmentName}.json", optional: true);
            }

            builder = builder.AddEnvironmentVariables();

            if (addUserSecrets)
            {
                builder.AddUserSecrets(typeof(AppConfigurations).Assembly);
            }

            return builder.Build();
        }

        private static IConfigurationRoot BuildConfiguration(string path, string filename)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile(filename, optional: true, reloadOnChange: true);

            builder = builder.AddEnvironmentVariables();

            return builder.Build();
        }

        private static IConfigurationRoot BuildConfiguration(string path, string[] filenames)
        {
            var builder = new ConfigurationBuilder().SetBasePath(path);
            foreach (var item in filenames)
            {
                builder.AddJsonFile(item, optional: true, reloadOnChange: true);
                builder = builder.AddEnvironmentVariables();
            }
            return builder.Build();
        }
    }
}
