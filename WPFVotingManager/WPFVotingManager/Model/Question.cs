using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFVotingManager.Model
{
    public class Question
    {
        public ObjectId Id { get; set; }
        public int Order { get; set; } = 0;
        public string Description { get; set; } = "";
        public int NumberOptions { get; set; } = 0;
        public int TypeQuestion { get; set; } = 0;
        public int TypePuntuation { get; set; } = 0;
        public int TypeIdentitifyVote { get; set; } = 0;
        public int TypeAuthorization { get; set; } = 0;
        public int TypeWeight { get; set; } = 0;
        public bool IsGeneralConfig { get; set; } = false;
        public Puntuation Puntuation { get; set; } = new Puntuation();
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public KeyPad KeyPad { get; set; } = new KeyPad();
        public Graphic Graphic { get; set; } = new Graphic();
    }


    public class Puntuation
    {
        public int Correct { get; set; } = 0;
        public int Incorrect { get; set; } = 0;
        public int TypePuntuation { get; set; } = 0;
        public string PuntuationLineal { get; set; } = "";

    }

    public class Answer
    {
        public string Order { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class KeyPad
    {
        public int TypeVote { get; set; } = 0;
        public int Format { get; set; } = 0;
        public int IsSecret { get; set; } = 0;
    }

    public class Graphic
    {
        public int TypeGraphic { get; set; } = 0;
        public int TypeResult { get; set; } = 0;
        public int Decimal { get; set; } = 0;
        public int ModeVisualization { get; set; } = 0;
        public int TypeCalculate { get; set; } = 0;
        public bool TextAnswer { get; set; } = false;

    }
}
