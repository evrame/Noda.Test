using System;
using System.Collections.Generic;
using System.Text;
using Noda.Test.Localization;
using Volo.Abp.Application.Services;

namespace Noda.Test
{
    /* Inherit your application services from this class.
     */
    public abstract class TestAppService : ApplicationService
    {
        protected TestAppService()
        {
            LocalizationResource = typeof(TestResource);
        }
    }
}
