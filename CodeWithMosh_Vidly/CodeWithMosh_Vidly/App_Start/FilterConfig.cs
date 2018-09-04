using System.Web;
using System.Web.Mvc;

namespace CodeWithMosh_Vidly {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
