using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFVotingManager.Model;

namespace WPFVotingManager.Actions
{
    public class ConfigActions
    {
        readonly MongoDBConnection dBConnection = new MongoDBConnection();

        bool InsertDocumentConfig(Config model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Config>("Config");
                collection.InsertOne(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Config GetDocumentConfig(string id)
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Config>("Config");
            var objectid = ObjectId.Parse(id);
            var result = IMongoCollectionExtensions
                .AsQueryable(collection)
                .FirstOrDefault(s => s.Id == objectid);
            return result;
        }


        public List<Config> GetDocumentConfigs()
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Config>("Config");
            var result = IMongoCollectionExtensions.AsQueryable(collection).ToList();
            return result;
        }

        bool UpdateDocumentConfig(Config model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Config>("Config");

                var filter = Builders<Config>.Filter.Eq("_id", model.Id);
                var update = Builders<Config>.Update
                                .Set("StationBase", model.StationBase)
                                .Set("QuestionGeneral", model.QuestionGeneral);

                var updateResult = collection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateDocumentConfigGraphic(Config model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Config>("Config");

                var filter = Builders<Config>.Filter.Eq("_id", model.Id);
                var update = Builders<Config>.Update
                                .Set("GraphicGeneral", model.GraphicGeneral);

                var updateResult = collection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveDocumentParticipant(Config model)
        {
            try
            {
                if (model.Id.ToString() != "000000000000000000000000")
                    UpdateDocumentConfig(model);
                else
                    InsertDocumentConfig(model);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}