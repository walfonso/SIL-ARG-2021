using System.Web;
using System.Web.Mvc;

namespace Instituciones
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ModuloSeguridad.Filters.VerificaSession());
        }
    }
}
