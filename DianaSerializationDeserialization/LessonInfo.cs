using System;

namespace DianaSerializationDeserialization
{
    [Serializable]
    public class LessonInfo
    {
        public int LessonTime;
        public string LessonTopic;
        public string[] LessonQuestions;

        public LessonInfo()
        {
        }

        public LessonInfo(int lessonTime, string lessonTopic, string[] lessonQuestions)
        {
            LessonTime = lessonTime;
            LessonTopic = lessonTopic;
            LessonQuestions = lessonQuestions;
        }
    }
}