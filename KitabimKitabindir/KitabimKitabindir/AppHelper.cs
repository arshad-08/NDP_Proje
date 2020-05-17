using System.Configuration;

namespace KitabimKitabindir
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager
            .ConnectionStrings["KitabimKitabindir.Properties.Settings.DatabaseKitapConnectionString"]
            .ConnectionString;
    }
}
