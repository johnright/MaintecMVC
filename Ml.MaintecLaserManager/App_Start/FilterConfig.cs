using System.Web;
using System.Web.Mvc;

namespace Ml.MaintecLaserManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
