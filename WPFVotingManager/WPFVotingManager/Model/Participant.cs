using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFVotingManager.Model
{
    public class Participant
    {
        public ObjectId Id { get; set; }
        public int KeyPadId { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Weight { get; set; }
        public string UID { get; set; }
        public string Team { get; set; }
        public string City { get; set; }
    }
    public class DgParticipant
    {
        public ObjectId Id { get; set; }
        public int keyPad { get; set; }
        public int QuestionId { get; set; }
    }
}
