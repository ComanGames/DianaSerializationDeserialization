using System;
using System.Collections.Generic;

namespace SerializationLibery
{
    [Serializable]
    public class LessonInfo
    {
        public TimeSpan LessonTime;
        public string LessonTopic;
        public List<string> LessonQuestions;

        public LessonInfo()
        {
        }

        public LessonInfo(TimeSpan lessonTime, string lessonTopic, List<string> lessonQuestions)
        {
            LessonTime = lessonTime;
            LessonTopic = lessonTopic;
            LessonQuestions = lessonQuestions;
        }
    }
}