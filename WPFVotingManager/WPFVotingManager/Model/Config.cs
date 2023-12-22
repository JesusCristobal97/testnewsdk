using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFVotingManager.Model
{
    public class Config
    {
        public ObjectId Id { get; set; }
        public int StationBase { get; set; }
        public QuestionGeneral QuestionGeneral { get; set; } = new QuestionGeneral();
        public GraphicGeneral GraphicGeneral { get; set; } = new GraphicGeneral();
    }

    public class GraphicGeneral
    {
        public QuestionGraphic Question { get; set; } = new QuestionGraphic();
        public AnswerGraphic Answer { get; set; } = new AnswerGraphic();
        public GraphicGraphic Graphic { get; set; } = new GraphicGraphic();

    }

    public class QuestionGeneral
    {
        public int TypeQuestion { get; set; }
        public int TypeIdentitifyVote { get; set; } = 0;
        public int TypeAuthorization { get; set; } = 0;
        public int TypeWeight { get; set; } = 0;
        public int TypeVote { get; set; } = 0;
        public int Format { get; set; } = 0;
        public int IsSecret { get; set; } = 0;
        public int TypeGraphic { get; set; } = 0;
        public int TypeResult { get; set; } = 0;
        public int Decimal { get; set; } = 0;
        public int ModeVisualization { get; set; } = 0;
        public int TypeCalculate { get; set; } = 0;
        public bool TextAnswer { get; set; } = false;

    } 
    public class QuestionGraphic
    {
        public int fontSize { get; set; } = 0;
        public int typeFont { get; set; } = 0;
        public int position { get; set; } = 0;
        public byte[] color { get; set; }
        public int mup { get; set; }
        public int mright { get; set; }
        public int muleft { get; set; }
        public int mudown { get; set; }
    } 
    public class AnswerGraphic
    {
        public int fontSize { get; set; } = 0;
        public int typeFont { get; set; } = 0;
        public int position { get; set; } = 0;
        public byte[] color { get; set; }
        public int mup { get; set; }
        public int mright { get; set; }
        public int muleft { get; set; }
        public int mudown { get; set; }
    }

    public class GraphicGraphic
    {
        public int width { get; set; } = 0;
        public int height { get; set; } = 0;
        public int position { get; set; } = 0; 
        public bool isTransparent { get; set; }
    }
}
