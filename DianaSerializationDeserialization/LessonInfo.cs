namespace DianaSerializationDeserialization
{
    internal class LessonInfo
    {
        public int LessonTime;
        public string LessonTopic;

        public LessonInfo(int lessonTime, string lessonTopic, string[] lessonQuestions)
        {
            LessonTime = lessonTime;
            LessonTopic = lessonTopic;
            LessonQuestions = lessonQuestions;
        }

        public string[] LessonQuestions;
    }
}