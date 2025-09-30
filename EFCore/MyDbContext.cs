using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WinFormConnectToSqlServer_Project.EFCore
{
    public class MyDbContext :DbContext
    {
        public MyDbContext() : base("Server=DESKTOP-ABQMKQL;uid=Decade;pwd=xiaozhaiC1;Database=WinformSearch;Trusted_Connection=false;")
        {

        }

        public DbSet<ModelForEF> modelForEfInfo { get; set; }
    }
}
