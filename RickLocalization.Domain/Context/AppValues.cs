namespace RickLocalization.Domain.Context {

    public static class AppValues {

        public const string DB_SERVER = "tcp:sql-estudo.database.windows.net,1433";
        public const string DB_NAME = "rick-localization";
        public const string DB_USER = "sqlazureadm";
        public const string DB_PASS = "";

        public static readonly string LOCALDB_CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=RickLocalization;Trusted_Connection=True";

        public static readonly string SQLSERVER_CONNECTION_STRING = $"Server={DB_SERVER};Initial Catalog={DB_NAME};Persist Security Info=False;User ID={DB_USER};Password={DB_PASS};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
