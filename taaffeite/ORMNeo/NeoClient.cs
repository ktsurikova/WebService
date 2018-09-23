using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;

namespace ORMNeo
{
    public class NeoClient
    {
        private IGraphClient _client;
        private static NeoClient _neoClient;

        private NeoClient() { }

        public static NeoClient Create()
        {
            if (_neoClient == null)
            {
                _neoClient = new NeoClient();

                NeoServerConfiguration config = NeoServerConfiguration.GetConfiguration(
                    new Uri("https://hobby-cbepnjdfkcnpgbkeccdhepbl.dbs.graphenedb.com:24780/db/data/"), "serviceuser",
                    "b.oTEvTxwdQmJa.8MkxAIV51kGfdcFu");
                IGraphClientFactory factory = new GraphClientFactory(config);

                _neoClient._client = factory.Create();
            }

            return _neoClient;
        }

        public IGraphClient Client => _client;
    
    }
}
