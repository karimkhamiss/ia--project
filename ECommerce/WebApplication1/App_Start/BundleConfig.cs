using System.Web;
using System.Web.Optimization;

namespace Ecommerce
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/js/main").Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap-select.min.js",
                      "~/Scripts/main.js",
                      "~/Scripts/handler.js"));
            bundles.Add(new ScriptBundle("~/bundles/js/profile").Include(
                      "~/Content/css/profile.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/js/home").Include(
                      "~/Content/css/home-page.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/js/control-panel").Include(
                      "~/Content/css/control-panel.js"
                      ));
            bundles.Add(new StyleBundle("~/bundles/css/main").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/bootstrap-select.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/main.css"
                      ));
            bundles.Add(new StyleBundle("~/bundles/css/profile").Include(
                      "~/Content/css/profile.css",
                      "~/Content/css/horizontal-navbar.css"
                      ));
            bundles.Add(new StyleBundle("~/bundles/css/home").Include(
                      "~/Content/css/home-page.css"
                      ));
            bundles.Add(new StyleBundle("~/bundles/css/control-panel").Include(
                      "~/Content/css/control-panel.css",
                      "~/Content/css/horizontal-navbar.css"
                      ));

        }
    }
}
