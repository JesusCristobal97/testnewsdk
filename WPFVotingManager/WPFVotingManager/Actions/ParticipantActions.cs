using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFVotingManager.Model;

namespace WPFVotingManager.Actions
{
    public class ParticipantActions
    {
        readonly MongoDBConnection dBConnection = new MongoDBConnection();

        bool InsertDocumentParticipant(Participant model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Participant>("Participant");
                collection.InsertOne(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Participant GetDocumentParticipant(string id)
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Participant>("Participant");
            var objectid = ObjectId.Parse(id);
            var result = IMongoCollectionExtensions
                .AsQueryable(collection)
                .FirstOrDefault(s => s.Id == objectid);
            return result;
        }

        public List<Participant> GetDocumentParticipants()
        {
            var connection = dBConnection.ConnectDB();
            var collection = connection.GetCollection<Participant>("Participant");
            var result = IMongoCollectionExtensions.AsQueryable(collection).ToList();
            return result;
        }
        bool UpdateDocumentParticipant(Participant model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Participant>("Participant");

                var filter = Builders<Participant>.Filter.Eq("_id", model.Id);
                var update = Builders<Participant>.Update
                                .Set("KeyPadId", model.KeyPadId)
                                .Set("Name", model.Name)
                                .Set("Gender", model.Gender)
                                .Set("Weight", model.Weight)
                                .Set("UID", model.UID)
                                .Set("Team", model.Team)
                                .Set("City", model.City);

                var updateResult = collection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool InsertAllVotantsWithVote(List<DgParticipant> model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<DgParticipant>("DgParticipant");
                collection.InsertMany(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<DgParticipant> GetDocumentVotantsWithVote(int questionid)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<DgParticipant>("DgParticipant");
                var list = collection.Find(x => x.QuestionId == questionid).ToList();
                return list;

            }
            catch (Exception)
            {
                return new List<DgParticipant>();
            }
        }
        public List<DgParticipant> GetDocumentVotants()
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<DgParticipant>("DgParticipant");
                var result = IMongoCollectionExtensions.AsQueryable(collection).ToList();
                return result;

            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return new List<DgParticipant>();
            }
        }

        public bool DeleteAllVoteParticipants(int questionid)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<DgParticipant>("DgParticipant");
                var filter = Builders<DgParticipant>.Filter.Eq("QuestionId", questionid);
                collection.DeleteMany(filter);
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
                var collection = connection.GetCollection<Participant>("DgParticipant");
                var filter = Builders<Participant>.Filter.Empty;
                collection.DeleteMany(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveDocumentParticipant(Participant model)
        {
            try
            {
                if (model.Id.ToString() != "000000000000000000000000")
                    UpdateDocumentParticipant(model);
                else
                    InsertDocumentParticipant(model);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
