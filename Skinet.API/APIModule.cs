using Autofac;

namespace Skinet.API
{
    public class APIModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public APIModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
