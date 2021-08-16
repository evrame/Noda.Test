using Volo.Abp.Settings;

namespace Noda.Test.Settings
{
    public class TestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TestSettings.MySetting1));
        }
    }
}
