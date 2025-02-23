using System;
using System.IO;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Controller.Configuration;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.SSOAuth
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string ProviderUrl { get; set; } = "https://authentik.mondomaine.com";
        public string ClientId { get; set; } = "jellyfin";
        public string ClientSecret { get; set; } = "client-secret";

        public static PluginConfiguration Load(IApplicationPaths paths, IXmlSerializer serializer)
        {
            var configPath = Path.Combine(paths.ConfigPath, "plugin-ssoauth.xml");
            if (File.Exists(configPath))
            {
                using (var stream = File.OpenRead(configPath))
                {
                    return serializer.DeserializeFromStream<PluginConfiguration>(stream);
                }
            }
            return new PluginConfiguration();
        }

        public void Save(IApplicationPaths paths, IXmlSerializer serializer)
        {
            var configPath = Path.Combine(paths.ConfigPath, "plugin-ssoauth.xml");
            using (var stream = File.Create(configPath))
            {
                serializer.SerializeToStream(this, stream);
            }
        }
    }
}
