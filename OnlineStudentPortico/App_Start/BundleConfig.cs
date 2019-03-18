using System.Web;
using System.Web.Optimization;

namespace OnlineStudentPortico
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region Admin Side template

            bundles.Add(new StyleBundle("~/adminLayout/css").Include(
                    "~/Content/AdminLayout/css/bootstrap.min.css",

                    "~/Content/AdminLayout/css/metisMenu.min.css",

                    "~/Content/AdminLayout/css/timeline.css",

                    "~/Content/AdminLayout/css/startmin.css",

                    "~/Content/AdminLayout/css/morris.css",

                    "~/Content/AdminLayout/css/font-awesome.min.css.css"
                ));

            bundles.Add(new ScriptBundle("~/adminLayout/js").Include(
                "~/Scripts/AdminLayout/js/jquery.min.js",
                "~/Scripts/AdminLayout/js/bootstrap.min.js",
                "~/Scripts/AdminLayout/js/metisMenu.min.js",
                "~/Scripts/AdminLayout/js/raphael.min.js",
                "~/Scripts/AdminLayout/js/morris.min.js",
                "~/Scripts/AdminLayout/js/morris-data.min.js",
                "~/Scripts/AdminLayout/js/startmin.js"

                ));
            #endregion




            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
