namespace Lolo
{
    public static class LoloDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Lolo";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Lolo";

        public const string MongoDbConnectionStringName = "MongoLolo";
    }
}
