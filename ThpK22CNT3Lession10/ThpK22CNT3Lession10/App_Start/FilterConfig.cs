using System.Web;
using System.Web.Mvc;

namespace ThpK22CNT3Lession10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
