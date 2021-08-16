using Noda.Test.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Noda.Test.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TestController : AbpController
    {
        protected TestController()
        {
            LocalizationResource = typeof(TestResource);
        }
    }
}