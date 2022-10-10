using System.Web;
using System.Web.Mvc;

namespace Tutorial_By_TimCorey
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
