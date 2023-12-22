using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using WPFVotingManager.Model;

namespace WPFVotingManager.Actions
{
    public class ResumeActions
    {
        readonly MongoDBConnection dBConnection = new MongoDBConnection();
        bool InsertDocumentResume(Resume model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Resume>("Resume");
                collection.InsertOne(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool UpdateDocumentResume(Resume model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Resume>("Resume");

                var filter = Builders<Resume>.Filter.Eq("_id", model.Id);
                var update = Builders<Resume>.Update
                                .Set("questionId", model.questionId)
                                .Set("isVoted", model.isVoted);

                var updateResult = collection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Resume> GetDocumentResume()
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Resume>("Resume");
            var result = IMongoCollectionExtensions.AsQueryable(collection).ToList();
            return result;
        }

        public bool SaveDocumentParticipant(Resume model)
        {
            try
            {
                if (model.Id.ToString() != "000000000000000000000000")
                    UpdateDocumentResume(model);
                else
                    InsertDocumentResume(model);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
