using System.Web;
using System.Web.Optimization;

namespace baconlockeWeb
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/layout/css").Include(
                     "~/assets/css/fonts.css",
                     "~/assets/css/plugins.css",
                     "~/assets/css/bootstrap-touch-slider.css",
                     "~/assets/css/style.css",
                     "~/assets/css/responsive.css"));

            bundles.Add(new StyleBundle("~/demo/css").Include(
                     "~/assets/css/demo.css"));

            bundles.Add(new StyleBundle("~/time/css").Include(
                     "~/assets/css/timeline.css"));

            bundles.Add(new ScriptBundle("~/layout/js").Include(
                      "~/assets/js/vendor/jquery-1.11.2.min.js",
                      "~/assets/js/vendor/bootstrap.js",
                      "~/assets/js/jquery.magnific-popup.js",
                      "~/assets/js/jquery.easing.1.3.js",
                      "~/assets/js/jquery.touchSwipe.min.js",
                      "~/assets/js/bootsnav.js",
                      "~/assets/js/jquery.formchimp.js",
                      "~/assets/js/plugins.js",
                      "~/assets/js/main.js"));
            bundles.Add(new ScriptBundle("~/layout/modernizr").Include(
                 "~/assets/js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"));
        }
    }
}
