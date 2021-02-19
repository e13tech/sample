using E13.Common.Data.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13.Sample.Data
{
    public class SampleContextDesignFactory : DesignTimeDbContextFactory<SampleContext>
    {
        public static void Main(string[] args)
        {
            new DevSeed().Seed(
                new SampleContextDesignFactory().CreateDbContext(args));
        }
    }
}
