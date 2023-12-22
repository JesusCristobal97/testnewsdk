using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFVotingManager.Model
{
    public class Resume
    {
        public ObjectId Id { get; set; }
        public int questionId { get; set; }
        public bool isVoted { get; set; }
    }
}
