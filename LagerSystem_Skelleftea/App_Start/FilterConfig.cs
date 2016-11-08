using System.Web;
using System.Web.Mvc;

namespace LagerSystem_Skelleftea
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
