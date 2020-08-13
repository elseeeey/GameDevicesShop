namespace GameDevicesStore.DataAcces
{
    using System.Data.Entity;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }
    }
}