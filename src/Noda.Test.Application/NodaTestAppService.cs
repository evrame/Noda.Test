using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Noda.Test.Dtos;

namespace Noda.Test
{
    [AllowAnonymous]
    public class NodaTestAppService : TestAppService, INodaTestAppService
    {
        public Task PostNodaTest([FromBody]NodaTestDto dto)
        {
            return Task.CompletedTask;
        }

        public Task GetNodaTest(NodaTestDto dto)
        {
            return Task.CompletedTask;
        }
    }
}
