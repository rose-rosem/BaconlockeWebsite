using System.Web;
using System.Web.Optimization;

namespace BaconlockeWebsite
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/layout/css").Include(
                    "~/Content/menuzord/menuzord.css",
                    "~/Content/Roboto.css",
                    "~/Content/Condensed.css",
                    "~/Content/Lato.css",
                    "~/Content/Montserrat.css",
                    "~/Content/Raleway.css",
                    "~/Content/bootstrap.min.css",
                    "~/Content/font-awesome.min.css",
                    "~/Content/flaticon.css",
                    "~/Content/owl.carousel.css",
                    "~/Content/owl.theme.css",
                    "~/Content/jPushMenu.css",
                    "~/Content/jquery.fancybox.css",
                    "~/Content/animate.min.css",
                    "~/Scripts/jquery-ui-1.11.4/jquery-ui.css",
                    "~/Content/style.css",
                    "~/Content/revolution-slider.css",
                    "~/Content/reset-style.css",
                    "~/Content/plkj.css",
                    "~/Content/responsive.css"));

            bundles.Add(new ScriptBundle("~/layout/js").Include(
                      "~/Scripts/jquery-2.1.4.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/menuzord.js",
                      "~/Scripts/jPushMenu.js",
                      "~/Scripts/revolution.min.js",
                      "~/Scripts/owl.js",
                      "~/Scripts/validate.min.js",
                      "~/Scripts/jquery-ui-1.11.4/jquery-ui.js",
                      "~/Scripts/jquery.appear.js",
                      "~/Scripts/isotope.pkgd.min.js",
                      "~/Scripts/jquery.countTo.js",
                      "~/Scripts/jquery.fancybox.pack.js",
                      "~/Scripts/jquery.easing.min.js",
                      "~/Scripts/wow.js",
                      "~/Scripts/rev-custom.js",
                      "~/Scripts/customcollection.js",
                      "~/Scripts/custom.js"));

            BundleTable.EnableOptimizations = true;

        }
    }
}
