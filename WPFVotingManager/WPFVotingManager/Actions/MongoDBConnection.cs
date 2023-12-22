using MongoDB.Driver; 

namespace WPFVotingManager.Actions
{
    public class MongoDBConnection
    {
        public IMongoDatabase ConnectDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("EVO_KeyPAD");
            return database;
        }
    }
}
