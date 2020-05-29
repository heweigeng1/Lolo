using Volo.Abp.Reflection;

namespace Lolo.Authorization
{
    public class LoloPermissions
    {
        public const string GroupName = "Lolo";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(LoloPermissions));
        }
    }
}