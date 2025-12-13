using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class AppConfig
    {
        private static readonly Lazy<AppConfig> _instance = new Lazy<AppConfig>(() => new AppConfig());

        public static AppConfig Instance => _instance.Value;

        public string EnvironmentName { get; private set; } = "Production";

        private AppConfig() { }

        public void SetEnvironment(string name)
        {
            EnvironmentName = name;
        }
    }
}
