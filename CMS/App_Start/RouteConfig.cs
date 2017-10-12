using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
              
            routes.MapRoute(
              name: "About", // any name meaningful for you is right
              url: "AboutUs",
               defaults: new { controller = "Home", action = "About" }
                 );
            routes.MapRoute(
             name: "Search", // any name meaningful for you is right
             url: "Search",
              defaults: new { controller = "Home", action = "Search", SearchText = UrlParameter.Optional }
                );

            routes.MapRoute(
              name: "404", // any name meaningful for you is right
              url: "404",
               defaults: new { controller = "Home", action = "pagenotfound" }
                 );

            routes.MapRoute(
            name: "Contacts", // any name meaningful for you is right
            url: "ContactUs",
             defaults: new { controller = "Home", action = "Contact" }
               );
            routes.MapRoute(
            name: "RequestAQuote", // any name meaningful for you is right
            url: "Request-A-Quote",
             defaults: new { controller = "Home", action = "RequestAQuote" }
               );

            routes.MapRoute(
              name: "Portfolio", // any name meaningful for you is right
              url: "Portfolio",
               defaults: new { controller = "Home", action = "Portfolio" }
                 );
            //***************************MobileAppDevelopment
            #region  //info/Services
            //info/Services
            routes.MapRoute(
                       name: "Services", // any name meaningful for you is right
                       url: "info",
                        defaults: new { controller = "Home", action = "Services", id = "MobileAppDevelopment" }
                      );

                routes.MapRoute(
                     name: "MobileAppDevelopment", // any name meaningful for you is right
                     url: "mobile-app-development",
                      defaults: new { controller = "Home", action = "Services", id = "MobileAppDevelopment" }
                    );
                routes.MapRoute(
                        name: "MobileAppDevelopmentIPhone", // any name meaningful for you is right
                        url: "iPhone-App-Development",
                         defaults: new { controller = "Home", action = "Services", id = "iPhoneAppDevelopment" }
                       );
             routes.MapRoute(
                        name: "Android", // any name meaningful for you is right
                        url: "Android-App-Development",
                         defaults: new { controller = "Home", action = "Services", id = "AndroidAppDevelopment" }
                       );
            
                routes.MapRoute(
                           name: "WindowApp", // any name meaningful for you is right
                           url: "Windows-Phone-App",
                            defaults: new { controller = "Home", action = "Services", id = "WindowAppDevelopment" }
                          );
               routes.MapRoute(
                           name: "hybridApp", // any name meaningful for you is right
                           url: "Hybrid-Apps-Development",
                            defaults: new { controller = "Home", action = "Services", id = "HybridAppDevelopment" }
                          );
              routes.MapRoute(
                           name: "dotnet", // any name meaningful for you is right
                           url: "Dot-Net-Development",
                            defaults: new { controller = "Home", action = "Services", id = "DotNetDevelopment" }
                          );
              routes.MapRoute(
                            name: "php", // any name meaningful for you is right
                            url: "PHP-Web-Development",
                             defaults: new { controller = "Home", action = "Services", id = "PHPWebDevelopment" }
                           );
              routes.MapRoute(
                              name: "cms", // any name meaningful for you is right
                              url: "CMS-Web-Development",
                               defaults: new { controller = "Home", action = "Services", id = "CMSWebDevelopment" }
                             );
              routes.MapRoute(
                             name: "spa", // any name meaningful for you is right
                             url: "Single-Page-Applications",
                              defaults: new { controller = "Home", action = "Services", id = "SinglePageWebDevelopment" }
                            );
            routes.MapRoute(
                             name: "Responsive", // any name meaningful for you is right
                             url: "Responsive-Web-Designing",
                              defaults: new { controller = "Home", action = "Services", id = "ResponsiveWebDesigning" }
                            );
            routes.MapRoute(
                            name: "MobileAppDesigning", // any name meaningful for you is right
                            url: "Mobile-App-Designing",
                             defaults: new { controller = "Home", action = "Services", id = "MobileAppDesigning" }
                           );
             routes.MapRoute(
                            name: "BannerAndLogoDesigning", // any name meaningful for you is right
                            url: "Banner-And-Logo-Designing",
                             defaults: new { controller = "Home", action = "Services", id = "BannerAndLogoDesigning" }
                           );
               routes.MapRoute(
                            name: "LandingPageDesigning", // any name meaningful for you is right
                            url: "Landing-Page-Designing",
                             defaults: new { controller = "Home", action = "Services", id = "LandingPageDesigning" }
                           );
            routes.MapRoute(
                            name: "SEO", // any name meaningful for you is right
                            url: "Search-Engine-Optimization",
                             defaults: new { controller = "Home", action = "Services", id = "SearchEngineOptimization" }
                           );
               routes.MapRoute(
                            name: "SocialMediaOptimization", // any name meaningful for you is right
                            url: "Social-Media-Optimization",
                             defaults: new { controller = "Home", action = "Services", id = "SocialMediaOptimization" }
                           );
               routes.MapRoute(
                           name: "PPC", // any name meaningful for you is right
                           url: "Pay-Per-Click",
                            defaults: new { controller = "Home", action = "Services", id = "PPC" }
                          );
            #endregion

            #region Plugins
            routes.MapRoute(
            name: "Plugins", // any name meaningful for you is right
            url: "Plugins",
             defaults: new { controller = "Plugins", action = "Plugins" }
               );
            routes.MapRoute(
           name: "keywordcount", // any name meaningful for you is right
           url: "count-keyword-and-description",
            defaults: new { controller = "Plugins", action = "keywordcount" }
              );
            #endregion
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}