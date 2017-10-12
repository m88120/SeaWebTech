using System.Web;
using System.Web.Optimization;

namespace CMS
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Content/assets/js").Include(
                        "~/Content/assets/global/plugins/jquery.min.js",
                        "~/Content/assets/global/plugins/jquery-migrate.min.js",
                        "~/Content/assets/global/plugins/bootstrContent/bootstrap.min.js",
                        "~/Content/assets/frontend/layout/scripts/back-to-top.js",
                        "~/Content/assets/global/plugins/fancybox/source/jquery.fancybox.pack.js",
                        "~/Content/assets/global/plugins/carousel-owl-carousel/owl-carousel/owl.carousel.min.js",
                        "~/Content/assets/frontend/layout/scripts/layout.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //            "~/Content/themes/base/jquery.ui.core.css",
            //            "~/Content/themes/base/jquery.ui.resizable.css",
            //            "~/Content/themes/base/jquery.ui.selectable.css",
            //            "~/Content/themes/base/jquery.ui.accordion.css",
            //            "~/Content/themes/base/jquery.ui.autocomplete.css",
            //            "~/Content/themes/base/jquery.ui.button.css",
            //            "~/Content/themes/base/jquery.ui.dialog.css",
            //            "~/Content/themes/base/jquery.ui.slider.css",
            //            "~/Content/themes/base/jquery.ui.tabs.css",
            //            "~/Content/themes/base/jquery.ui.datepicker.css",
            //            "~/Content/themes/base/jquery.ui.progressbar.css",
            //            "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/assets/global").Include(
                        "~/Content/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                        "~/Content/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                        "~/Content/assets/global/plugins/fancybox/source/jquery.fancybox.css",
                        "~/Content/assets/global/plugins/carousel-owl-carousel/owl-carousel/owl.carousel.css",
                        "~/Content/assets/global/plugins/slider-revolution-slider/rs-plugin/css/settings.css",
                        "~/Content/assets/global/css/components.css"
                        ));

            bundles.Add(new StyleBundle("~/Content/assets/frontend").Include(
                        "~/Content/assets/frontend/layout/css/style.css",
                        "~/Content/assets/frontend/pages/css/style-revolution-slider.css",
                        "~/Content/assets/frontend/layout/css/style-responsive.css",
                        "~/Content/assets/frontend/layout/css/themes/blue.css",
                        "~/Content/assets/frontend/layout/css/custom.css"
                        ));

        }
    }
}