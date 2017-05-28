using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GraphClient(new Uri("http://hobby-hkinhhmhoeaggbkedfeibipl.dbs.graphenedb.com:24789/db/data/"), "test", "b.F7WDytMuJiOJ.Tszh3JzHFT5LUtY9");
            client.Connect();

            client.Cypher
                .LoadCsv(new Uri(""))
        }
    }
}
