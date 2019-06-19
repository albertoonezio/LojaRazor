using System.Web;
using System.Web.Optimization;

namespace LojaRazor
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle estilos = new StyleBundle("~/bundles/estilos");
            estilos.Include("~/Content/bootstrap/css/bootstrap.css");
            estilos.Include("~/Content/Style.css");
            bundles.Add(estilos);

            StyleBundle scripts = new StyleBundle("~/bundles/scripts");
            scripts.Include("~/scripts/jquery-1.7.1.js");
            scripts.Include("~/scripts/jquery.validate.js");
            scripts.Include("~/scripts/jquery.validate.unobtrusive.js");
            bundles.Add(scripts);
        }
    }
}