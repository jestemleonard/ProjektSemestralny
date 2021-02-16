using System.Data.Entity;

namespace WPF
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
        :base("mssql")
        {
            
        }
    }
}