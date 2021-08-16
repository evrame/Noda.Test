using System.Threading.Tasks;

namespace Noda.Test.Data
{
    public interface ITestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
