using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFVotingManager.Model;

namespace WPFVotingManager.Actions
{
    public class QuestionActions
    {
        readonly MongoDBConnection dBConnection = new MongoDBConnection();
        bool InsertDocumentQuestion(Question model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Question>("Question");
                collection.InsertOne(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteAllDocuments()
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Question>("Question");
                var filter = Builders<Question>.Filter.Empty;
                collection.DeleteMany(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Question GetDocumentQuestion(string id)
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Question>("Question");
            var objectid = ObjectId.Parse(id);
            var result = IMongoCollectionExtensions
                .AsQueryable(collection)
                .FirstOrDefault(s => s.Id == objectid);
            return result;
        }

        public Question GetDocumentQuestionByOrder(int orden)
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Question>("Question");
            var result = IMongoCollectionExtensions
                .AsQueryable(collection)
                .FirstOrDefault(s => s.Order == orden);
            return result;
        }

        public List<Question> GetDocumentQuestions()
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Question>("Question");
            var result = IMongoCollectionExtensions.AsQueryable(collection).ToList();
            return result;
        }

        bool UpdateDocumentQuestion(Question model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Question>("Question");
                var filter = Builders<Question>.Filter.Eq("_id", model.Id);
                var update = Builders<Question>.Update
                                .Set("Order", model.Order)
                                .Set("Description", model.Description)
                                .Set("NumberOptions", model.NumberOptions)
                                .Set("TypeAuthorization", model.TypeAuthorization)
                                .Set("TypeQuestion", model.TypeQuestion)
                                .Set("TypePuntuation", model.TypePuntuation)
                                .Set("TypeIdentitifyVote", model.TypeIdentitifyVote)
                                .Set("Puntuation", model.Puntuation)
                                .Set("KeyPad", model.KeyPad)
                                .Set("IsGeneralConfig", model.IsGeneralConfig)
                                .Set("Answers", model.Answers)
                                .Set("Graphic", model.Graphic);

                var updateResult = collection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveDocumentQuestion(Question model)
        {
            try
            {
                if (model.Id.ToString() != "000000000000000000000000")
                    UpdateDocumentQuestion(model);
                else
                    InsertDocumentQuestion(model);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteDocumentQuestion(string id)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Question>("Question");
                var objid = ObjectId.Parse(id);
                collection.DeleteOne(x => x.Id == objid);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
