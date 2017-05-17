using System.Web;
using System.Web.Optimization;

namespace PartialViewTabbed
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /* Trying to add a new bundle is not working. Initially wanted to add the bundle 
             * as bundles.Add(...../bundles/jqueryui but that was not working so included it here
             * and in the cshtml added the section scripts */
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-1.12.1.custom/jquery-ui.js",
                        "~/Scripts/jquery-ui-1.12.1.custom/jquery-ui.min.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Scripts/jquery-ui-1.12.1.custom/jquery-ui.min.css",
                      "~/Scripts/jquery-ui-1.12.1.custom/jquery-ui.structure.min.css",
                      "~/Scripts/jquery-ui-1.12.1.custom/jquery-ui.theme.min.css"));
        }
    }
}
