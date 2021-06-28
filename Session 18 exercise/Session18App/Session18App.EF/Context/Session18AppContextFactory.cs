using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session18App.EF.Context
{
    public class Session18AppContextFactory: IDesignTimeDbContextFactory<Session18AppContext>
    {
        public Session18AppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Session18AppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JQOORR3;Initial Catalog=Session18;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new Session18AppContext(optionsBuilder.Options);
        }
    }
}

