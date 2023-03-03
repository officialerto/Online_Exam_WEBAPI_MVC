using System.Web;
using System.Web.Mvc;

namespace OnlineExam_WEBAPI_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
