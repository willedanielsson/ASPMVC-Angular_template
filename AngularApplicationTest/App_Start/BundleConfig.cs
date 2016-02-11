using System.Web;
using System.Web.Optimization;

namespace AngularApplicationTest {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularApplicationTest")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/AngularApplicationTest.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
