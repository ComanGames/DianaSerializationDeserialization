using System;
using System.Collections.Generic;
using SerializationLibery;

namespace DianaSerializationDeserialization
{
    class Utilities
    {
        public string Topic;
        public List<string> QuestionsList;
        public TimeSpan Ts;


        public void AddTopic(string topic)
        {
            Topic = topic;
        }

        public void CreatArrayOfQuestions(string question)
        {
            if (QuestionsList == null)
                QuestionsList = new List<string>();
            QuestionsList.Add(question);
        }

        public void SetTime(string ts)
        {
            Ts = TimeSpan.Parse(ts);
        }

        public LessonInfo CreateLessonInfo()
        {
            LessonInfo li = new LessonInfo(Ts, Topic, QuestionsList);
            return li;

        }
    }
}