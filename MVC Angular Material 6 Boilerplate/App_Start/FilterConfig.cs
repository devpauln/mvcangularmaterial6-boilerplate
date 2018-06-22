using System.Web;
using System.Web.Mvc;

namespace MVC_Angular_Material_6_Boilerplate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
