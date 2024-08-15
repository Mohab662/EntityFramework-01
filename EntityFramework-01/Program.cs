using EntityFramework_01.Context;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDbContext schoolDb = new SchoolDbContext();
            schoolDb.Database.Migrate();
        }
    }
}
