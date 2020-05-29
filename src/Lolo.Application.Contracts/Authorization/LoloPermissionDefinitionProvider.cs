using Lolo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lolo.Authorization
{
    public class LoloPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(LoloPermissions.GroupName, L("Permission:Lolo"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoloResource>(name);
        }
    }
}