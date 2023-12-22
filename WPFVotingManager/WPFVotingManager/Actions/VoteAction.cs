using MongoDB.Driver; 
using System;
using System.Collections.Generic;
using System.Text;
using WPFVotingManager.Model;

namespace WPFVotingManager.Actions
{
    public class VoteAction
    {
        readonly MongoDBConnection dBConnection = new MongoDBConnection();
        public bool InsertDocumentVote(Vote model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                collection.InsertOne(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertAllDocumentVote(List<Vote> model)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                collection.InsertMany(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteVoteByKeyPadOption(int keypad, int point)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                collection.DeleteOne(x => x.KeyId == keypad && x.Point == point);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Vote> GetVotesByQuestion(int questionid)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                var list = collection.Find(x => x.QuestionId == questionid).ToList();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Vote> GetVotes()
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                var result = IMongoCollectionExtensions.AsQueryable(collection).ToList();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteAllDocuments()
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                var filter = Builders<Vote>.Filter.Empty;
                collection.DeleteMany(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAllDocumentsByQuestion(int question)
        {
            try
            {
                var connection = dBConnection.ConnectDB();
                var collection = connection.GetCollection<Vote>("Vote");
                var filter = Builders<Vote>.Filter.Eq("QuestionId", question);

                collection.DeleteMany(filter);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
