using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Jellyfin.Plugin.SSOAuth;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using MediaBrowser.Controller.Configuration;
using MediaBrowser.Controller.Net;
using MediaBrowser.Model.Configuration;
using MediaBrowser.Model.Services;

namespace Jellyfin.Plugin.SSOAuth
{
    public class Plugin : BasePlugin, IHasWebPages
    {
        public override string Name => "SSO Auth Plugin";
        public override string Description => "Authentification via OpenID Connect";

        private static PluginConfiguration _config;

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
            _config = PluginConfiguration.Load(applicationPaths, xmlSerializer);
        }

        public static Plugin Instance { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = OpenIdConnectDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddOpenIdConnect(options =>
            {
                options.Authority = _config.ProviderUrl;
                options.ClientId = _config.ClientId;
                options.ClientSecret = _config.ClientSecret;
                options.ResponseType = "code";
                options.SaveTokens = true;
                options.GetClaimsFromUserInfoEndpoint = true;
                options.Scope.Add("openid");
                options.Scope.Add("profile");
                options.Scope.Add("email");
            });
        }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new List<PluginPageInfo>
            {
                new PluginPageInfo
                {
                    Name = "SSOAuthSettings",
                    EmbeddedResourcePath = GetType().Namespace + ".Web.SSOAuthSettings.html"
                }
            };
        }
    }
}
