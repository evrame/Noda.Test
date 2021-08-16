using System.Threading.Tasks;
using Noda.Test.Dtos;
using Volo.Abp.DependencyInjection;

namespace Noda.Test
{
    public interface INodaTestAppService: ITransientDependency
    {
        Task PostNodaTest(NodaTestDto dto);
        Task GetNodaTest(NodaTestDto dto);
    }
}
