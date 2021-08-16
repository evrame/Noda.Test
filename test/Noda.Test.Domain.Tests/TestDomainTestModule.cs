using Noda.Test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Noda.Test
{
    [DependsOn(
        typeof(TestEntityFrameworkCoreTestModule)
        )]
    public class TestDomainTestModule : AbpModule
    {

    }
}