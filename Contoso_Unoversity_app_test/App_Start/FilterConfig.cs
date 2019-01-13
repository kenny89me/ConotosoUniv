using System.Web;
using System.Web.Mvc;

namespace Contoso_Unoversity_app_test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
