using System.Web;
using System.Web.Optimization;

namespace BLWeb
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/layout/css").Include(
                     "~/css/fonts.css",
                     "~/css/plugins.css",
                     "~/css/bootstrap-touch-slider.css",
                     "~/css/mainstyle.css",
                     "~/css/responsive.css"));

            bundles.Add(new StyleBundle("~/Htimeline/css").Include(
                     "~/css/Htimeline.css"));

            bundles.Add(new StyleBundle("~/Vtimeline/css").Include(
                     "~/css/style.css"));


            bundles.Add(new ScriptBundle("~/layout/modernizr").Include(
                    "~/javascripts/vendor/modernizr.min.js"));

            bundles.Add(new ScriptBundle("~/layout/js").Include(
                      "~/javascripts/vendor/jquery-1.11.2.min.js",
                      "~/javascripts/vendor/bootstrap.js",
                      "~/javascripts/jquery.magnific-popup.js",
                      "~/javascripts/jquery.easing.1.3.js",
                      "~/javascripts/jquery.touchSwipe.min.js",
                      "~/javascripts/bootsnav.js",
                      "~/javascripts/jquery.formchimp.js",
                      "~/javascripts/plugins.js",
                      "~/javascripts/main.js"));


            bundles.Add(new ScriptBundle("~/time/js").Include(
                 "~/js/main.js"));

            bundles.Add(new ScriptBundle("~/timeline/js").Include(
                 "~/js/modernizr.js"));
            bundles.Add(new ScriptBundle("~/jq/js").Include(
                 "~/js/jquery.1.11.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                 "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                 "~/Scripts/jquery.validate*"));
        }
    }
}
