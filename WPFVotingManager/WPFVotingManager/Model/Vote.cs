using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFVotingManager.Model
{
    public class Vote
    {
        public ObjectId Id { get; set; }
        public int QuestionId { get; set; }
        public int KeyId { get; set; }
        public string KeyValue { get; set; }
        public DateTime FHVote { get; set; }
        public int Point { get; set; }
    }

    public class VoteGrid
    { 
        public string Option { get; set; }
        public int Votes { get; set; }
        public int Points { get; set; }
    }
}
