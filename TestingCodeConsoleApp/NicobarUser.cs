using System;

namespace TestingCodeConsoleApp
{
    public class NicobarUser
    {
        public string RegistrationPlateform { get; set; }
        public DateTime StartDate { get; set; }
        public int Confirmed { get; set; }
        public int Postponed { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int Smoker { get; set; }
        public int SmokedDuringProgram { get; set; }
        public int JoiningSmat { get; set; }
        public int LastSmoked { get; set; }
        public int Sex { get; set; }
        public string CurrentState { get; set; }
        public string UpdatedStateMessage { get; set; }
        public string Language { get; set; }
        public int SendAmiMessage { get; set; }
        public int IgnoreMessage { get; set; }
        public int IsGodFather { get; set; }
        public int IsGodChild { get; set; }
        public int MessageAmiSent { get; set; }
        public int IsJoiningSmat { get; set; }
        public int GiveUpNicobar { get; set; }
    }

    public class SurveyNicobar
    {
        public QuestionOne QuestionOne { get; set; }
        public QuestionTwo QuestionTwo { get; set; }
    }

    public class QuestionOne
    {
        public int Yes { get; set; }
        public int No { get; set; }
        public int No_Reply { get; set; }
    }

    public class QuestionTwo
    {
        public int Plus { get; set; }
        public int No_Reply { get; set; }
    }


}